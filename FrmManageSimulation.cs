using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesiSoaClient
{
    public partial class FrmManageSimulation : Form
    {

        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(int vKey);
        private static readonly int VK_SNAPSHOT = 0x20;
        private readonly System.Windows.Forms.Timer buttonCheckTimer = new System.Windows.Forms.Timer();

        private bool buttonPress = false;

        public FrmManageSimulation()
        {
            InitializeComponent();

            buttonCheckTimer.Tick += ButtonCheckTimer_Tick;
            buttonCheckTimer.Interval = 25;
            buttonCheckTimer.Start();
        }


        private void ButtonCheckTimer_Tick(object? sender, EventArgs e)
        {
            short keyState = GetAsyncKeyState(VK_SNAPSHOT);

            //Check if the MSB is set. If so, then the key is pressed.
            bool buttonIsPressed = ((keyState >> 15) & 0x0001) == 0x0001;

            //Check if the LSB is set. If so, then the key was pressed since
            //the last call to GetAsyncKeyState
            bool buttonWasPressed = ((keyState >> 0) & 0x0001) == 0x0001;

            if (buttonIsPressed)
            {
                if (!buttonPress)
                {
                    //TODO Execute client code...
                    buttonPress = true;
                    Debug.WriteLine("BUTTON PRESSED");
                    Api.ResponseData resp = Api.ButtonPressed();

                    if (!resp.result)
                    {
                        MessageBox.Show(resp.message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                if (buttonPress)
                {
                    buttonPress = false;
                    Debug.WriteLine("BUTTON RELEASED");

                    Api.ResponseData resp = Api.ButtonReleased();

                    if (!resp.result)
                    {
                        MessageBox.Show(resp.message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    
                }
            }
            /*
            if (buttonWasPressed)
            {
                if (pressing)
                {
                    pressing = false;
                    Debug.WriteLine("BUTTON RELEASED");
                }
            }*/
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Api.ResponseData resp = Api.EnbleSession();

            if (!resp.result)
            {
                MessageBox.Show(resp.message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEndSession_Click(object sender, EventArgs e)
        {

            Api.ResponseData resp = Api.ForceEndSession();

            if (!resp.result)
            {
                MessageBox.Show(resp.message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else this.Close();
        }
    }
}
