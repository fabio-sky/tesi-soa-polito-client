using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TesiSoaClient
{
    internal class Api
    {

        const string ACTION_DELIMITER = "##";

        public enum CameraMovement
        {
            UP, DOWN, LEFT, RIGHT
        }

        public enum TableMovement
        {
            FORWARD,
            BACKWARD
        }

        enum ActionCode
        {
            TEST_CONNECTION,
            START_SESSION,
            FORCE_END_SESSION, 
            ENABLE_SESSION,
            GET_SESSIONS_LIST,

            DELETE_SESSION,
            DOWNLOAD_SESSION,

            BUTTON_POSITION,
            MOVE_BUTTON,
            TABLE_DIMENSIONS,
            TABLE_POSITION,
            CAMERA_USER_POSITION,

            BUTTON_PRESSED,
            BUTTON_RELEASED
        }

        #region Error messages
        private record class ApiErrorMessages
        {
            public const string IP_NOT_SET = "IP address is not set";
        }
        #endregion

        #region Request and response data structures
        public struct ResponseData
        {
            public bool result;
            public string message;
        }

        public struct SessionData
        {
            public string Name;
            public string Description;
            public string Identifier;
            public DateTime CreatedAt;
        }

        public struct ResponseDataWithLPayload<T>
        {
            public bool result;
            public string message;
            public T[] data;
        }

        private struct UpdateDelayData
        {
            public int delay;
        }

        public struct UpdateBooleanData
        {
            public bool localMirror;
            public bool characterMirror;
            public bool rotationMirror;
        }

        public struct UpdateStringProp
        {
            public string value;
        }

        public struct UpdateCameraViewData
        {
            public string camera;
        }

        public struct UpdateSamplingData
        {
            public int position;
            public int log;
        }

        public struct UpdateTableData
        {
            public int value;
        }

        public struct UpdateButtonPositionData
        {
            public int horizontal;
            public int vertical;
        }

        public struct UpdateTableDimensionData
        {
            public int height;
            public int width;
            public int depth;
        }

        public struct UpdateCameraPositionData
        {
            public CameraMovement direction;
        }

        public struct UpdateTablePositionData
        {
            public TableMovement direction;
        }

        public struct BlockData
        {
            public string id;
            public int numberOfTry;
            public int restTime;
            public int delay;
            public string target;
        }

        public struct DownloadSessionProp
        {
            public string sessionId;
            public string sendTo;
        }

        #endregion

        private static string CombineMessage(ActionCode action, string json)
        {
            return string.Join(ACTION_DELIMITER, action.ToString(), json);
        }

        private static string SendRequest(string message, bool ignoreResponse = false)
        {

            ResponseData retData = new()
            {
                result = false,
                message = ApiErrorMessages.IP_NOT_SET
            };

            if (AppData.Instance.CheckOculusIpAddressIsSet() == false) return JsonConvert.SerializeObject(retData);

            IPAddress? vrIp = IPAddress.Parse(AppData.Instance.OculusIpAddress);


            if (vrIp == null)
            {
                return JsonConvert.SerializeObject(retData); ; ;
            }

            IPEndPoint vrEndPoint = new(vrIp, Convert.ToInt32(AppData.PORT));
            Socket sender = new(vrIp.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                sender.Connect(vrEndPoint);


                byte[] messageSent = Encoding.ASCII.GetBytes(message + "<EOF>");
                int byteSent = sender.Send(messageSent);

                if (ignoreResponse)
                {
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                    return "";
                }

                // Data buffer
                byte[] messageReceived = new byte[1024];
                string data = null;

                // We receive the message using
                // the method Receive(). This
                // method returns number of bytes
                // received, that we'll use to
                // convert them to string


                while (true)
                {
                    int byteRecv = sender.Receive(messageReceived);
                    data += Encoding.ASCII.GetString(messageReceived, 0, byteRecv);

                    if (data.IndexOf("<EOF>") > -1)
                        break;
                }

                
               
                // Close Socket using
                // the method Close()
                sender.Shutdown(SocketShutdown.Both);
                sender.Close();

                string json = data.Replace("<EOF>", "");

                //retData = JsonConvert.DeserializeObject<ResponseData>(json);

                return json;

            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                retData.result = false;
                retData.message = "ERR: " + e.Message;

                return JsonConvert.SerializeObject(retData); ;
            }
        }


        #region Methodes to send requests

        public static ResponseData TestConnection()
        {
            string responseJson = SendRequest(CombineMessage(ActionCode.TEST_CONNECTION, ""));
            return JsonConvert.DeserializeObject<ResponseData>(responseJson);
        }

        public static ResponseData ButtonPressed()
        {
            string responseJson = SendRequest(CombineMessage(ActionCode.BUTTON_PRESSED, ""));
            return JsonConvert.DeserializeObject<ResponseData>(responseJson);
        }

        public static ResponseData ButtonReleased()
        {
            string responseJson = SendRequest(CombineMessage(ActionCode.BUTTON_RELEASED, ""));
            return JsonConvert.DeserializeObject<ResponseData>(responseJson);
        }



        public static ResponseData SetSession(SessionInfo data)
        {
            string json = JsonConvert.SerializeObject(data);
            string responseJson = SendRequest(CombineMessage(ActionCode.START_SESSION, json));
            return JsonConvert.DeserializeObject<ResponseData>(responseJson);
        }

        public static ResponseData ForceEndSession()
        {
            string responseJson = SendRequest(CombineMessage(ActionCode.FORCE_END_SESSION, ""));
            return JsonConvert.DeserializeObject<ResponseData>(responseJson);
        }

        public static ResponseData SetButtonPosition(UpdateButtonPositionData data)
        {
            string json = JsonConvert.SerializeObject(data);
            string responseJson = SendRequest(CombineMessage(ActionCode.BUTTON_POSITION, json));
            return JsonConvert.DeserializeObject<ResponseData>(responseJson);
        }

        public static ResponseData UpdateButtonPosition(CameraMovement direction)
        {
            UpdateCameraPositionData data = new() { direction = direction };
            string json = JsonConvert.SerializeObject(data);
            string responseJson = SendRequest(CombineMessage(ActionCode.MOVE_BUTTON, json));
            return JsonConvert.DeserializeObject<ResponseData>(responseJson);
        }

        public static ResponseData SetTableDimensions(UpdateTableDimensionData data)
        {
            string json = JsonConvert.SerializeObject(data);
            string responseJson = SendRequest(CombineMessage(ActionCode.TABLE_DIMENSIONS, json));
            return JsonConvert.DeserializeObject<ResponseData>(responseJson);
        }

        public static ResponseData SetTablePosition(TableMovement direction)
        {
            UpdateTablePositionData data = new() { direction = direction };
            string json = JsonConvert.SerializeObject(data);
            string responseJson = SendRequest(CombineMessage(ActionCode.TABLE_POSITION, json));
            return JsonConvert.DeserializeObject<ResponseData>(responseJson);
        }

        public static ResponseData SetUserCameraPosition(CameraMovement direction)
        {
            UpdateCameraPositionData data = new() { direction = direction };
            string json = JsonConvert.SerializeObject(data);
            string responseJson = SendRequest(CombineMessage(ActionCode.CAMERA_USER_POSITION, json));
            return JsonConvert.DeserializeObject<ResponseData>(responseJson);
        }

      

        public static ResponseDataWithLPayload<SessionData> GetSessionsList()
        {
            string responseJson = SendRequest(CombineMessage(ActionCode.GET_SESSIONS_LIST, ""));
            //return new() { data = Array.Empty<SessionData>() };
            return JsonConvert.DeserializeObject<ResponseDataWithLPayload<SessionData>>(responseJson);
        }

        public static ResponseData DeleteSession(UpdateStringProp data)
        {
            string json = JsonConvert.SerializeObject(data);
            string responseJson = SendRequest(CombineMessage(ActionCode.DELETE_SESSION, json));
            return JsonConvert.DeserializeObject<ResponseData>(responseJson);
        }

        public static void DownloadSession(DownloadSessionProp data)
        {
            string json = JsonConvert.SerializeObject(data);
            SendRequest(CombineMessage(ActionCode.DOWNLOAD_SESSION, json), true);
           // return JsonConvert.DeserializeObject<ResponseData>(responseJson);
        }

        public static ResponseData EnbleSession()
        {
            string responseJson = SendRequest(CombineMessage(ActionCode.ENABLE_SESSION, ""));
            return JsonConvert.DeserializeObject<ResponseData>(responseJson);
        }



        // ########################## DEPRECATED METHODS ##############################

        [Obsolete("TestConnectionOld is deprecated, please use Method2 instead.", true)]
        public static async Task<ResponseData> TestConnectionOld()
        {
            ResponseData retData = new()
            {
                result = false,
                message = ApiErrorMessages.IP_NOT_SET
            };

            if (AppData.Instance.CheckOculusIpAddressIsSet() == false) return retData;

            try
            {
                string json = await AppData.Instance.Client.GetStringAsync("/test");
                retData = JsonConvert.DeserializeObject<ResponseData>(json);
            }
            catch (HttpRequestException error)
            {
                retData.message = error.Message;
            }
            catch (InvalidOperationException error)
            {
                retData.message = error.Message;
            }
            catch (TaskCanceledException error)
            {
                retData.message = error.Message;
            }
            catch(Exception error)
            {
                retData.message = error.Message;
            }

            return retData;
        }

        
        public static async Task<ResponseData> SetDelay(int delay)
        {
            ResponseData retData = new()
            {
                result = false,
                message = ApiErrorMessages.IP_NOT_SET
            };

            if (AppData.Instance.CheckOculusIpAddressIsSet() == false) return retData;

            try
            {
                UpdateDelayData body = new() { delay = delay };
                StringContent content = new(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
                HttpResponseMessage resp = await AppData.Instance.Client.PostAsync("world/delay", content);

                string json = await resp.Content.ReadAsStringAsync();

                retData = JsonConvert.DeserializeObject<ResponseData>(json);
            }
            catch (HttpRequestException error)
            {
                retData.message = error.Message;
            }
            catch (InvalidOperationException error)
            {
                retData.message = error.Message;
            }
            catch (TaskCanceledException error)
            {
                retData.message = error.Message;
            }
            catch (Exception error)
            {
                retData.message = error.Message;
            }

            return retData;
        }

        public static async Task<ResponseData> SetBooleans(UpdateBooleanData data)
        {
            ResponseData retData = new()
            {
                result = false,
                message = ApiErrorMessages.IP_NOT_SET
            };

            if (AppData.Instance.CheckOculusIpAddressIsSet() == false) return retData;

            try
            {
                StringContent content = new(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
                HttpResponseMessage resp = await AppData.Instance.Client.PostAsync("world/boolean", content);

                string json = await resp.Content.ReadAsStringAsync();

                retData = JsonConvert.DeserializeObject<ResponseData>(json);
            }
            catch (HttpRequestException error)
            {
                retData.message = error.Message;
            }
            catch (InvalidOperationException error)
            {
                retData.message = error.Message;
            }
            catch (TaskCanceledException error)
            {
                retData.message = error.Message;
            }
            catch (Exception error)
            {
                retData.message = error.Message;
            }

            return retData;
        }

        public static async Task<ResponseData> SetCameraView(UpdateCameraViewData data)
        {
            ResponseData retData = new()
            {
                result = false,
                message = ApiErrorMessages.IP_NOT_SET
            };

            if (AppData.Instance.CheckOculusIpAddressIsSet() == false) return retData;

            try
            {
                StringContent content = new(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
                HttpResponseMessage resp = await AppData.Instance.Client.PostAsync("world/camera/view", content);

                string json = await resp.Content.ReadAsStringAsync();
                retData = JsonConvert.DeserializeObject<ResponseData>(json);
            }
            catch (HttpRequestException error)
            {
                retData.message = error.Message;
            }
            catch (InvalidOperationException error)
            {
                retData.message = error.Message;
            }
            catch (TaskCanceledException error)
            {
                retData.message = error.Message;
            }
            catch (Exception error)
            {
                retData.message = error.Message;
            }

            return retData;
        }

        public static async Task<ResponseData> SetSessionOld(SessionInfo data)
        {
            ResponseData retData = new()
            {
                result = false,
                message = ApiErrorMessages.IP_NOT_SET
            };

            if (AppData.Instance.CheckOculusIpAddressIsSet() == false) return retData;

            try
            {
                StringContent content = new(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
                HttpResponseMessage resp = await AppData.Instance.Client.PostAsync("session", content);

                string json = await resp.Content.ReadAsStringAsync();
                retData = JsonConvert.DeserializeObject<ResponseData>(json);
            }
            catch (HttpRequestException error)
            {
                retData.message = error.Message;
            }
            catch (InvalidOperationException error)
            {
                retData.message = error.Message;
            }
            catch (TaskCanceledException error)
            {
                retData.message = error.Message;
            }
            catch (Exception error)
            {
                retData.message = error.Message;
            }

            return retData;
        }

        public static async Task<ResponseData> EndSession()
        {
            ResponseData retData = new()
            {
                result = false,
                message = ApiErrorMessages.IP_NOT_SET
            };

            if (AppData.Instance.CheckOculusIpAddressIsSet() == false) return retData;

            try
            {
                HttpResponseMessage resp = await AppData.Instance.Client.PostAsync("session/end", null);

                string json = await resp.Content.ReadAsStringAsync();
                retData = JsonConvert.DeserializeObject<ResponseData>(json);
            }
            catch (HttpRequestException error)
            {
                retData.message = error.Message;
            }
            catch (InvalidOperationException error)
            {
                retData.message = error.Message;
            }
            catch (TaskCanceledException error)
            {
                retData.message = error.Message;
            }
            catch (Exception error)
            {
                retData.message = error.Message;
            }

            return retData;
        }

        public static async Task<ResponseDataWithLPayload<SessionData>> GetSession()
        {
            ResponseDataWithLPayload<SessionData> retData = new()
            {
                result = false,
                message = ApiErrorMessages.IP_NOT_SET
                
            };

            if (AppData.Instance.CheckOculusIpAddressIsSet() == false) return retData;

            try
            {
                HttpResponseMessage resp = await AppData.Instance.Client.GetAsync("sessions-list");

                string json = await resp.Content.ReadAsStringAsync();
                Debug.WriteLine(json);
                retData = JsonConvert.DeserializeObject<ResponseDataWithLPayload<SessionData>>(json);
            }
            catch (HttpRequestException error)
            {
                retData.message = error.Message;
            }
            catch (InvalidOperationException error)
            {
                retData.message = error.Message;
            }
            catch (TaskCanceledException error)
            {
                retData.message = error.Message;
            }
            catch (Exception error)
            {
                retData.message = error.Message;
            }

            return retData;
        }

        public static async Task<ResponseData> StartHandLog()
        {
            ResponseData retData = new()
            {
                result = false,
                message = ApiErrorMessages.IP_NOT_SET

            };

            if (AppData.Instance.CheckOculusIpAddressIsSet() == false) return retData;

            try
            {
                HttpResponseMessage resp = await AppData.Instance.Client.PutAsync("log/hand/start", null);

                string json = await resp.Content.ReadAsStringAsync();
                retData = JsonConvert.DeserializeObject<ResponseData>(json);
            }
            catch (HttpRequestException error)
            {
                retData.message = error.Message;
            }
            catch (InvalidOperationException error)
            {
                retData.message = error.Message;
            }
            catch (TaskCanceledException error)
            {
                retData.message = error.Message;
            }
            catch (Exception error)
            {
                retData.message = error.Message;
            }

            return retData;
        }

        public static async Task<ResponseData> StopHandLog()
        {
            ResponseData retData = new()
            {
                result = false,
                message = ApiErrorMessages.IP_NOT_SET

            };

            if (AppData.Instance.CheckOculusIpAddressIsSet() == false) return retData;

            try
            {
                HttpResponseMessage resp = await AppData.Instance.Client.PutAsync("log/hand/stop", null);

                string json = await resp.Content.ReadAsStringAsync();
                retData = JsonConvert.DeserializeObject<ResponseData>(json);
            }
            catch (HttpRequestException error)
            {
                retData.message = error.Message;
            }
            catch (InvalidOperationException error)
            {
                retData.message = error.Message;
            }
            catch (TaskCanceledException error)
            {
                retData.message = error.Message;
            }
            catch (Exception error)
            {
                retData.message = error.Message;
            }

            return retData;
        }

        public static async Task<ResponseData> DeleteSessionOld(string sessionId)
        {
            ResponseData retData = new()
            {
                result = false,
                message = ApiErrorMessages.IP_NOT_SET

            };

            if (AppData.Instance.CheckOculusIpAddressIsSet() == false) return retData;

            try
            {
                HttpResponseMessage resp = await AppData.Instance.Client.DeleteAsync("session?sessionId=" + sessionId);

                string json = await resp.Content.ReadAsStringAsync();
                retData = JsonConvert.DeserializeObject<ResponseData>(json);
            }
            catch (HttpRequestException error)
            {
                retData.message = error.Message;
            }
            catch (InvalidOperationException error)
            {
                retData.message = error.Message;
            }
            catch (TaskCanceledException error)
            {
                retData.message = error.Message;
            }
            catch (Exception error)
            {
                retData.message = error.Message;
            }

            return retData;
        }

        public static async Task<ResponseData> GetSessionLogs(string sessionId, string ip)
        {
            ResponseData retData = new()
            {
                result = false,
                message = ApiErrorMessages.IP_NOT_SET

            };

            if (AppData.Instance.CheckOculusIpAddressIsSet() == false) return retData;

            try
            {
                HttpResponseMessage resp = await AppData.Instance.Client.GetAsync("session/log?sessionId=" + sessionId + "&sendTo=" + ip);

                string json = await resp.Content.ReadAsStringAsync();
                retData = JsonConvert.DeserializeObject<ResponseData>(json);
            }
            catch (HttpRequestException error)
            {
                retData.message = error.Message;
            }
            catch (InvalidOperationException error)
            {
                retData.message = error.Message;
            }
            catch (TaskCanceledException error)
            {
                retData.message = error.Message;
            }
            catch (Exception error)
            {
                retData.message = error.Message;
            }

            return retData;
        }

        [Obsolete("TestConnectionOld is deprecated, please use Method2 instead.", true)]
        public static async Task<ResponseDataWithLPayload<SessionData>> MoveCamera(CameraMovement movement)
        {
            ResponseDataWithLPayload<SessionData> retData = new()
            {
                result = false,
                message = ApiErrorMessages.IP_NOT_SET

            };

            if (AppData.Instance.CheckOculusIpAddressIsSet() == false) return retData;

            try
            {
                HttpResponseMessage resp = await AppData.Instance.Client.PutAsync("camera?movement=" + movement.ToString(), null);

                string json = await resp.Content.ReadAsStringAsync();
                retData = JsonConvert.DeserializeObject<ResponseDataWithLPayload<SessionData>>(json);
            }
            catch (HttpRequestException error)
            {
                retData.message = error.Message;
            }
            catch (InvalidOperationException error)
            {
                retData.message = error.Message;
            }
            catch (TaskCanceledException error)
            {
                retData.message = error.Message;
            }
            catch (Exception error)
            {
                retData.message = error.Message;
            }

            return retData;
        }

        public static async Task<ResponseData> UpdateTableHeight(UpdateTableData data)
        {
            ResponseData retData = new()
            {
                result = false,
                message = ApiErrorMessages.IP_NOT_SET
            };

            if (AppData.Instance.CheckOculusIpAddressIsSet() == false) return retData;

            try
            {
                StringContent content = new(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
                HttpResponseMessage resp = await AppData.Instance.Client.PostAsync("objects/table", content);

                string json = await resp.Content.ReadAsStringAsync();
                retData = JsonConvert.DeserializeObject<ResponseData>(json);
            }
            catch (HttpRequestException error)
            {
                retData.message = error.Message;
            }
            catch (InvalidOperationException error)
            {
                retData.message = error.Message;
            }
            catch (TaskCanceledException error)
            {
                retData.message = error.Message;
            }
            catch (Exception error)
            {
                retData.message = error.Message;
            }

            return retData;
        }

        public static async Task<ResponseData> UpdateSampling(UpdateSamplingData data)
        {
            ResponseData retData = new()
            {
                result = false,
                message = ApiErrorMessages.IP_NOT_SET
            };

            if (AppData.Instance.CheckOculusIpAddressIsSet() == false) return retData;

            try
            {
                StringContent content = new(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
                HttpResponseMessage resp = await AppData.Instance.Client.PostAsync("settings/sampling", content);

                string json = await resp.Content.ReadAsStringAsync();
                retData = JsonConvert.DeserializeObject<ResponseData>(json);
            }
            catch (HttpRequestException error)
            {
                retData.message = error.Message;
            }
            catch (InvalidOperationException error)
            {
                retData.message = error.Message;
            }
            catch (TaskCanceledException error)
            {
                retData.message = error.Message;
            }
            catch (Exception error)
            {
                retData.message = error.Message;
            }

            return retData;
        }

        #endregion


       
    }
}
