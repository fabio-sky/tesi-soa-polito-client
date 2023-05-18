using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            
        }

        private async void GetSessions()
        {
            Api.ResponseDataWithLPayload<Api.SessionData> response = await Api.GetSession();

            if (!response.result)
            {
                MessageBox.Show(response.message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach(Api.SessionData session in response.data)
            {
                SessionItem item = new()
                {
                    Identifier = session.id,
                    SessionName = session.name,
                    Description = session.description,
                    BtnDownloadOnPress = HandleDownloadSession,
                    BtnDeleteOnPress = HandleDeleteSession
                };

                FlowLayoutSession.Controls.Add(item);
            }
        }

        private void HandleDownloadSession(string id)
        {
            MessageBox.Show(id);
        }

        private void HandleDeleteSession(string id)
        {
            MessageBox.Show(id);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Form formIp = new FormOculusIp();
            formIp.ShowDialog();
        }

        private void BtnNewSession_Click(object sender, EventArgs e)
        {
            Form formSession = new FormNewSession();
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
