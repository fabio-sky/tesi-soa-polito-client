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
    public partial class SessionItem : UserControl
    {
        public SessionItem()
        {
            InitializeComponent();

            _identifier = string.Empty;
            _description = string.Empty;
            _sessionName = string.Empty; 
        }

        private string _identifier;
        public string Identifier
        {
            get { return _identifier; }
            set { _identifier = value; LblID.Text = "ID: " + value; }
        }

        private string _sessionName;
        public string SessionName
        {
            get { return _sessionName; }
            set { _sessionName = value; LblName.Text = value; }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; LblDescription.Text = value; }
        }

        private DateTime _createdAt;
        public DateTime CreatedAt
        {
            get { return _createdAt; }
            set { _createdAt = value; LblDate.Text = value.ToString(); }
        }

        private Action<string> _btnDownloadOnPress;

        public Action<string> BtnDownloadOnPress
        {
            get { return _btnDownloadOnPress; }
            set { _btnDownloadOnPress = value; }
        }

        private Action<string> _btnDeleteOnPress;

        public Action<string> BtnDeleteOnPress
        {
            get { return _btnDeleteOnPress; }
            set { _btnDeleteOnPress = value; }
        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            _btnDownloadOnPress(_identifier);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            _btnDeleteOnPress(_identifier);
        }
    }
}
