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
    public partial class FrmManageSimulation : Form
    {
        public FrmManageSimulation()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Api.ResponseData resp = Api.EnbleSession();

            if (!resp.result)
            {
                MessageBox.Show(resp.message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEndSession_Click(object sender, EventArgs e)
        {

            Api.ResponseData resp = Api.ForceEndSession();

            if (!resp.result)
            {
                MessageBox.Show(resp.message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else this.Close();
        }
    }
}
