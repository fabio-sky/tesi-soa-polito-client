using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static TesiSoaClient.Api;

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

        private void BtnShuffle_Click(object sender, EventArgs e)
        {
            Random generator = new();
            int extractedNumber;
            int blocksNumber = SessionsDataBlock.Count;
            List<Api.BlockData> shuffleList = new();
            int[] extractedIndexes = new int[SessionsDataBlock.Count];

            try
            {
                while (shuffleList.Count < SessionsDataBlock.Count)
                {

                    do
                    {
                        extractedNumber = generator.Next(0, blocksNumber);
                    } while (extractedIndexes[extractedNumber] == 1);

                    extractedIndexes[extractedNumber] = 1;

                    shuffleList.Add(SessionsDataBlock[extractedNumber]);

                }

                SessionsDataBlock.Clear();
                SessionsDataBlock.AddRange(shuffleList);
                LoadDatBlockInList();
            }
            catch (Exception)
            {
                MessageBox.Show("Error during shuffle");
            }

            

        }

        private void BtnSplit_Click(object sender, EventArgs e)
        {
            int dividePer = -1;
            List<Api.BlockData> dividedSessions = new();
            FormInputNumber frmInput = new();

            if(frmInput.ShowDialog(this) == DialogResult.OK)
            {
                decimal res = frmInput.Value;
                MessageBox.Show(res.ToString());
                dividePer = Convert.ToInt32(res);
            }

            frmInput.Dispose();

            
            if(dividePer > 0)
            {
                foreach (Api.BlockData block in SessionsDataBlock)
                {
                    int blockTries = block.numberOfTry;
                    while (blockTries > dividePer)
                    {
                        Api.BlockData blockData = new Api.BlockData() { numberOfTry = dividePer, delay = block.delay, id = block.id, restTime = block.restTime, target = block.target };
                        dividedSessions.Add(blockData);
                        blockTries -= dividePer;

                    }

                    Api.BlockData lastBLockData = new Api.BlockData() { numberOfTry = blockTries, delay = block.delay, id = block.id, restTime = block.restTime, target = block.target };
                    dividedSessions.Add(lastBLockData);
                }

                SessionsDataBlock.Clear();
                SessionsDataBlock.AddRange(dividedSessions);
                LoadDatBlockInList();
            }
           
        }
    }
}
