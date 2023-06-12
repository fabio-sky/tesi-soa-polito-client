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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            if (AppData.Instance.OculusIpAddress != null)
            {
                string[] ip = AppData.Instance.OculusIpAddress.Split('.');
                if (ip.Length == 4)
                {
                    txtIp1.Text = ip[0];
                    txtIp2.Text = ip[1];
                    txtIp3.Text = ip[2];
                    txtIp4.Text = ip[3];
                }


            }
        }


        private bool HandleUpdateIp()
        {
            string ip1 = txtIp1.Text.Trim();
            string ip2 = txtIp2.Text.Trim();
            string ip3 = txtIp3.Text.Trim();
            string ip4 = txtIp4.Text.Trim();

            if (ip1.Length == 0 || ip2.Length == 0 || ip3.Length == 0 || ip4.Length == 0)
            {
                lblIpError.Visible = true;
                return false;
            }


            int ip1Int = Convert.ToInt16(ip1);
            int ip2Int = Convert.ToInt16(ip2);
            int ip3Int = Convert.ToInt16(ip3);
            int ip4Int = Convert.ToInt16(ip4);

            if (ip1Int > 255 || ip2Int > 255 || ip3Int > 255 || ip4Int > 255)
            {
                lblIpError.Visible = true;
                return false;
            }


            lblIpError.Visible = false;

            AppData.Instance.UpdateIpAddress(ip1 + "." + ip2 + "." + ip3 + "." + ip4);

            return true;
        }

        private async Task HandleNext()
        {

            if (HandleUpdateIp())
            {
                Api.ResponseData response = await Api.TestConnection();

                if (response.result)
                {
                    MessageBox.Show("IP address updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(response.message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void HandleUpdateSampling()
        {
            Api.UpdateSamplingData data = new() { log = Convert.ToInt32(NumLogSamplig.Value), position= Convert.ToInt32(NumPositionSampling.Value) };
            Api.UpdateSampling(data);
        }

        private void HandleUpdateTable()
        {
            Api.UpdateTableData data = new() { value=Convert.ToInt32(NumTableHeight.Value) };
            Api.UpdateTableHeight(data);
        }


        private void txtIp1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnConfirmIp_Click(object sender, EventArgs e)
        {
            HandleNext();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HandleUpdateTable();
        }

        private void BtnSampling_Click(object sender, EventArgs e)
        {
            HandleUpdateSampling();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
