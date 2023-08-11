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
using static System.Collections.Specialized.BitVector32;

namespace TesiSoaClient
{
    public partial class FormNewSession : Form
    {

        internal static List<Api.BlockData> SessionsDataBlock = new();

        public FormNewSession()
        {
            InitializeComponent();

           

            //LoadDatBlockInList();
        }

        private void HandleCreateNewSession()
        {
            SessionInfo session = new()
            {
                Name = TxtSessionName.Text.Trim(),
                Description = TxtSessionDesc.Text.Trim(),
                Blocks = SessionsDataBlock
            };

            AppData.Instance.ActualSession = session;
            Api.ResponseData resp = Api.SetSession(session);

            if (resp.result)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show(resp.message);
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {

            if(TxtSessionName.Text.Trim().Length == 0)
            {
                LblNameError.Visible = true;
                return;
            }

            HandleCreateNewSession();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmNewBlock formBLock = new();
            formBLock.ShowDialog();
        }

        private void LoadDatBlockInList()
        {
            FlowLayoutBlock.Controls.Clear();

            //MessageBox.Show("LoadDatBlockInList");

            int count = 1;

            foreach (Api.BlockData block in SessionsDataBlock)
            {
                SessionBlock item = new()
                {
                    Delay = block.delay,
                    RestTime = block.restTime,
                    Try = block.numberOfTry,
                    TargetSpawn = block.target,
                    BlockIndex = count,
                    BlockId = block.id,
                    BtnDeleteOnPress = HandleDeleteBlock,
                    BtnMoveDownOnPress = HandleMoveDownBlock,
                    BtnMoveupOnPress = HandleMoveUpBlock

                };
                FlowLayoutBlock.Controls.Add(item);
                count++;
            }
        }

        private void HandleDeleteBlock(int index)
        {
            SessionsDataBlock.RemoveAt(index - 1);
            LoadDatBlockInList();
        }

        private void HandleMoveUpBlock(int index)
        {
            Api.BlockData temp;
            int realIndex = index - 1;

            if(realIndex > 0)
            {
                temp = SessionsDataBlock[realIndex - 1];
                SessionsDataBlock[realIndex - 1] = SessionsDataBlock[realIndex];
                SessionsDataBlock[realIndex] = temp;

                LoadDatBlockInList();
            }
            

            
        }

        private void HandleMoveDownBlock(int index)
        {
            Api.BlockData temp;
            int realIndex = index - 1;

            if (realIndex < SessionsDataBlock.Count - 1)
            {
                temp = SessionsDataBlock[realIndex + 1];
                SessionsDataBlock[realIndex + 1] = SessionsDataBlock[realIndex];
                SessionsDataBlock[realIndex] = temp;

                LoadDatBlockInList();
            }
        }

        private void FormNewSession_Activated(object sender, EventArgs e)
        {
            LoadDatBlockInList();
        }

        private void BtnCleanup_Click(object sender, EventArgs e)
        {
            SessionsDataBlock.Clear();
            LoadDatBlockInList();
        }
    }
}
