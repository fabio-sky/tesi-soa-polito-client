using Newtonsoft.Json;
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
    public partial class FormNewSession : Form
    {
        public FormNewSession()
        {
            InitializeComponent();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            SessionInfo session = new SessionInfo();
            session.Name = "Fabio";
            session.Description = "Sessione di Test";

            

            AppData.Instance.ActualSession = session;

            MessageBox.Show(JsonConvert.SerializeObject(AppData.Instance.ActualSession));
        }
    }
}
