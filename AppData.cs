using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TesiSoaClient
{
    /// <summary>
    /// Singleton class
    /// </summary>
    internal sealed class AppData
    {

        public const string PORT = "8080";

        private static AppData? instance = null;
        private static readonly object padlock = new();

        /// <summary>
        /// Singlelton initialization
        /// </summary>
        public static AppData Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new AppData();
                    }
                    return instance;
                }
            }
        }

        private SessionInfo? _actualSession;
        public SessionInfo? ActualSession
        {
            get { return _actualSession; }
            set { _actualSession = value; }
        }

        private HttpClient? _httpClient;
        public HttpClient Client
        {
            get { return _httpClient; }
        }

        private string _oculusIpAddress;
        public string OculusIpAddress
        {
            get { return _oculusIpAddress; }
        }

        public bool CheckOculusIpAddressIsSet()
        {
            return _oculusIpAddress.Length > 0;
        }

        
        /// <summary>
        /// Constructor
        /// </summary>
        private AppData()
        {
            _oculusIpAddress = "";
        }

        private void InitializeHttpClient()
        {
            if (_httpClient != null)
            {
                _httpClient.CancelPendingRequests();
            }

            _httpClient = new HttpClient
            {
                //Timeout = TimeSpan.FromSeconds(10),
                BaseAddress = new Uri("http://" + _oculusIpAddress + ":" + PORT)
            };
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        

        public void UpdateIpAddress(string newIpAddress)
        {
            _oculusIpAddress = newIpAddress.Trim();

            ///Initialization needed every time IP is changed because httpClient BaseAddress cannot be modified
            ///after the first request is sent
            InitializeHttpClient();
        }

    }


}
