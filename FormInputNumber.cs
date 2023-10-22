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
    public partial class FormInputNumber : Form
    {

        public decimal Value = 0;

        public FormInputNumber()
        {
            InitializeComponent();
            BtnConfirm.DialogResult = DialogResult.OK;
            BtnCancel.DialogResult = DialogResult.Cancel;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            Value = TxtInput.Value;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            //this.Close();
        }
    }
}
