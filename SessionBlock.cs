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
    public partial class SessionBlock : UserControl
    {
        public SessionBlock()
        {
            InitializeComponent();
        }

        private void LblTry_Click(object sender, EventArgs e)
        {

        }

        private string _blockId;
        public string BlockId
        {
            get { return _blockId; }
            set { _blockId = value; }
        }

        private int _blockIndex;
        public int BlockIndex
        {
            get { return _blockIndex; }
            set { _blockIndex = value; LblBlockIndex.Text = "Blocco #" + value; }
        }

        private int _try;
        public int Try
        {
            get { return _try; }
            set { _try = value; LblTry.Text = "Numero TRY: " + value; }
        }

        private int _restTIme;
        public int RestTime
        {
            get { return _restTIme; }
            set { _restTIme = value; LblRestTime.Text = "Rest time [s]: " + value; }
        }

        private int _delay;
        public int Delay
        {
            get { return _delay; }
            set { _delay = value; LblDelay.Text = "Delay [ms]: " + value; }
        }

        private string _targetSpawn;
        public string TargetSpawn
        {
            get { return _targetSpawn; }
            set { _targetSpawn = value; LblSpawn.Text = "Target spawn: " + value; }
        }

        private bool _charaterMirror;
        public bool CharacterMirror
        {
            get { return _charaterMirror; }
            set { _charaterMirror = value; LblCharacterMirror.Text = value ? "CHARACTER" : ""; }
        }

        private bool _localMirror;
        public bool LocalMirror
        {
            get { return _localMirror; }
            set { _localMirror = value; LblLocalMirror.Text = value ? "LOCAL" : ""; }
        }

        private bool _thirdPersonView;
        public bool ThirdPersonView
        {
            get { return _thirdPersonView; }
            set { _thirdPersonView = value; LblTpv.Text = value ? "TPV" : ""; }
        }

        private Action<int> _btnDeleteOnPress;

        public Action<int> BtnDeleteOnPress
        {
            get { return _btnDeleteOnPress; }
            set { _btnDeleteOnPress = value; }
        }

        private Action<int> _btnMoveUpOnPress;

        public Action<int> BtnMoveupOnPress
        {
            get { return _btnMoveUpOnPress; }
            set { _btnMoveUpOnPress = value; }
        }

        private Action<int> _btnMoveDownOnPress;

        public Action<int> BtnMoveDownOnPress
        {
            get { return _btnMoveDownOnPress; }
            set { _btnMoveDownOnPress = value; }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            _btnDeleteOnPress(_blockIndex);
        }


        private void BtnUp_Click(object sender, EventArgs e)
        {
            _btnMoveUpOnPress(_blockIndex);
        }

        private void BtnDown_Click(object sender, EventArgs e)
        {
            _btnMoveDownOnPress(_blockIndex);
        }
    }
}
