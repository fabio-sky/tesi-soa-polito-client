using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TesiSoaClient
{
    internal class Api
    {
        public enum CameraMovement
        {
            UP, DOWN, LEFT, RIGHT
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

        public struct UpdateCameraViewData
        {
            public string camera;
        }

        #endregion

        #region Methodes to send requests
        public static async Task<ResponseData> TestConnection()
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

        public static async Task<ResponseData> SetSession(SessionInfo data)
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

        public static async Task<ResponseData> DeleteSession(string sessionId)
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

        #endregion
    }
}
