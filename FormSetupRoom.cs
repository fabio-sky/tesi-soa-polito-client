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
    public partial class FormSetupRoom : Form
    {
        public FormSetupRoom()
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

        private void BtnTableForward_Click(object sender, EventArgs e)
        {
            Api.SetTablePosition(Api.TableMovement.FORWARD);
        }

        private void BtnTableBackward_Click(object sender, EventArgs e)
        {
            Api.SetTablePosition(Api.TableMovement.BACKWARD);
        }

        private void BtnButtonUp_Click(object sender, EventArgs e)
        {
            Api.UpdateButtonPosition(Api.CameraMovement.UP);
        }

        private void BtnButtonDown_Click(object sender, EventArgs e)
        {
            Api.UpdateButtonPosition(Api.CameraMovement.DOWN);
        }

        private void BtnButtonRight_Click(object sender, EventArgs e)
        {
            Api.UpdateButtonPosition(Api.CameraMovement.RIGHT);
        }

        private void BtnButtonLeft_Click(object sender, EventArgs e)
        {
            Api.UpdateButtonPosition(Api.CameraMovement.LEFT);
        }
    }
}
