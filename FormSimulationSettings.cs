namespace TesiSoaClient
{
    public partial class FormSimulationSetting : Form
    {
        public FormSimulationSetting()
        {
            InitializeComponent();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var form = new FormGlobalSettings();
            form.ShowDialog();
        }

        private void btnUpdateBooleans_Click(object sender, EventArgs e)
        {
            MessageBox.Show(chkListBoolParams.CheckedItems.Count.ToString());
        }

        private void btnUpdateDelay_Click(object sender, EventArgs e)
        {

            int delay = Convert.ToInt16(txtDelay.Value);

            Api.SetDelay(delay);
        }
    }
}