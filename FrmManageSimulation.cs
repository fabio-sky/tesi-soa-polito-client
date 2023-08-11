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

        private void BtnButtonPos_Click(object sender, EventArgs e)
        {
            Api.UpdateButtonPositionData data = new() { horizontal = Convert.ToInt32(NumButtonHorPos.Value), vertical = Convert.ToInt32(NumButtonVertPos.Value) };
            Api.ResponseData resp = Api.SetButtonPosition(data);

            if (!resp.result)
            {
                MessageBox.Show(resp.message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTable_Click(object sender, EventArgs e)
        {
            Api.UpdateTableDimensionData data = new() { depth = Convert.ToInt32(NumTableDepth.Value), height = Convert.ToInt32(NumTableHeight.Value), width = Convert.ToInt32(NumTableWidth.Value) };
            Api.ResponseData resp = Api.SetTableDimensions(data);

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

        private void BtnUp_Click(object sender, EventArgs e)
        {
            Api.SetUserCameraPosition(Api.CameraMovement.UP);
        }

        private void BtnDown_Click(object sender, EventArgs e)
        {
            Api.SetUserCameraPosition(Api.CameraMovement.DOWN);
        }

        private void BtnRight_Click(object sender, EventArgs e)

        {
            Api.SetUserCameraPosition(Api.CameraMovement.RIGHT);
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            Api.SetUserCameraPosition(Api.CameraMovement.LEFT);
        }
    }
}
