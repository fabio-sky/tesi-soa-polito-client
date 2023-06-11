using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesiSoaClient
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            LblDate.Text = DateTime.Now.ToString("D");
        }

        private async void GetSessions()
        {
            Api.ResponseDataWithLPayload<Api.SessionData> response = await Api.GetSession();

            if (!response.result)
            {
                MessageBox.Show(response.message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            FlowLayoutSession.Controls.Clear();

            foreach (Api.SessionData session in response.data)
            {
                SessionItem item = new()
                {
                    Identifier = session.Identifier,
                    SessionName = session.Name,
                    Description = session.Description,
                    CreatedAt = session.CreatedAt,
                    BtnDownloadOnPress = HandleDownloadSession,
                    BtnDeleteOnPress = HandleDeleteSession
                };

                FlowLayoutSession.Controls.Add(item);
            }
        }

        private IPAddress? FindIpAddress() {

            IPAddress[] localIPs = Dns.GetHostAddresses(System.Environment.MachineName);

            string[] dividedOculusIp = AppData.Instance.OculusIpAddress.Split('.');

            return localIPs.FirstOrDefault((v) => v.MapToIPv4().ToString().StartsWith(string.Concat(dividedOculusIp[0], ".", dividedOculusIp[1], ".", dividedOculusIp[2])));

        }

        private void HandleDownloadSession(string id)
        {

            LblDownload.Text = "Downloading " + id + " data...";
            LblDownload.Visible = true;

            try
            {
                byte[] buffer;

                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {

                    string selectedPath = folderBrowser.SelectedPath;
                    IPAddress? relevantIp = FindIpAddress();

                    if (relevantIp == null) {
                        MessageBox.Show("No IP found");
                        return;
                    };

                    Api.GetSessionLogs(id, relevantIp.MapToIPv4().ToString());

                    //Listen for file dimension
                    TcpListener listenerInfo = new(relevantIp, 5050);
                    listenerInfo.Server.ReceiveTimeout = 5000;
                    listenerInfo.Start();

                    TcpClient client = listenerInfo.AcceptTcpClient();
                    StreamReader sInfo = new(client.GetStream());

                    string rawFileSize = sInfo.ReadToEnd();

                    int fileSize = int.Parse(rawFileSize);

                    listenerInfo.Stop();
                    client.Close();

                    //Listen for file data
                    TcpListener listenerFile = new(relevantIp, 5055);
                    listenerFile.Server.ReceiveTimeout = 5000;
                    listenerFile.Start();

                    client = listenerFile.AcceptTcpClient();

                    Stream sFile = client.GetStream();

                    buffer = new byte[fileSize];

                    sFile.Read(buffer, 0, fileSize);

                    File.WriteAllBytes(Path.Combine(selectedPath, id + "_DATA.zip"), buffer);

                    listenerFile.Stop();
                    client.Close();

                    Process.Start("explorer.exe", selectedPath);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Download session", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            LblDownload.Visible = false;

        }

        private async void HandleDeleteSession(string id)
        {
            Api.ResponseData resp = await Api.DeleteSession(id);

            if(!resp.result)
            {
                MessageBox.Show(resp.message, "Delete session", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GetSessions();
        }

        /// <summary>
        /// When formOculusIp is closed
        /// </summary>
        private void FormOculusIp_Closed(object? sender, FormClosedEventArgs e)
        {
            GetSessions();
        }

        /// <summary>
        /// When formSession is closed
        /// </summary>
        private void FormSession_Closed(object? sender, FormClosedEventArgs e)
        {
            if(AppData.Instance.ActualSession != null)
            {
                FormSimulationSetting frmSimSettings = new();
                frmSimSettings.ShowDialog();
            }
           
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Form formIp = new FormOculusIp();
            formIp.FormClosed += new FormClosedEventHandler(FormOculusIp_Closed);
            formIp.ShowDialog();
        }

        private void BtnNewSession_Click(object sender, EventArgs e)
        {
            Form formSession = new FormNewSession();
            formSession.FormClosed += new FormClosedEventHandler(FormSession_Closed);
            formSession.ShowDialog();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            Form formIp = new FormOculusIp();
            formIp.ShowDialog();
        }

        private void BtnSync_Click(object sender, EventArgs e)
        {
            GetSessions();
        }
    }
}
