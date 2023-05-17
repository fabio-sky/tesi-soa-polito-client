using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TesiSoaClient
{
    internal class Api
    {
        private record class ApiErrorMessages
        {
            public const string IP_NOT_SET = "IP address is not set";
        }

        public struct ResponseData
        {
            public bool result;
            public string message;
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
    }
}
