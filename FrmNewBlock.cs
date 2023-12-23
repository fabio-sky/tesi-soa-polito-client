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
    public partial class FrmNewBlock : Form
    {
        public FrmNewBlock()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddBlock_Click(object sender, EventArgs e)
        {

            

            if (string.IsNullOrEmpty(CmbSpawnMethod.Text))
            {
                MessageBox.Show("Target Spawn Method is empty");
            }
            else
            {
                Api.BlockData data = new() { id = DateTime.Now.ToString("yyyyMMdd_HHmmss") + "_block", target = CmbSpawnMethod.Text, delay = Convert.ToInt32(NumDelay.Value), numberOfTry = Convert.ToInt32(NumTry.Value), restTime = Convert.ToInt32(NumRestTime.Value), characterMirror = chkCharacterMirror.Checked, localMirror = chkLocalMirror.Checked, thirdPersonView = chkTPV.Checked };

                FormNewSession.SessionsDataBlock.Add(data);
                this.Close();
            }

            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
