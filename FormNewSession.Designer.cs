namespace TesiSoaClient
{
    partial class FormNewSession
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewSession));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.TxtSessionDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblNameError = new System.Windows.Forms.Label();
            this.TxtSessionName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnConfirm);
            this.groupBox1.Controls.Add(this.TxtSessionDesc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LblNameError);
            this.groupBox1.Controls.Add(this.TxtSessionName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(99)))), ((int)(((byte)(128)))));
            this.BtnConfirm.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnConfirm.FlatAppearance.BorderSize = 0;
            this.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirm.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnConfirm.Location = new System.Drawing.Point(32, 211);
            this.BtnConfirm.MaximumSize = new System.Drawing.Size(250, 40);
            this.BtnConfirm.MinimumSize = new System.Drawing.Size(250, 40);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(250, 40);
            this.BtnConfirm.TabIndex = 13;
            this.BtnConfirm.Text = "CONFIRM";
            this.BtnConfirm.UseVisualStyleBackColor = false;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // TxtSessionDesc
            // 
            this.TxtSessionDesc.Location = new System.Drawing.Point(6, 118);
            this.TxtSessionDesc.Multiline = true;
            this.TxtSessionDesc.Name = "TxtSessionDesc";
            this.TxtSessionDesc.Size = new System.Drawing.Size(310, 78);
            this.TxtSessionDesc.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(6, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Session Description";
            // 
            // LblNameError
            // 
            this.LblNameError.AutoSize = true;
            this.LblNameError.ForeColor = System.Drawing.Color.IndianRed;
            this.LblNameError.Location = new System.Drawing.Point(213, 78);
            this.LblNameError.Name = "LblNameError";
            this.LblNameError.Size = new System.Drawing.Size(103, 17);
            this.LblNameError.TabIndex = 2;
            this.LblNameError.Text = "Campo richiesto";
            this.LblNameError.Visible = false;
            // 
            // TxtSessionName
            // 
            this.TxtSessionName.Location = new System.Drawing.Point(6, 50);
            this.TxtSessionName.Name = "TxtSessionName";
            this.TxtSessionName.Size = new System.Drawing.Size(310, 25);
            this.TxtSessionName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Session Name (*)";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 79);
            this.label3.TabIndex = 1;
            this.label3.Text = "Insert the NAME and the DESCRIPTION of the new session.\r\nAn unique identifier wil" +
    "l be automatically created.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormNewSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 362);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNewSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Session";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TxtSessionName;
        private Label label1;
        private TextBox TxtSessionDesc;
        private Label label2;
        private Label LblNameError;
        private Button BtnConfirm;
        private Label label3;
    }
}