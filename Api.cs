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
                HttpResponseMessage resp = await AppData.Instance.Client.PostAsync("/delay", content);

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
