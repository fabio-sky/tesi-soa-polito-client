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

            Api.UpdateBooleanData data = new() { characterMirror = items.Contains("Character Mirror"), localMirror = items.Contains("Local Mirror"), rotationMirror = items.Contains("Rotation Mirror"), thirdPerson = items.Contains("Third Person View") };

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

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var form = new FormGlobalSettings();
            form.ShowDialog();
        }

        private void btnUpdateBooleans_Click(object sender, EventArgs e)
        {
            HandleUpdateBoolean();

        }

        private void btnUpdateDelay_Click(object sender, EventArgs e)
        {
            HandleUpdateDelay();
        }
    }
}