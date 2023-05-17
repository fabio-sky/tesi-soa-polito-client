namespace TesiSoaClient
{
    public partial class FormSimulationSetting : Form
    {
        public FormSimulationSetting()
        {
            InitializeComponent();
        }


        private async void HandleUpdateBoolean()
        {
            CheckedListBox.CheckedItemCollection items = chkListBoolParams.CheckedItems;

            Api.UpdateBooleanData data = new() { characterMirror = items.Contains("Character Mirror"), localMirror = items.Contains("Local Mirror"), rotationMirror = items.Contains("Rotation Mirror") };

            Api.ResponseData resp = await Api.SetBooleans(data);

            if (!resp.result)
            {
                MessageBox.Show(resp.message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void HandleUpdateDelay()
        {
            int delay = Convert.ToInt16(txtDelay.Value);

            Api.ResponseData resp = await Api.SetDelay(delay);

            if (!resp.result)
            {
                MessageBox.Show(resp.message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void HandleUpdateCamera()
        {
            if (cmbCamera.SelectedItem != null)
            {
                Api.UpdateCameraViewData data = new() { camera = cmbCamera.SelectedItem.ToString() };
                Api.ResponseData resp = await Api.SetCameraView(data);

                if (!resp.result)
                {
                    MessageBox.Show(resp.message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void GoToSettings()
        {
            var form = new FormOculusIp();
            form.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            GoToSettings();
        }

        private void btnUpdateBooleans_Click(object sender, EventArgs e)
        {
            HandleUpdateBoolean();

        }

        private void btnUpdateDelay_Click(object sender, EventArgs e)
        {
            HandleUpdateDelay();
        }

        private void BtnUpdateCamera_Click(object sender, EventArgs e)
        {
           HandleUpdateCamera();
        }
    }
}