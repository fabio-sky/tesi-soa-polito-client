namespace TesiSoaClient
{
    partial class FormSimulationSetting
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSimulationSetting));
            this.btnUpdateBooleans = new System.Windows.Forms.Button();
            this.chkListBoolParams = new System.Windows.Forms.CheckedListBox();
            this.LblSessionId = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.LblSessionName = new System.Windows.Forms.Label();
            this.groupBoolean = new System.Windows.Forms.GroupBox();
            this.txtDelay = new System.Windows.Forms.NumericUpDown();
            this.groupDelay = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdateDelay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnEndSession = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCamera = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnUpdateCamera = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnStopRecord = new System.Windows.Forms.Button();
            this.BtnStartRecord = new System.Windows.Forms.Button();
            this.groupBoolean.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDelay)).BeginInit();
            this.groupDelay.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateBooleans
            // 
            this.btnUpdateBooleans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.btnUpdateBooleans.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnUpdateBooleans.FlatAppearance.BorderSize = 0;
            this.btnUpdateBooleans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateBooleans.ForeColor = System.Drawing.Color.White;
            this.btnUpdateBooleans.Location = new System.Drawing.Point(28, 116);
            this.btnUpdateBooleans.Name = "btnUpdateBooleans";
            this.btnUpdateBooleans.Size = new System.Drawing.Size(146, 29);
            this.btnUpdateBooleans.TabIndex = 0;
            this.btnUpdateBooleans.Text = "UPDATE";
            this.btnUpdateBooleans.UseVisualStyleBackColor = false;
            this.btnUpdateBooleans.Click += new System.EventHandler(this.btnUpdateBooleans_Click);
            // 
            // chkListBoolParams
            // 
            this.chkListBoolParams.BackColor = System.Drawing.SystemColors.Control;
            this.chkListBoolParams.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chkListBoolParams.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkListBoolParams.FormattingEnabled = true;
            this.chkListBoolParams.Items.AddRange(new object[] {
            "Local Mirror",
            "Rotation Mirror",
            "Character Mirror",
            "Third Person View"});
            this.chkListBoolParams.Location = new System.Drawing.Point(16, 24);
            this.chkListBoolParams.Name = "chkListBoolParams";
            this.chkListBoolParams.Size = new System.Drawing.Size(174, 80);
            this.chkListBoolParams.TabIndex = 1;
            // 
            // LblSessionId
            // 
            this.LblSessionId.AutoSize = true;
            this.LblSessionId.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSessionId.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblSessionId.Location = new System.Drawing.Point(12, 9);
            this.LblSessionId.Name = "LblSessionId";
            this.LblSessionId.Size = new System.Drawing.Size(120, 17);
            this.LblSessionId.TabIndex = 2;
            this.LblSessionId.Text = "Venerdì 12 Maggio";
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.BackgroundImage")));
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.Location = new System.Drawing.Point(251, 5);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(45, 42);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // LblSessionName
            // 
            this.LblSessionName.AutoSize = true;
            this.LblSessionName.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSessionName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblSessionName.Location = new System.Drawing.Point(12, 26);
            this.LblSessionName.Name = "LblSessionName";
            this.LblSessionName.Size = new System.Drawing.Size(39, 17);
            this.LblSessionName.TabIndex = 6;
            this.LblSessionName.Text = "10:37";
            // 
            // groupBoolean
            // 
            this.groupBoolean.Controls.Add(this.chkListBoolParams);
            this.groupBoolean.Controls.Add(this.btnUpdateBooleans);
            this.groupBoolean.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoolean.Location = new System.Drawing.Point(12, 57);
            this.groupBoolean.Name = "groupBoolean";
            this.groupBoolean.Size = new System.Drawing.Size(207, 156);
            this.groupBoolean.TabIndex = 7;
            this.groupBoolean.TabStop = false;
            this.groupBoolean.Text = "Movements";
            // 
            // txtDelay
            // 
            this.txtDelay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDelay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDelay.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDelay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDelay.Location = new System.Drawing.Point(26, 59);
            this.txtDelay.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(146, 25);
            this.txtDelay.TabIndex = 8;
            // 
            // groupDelay
            // 
            this.groupDelay.BackColor = System.Drawing.SystemColors.Control;
            this.groupDelay.Controls.Add(this.label2);
            this.groupDelay.Controls.Add(this.btnUpdateDelay);
            this.groupDelay.Controls.Add(this.txtDelay);
            this.groupDelay.Location = new System.Drawing.Point(225, 58);
            this.groupDelay.Name = "groupDelay";
            this.groupDelay.Size = new System.Drawing.Size(196, 155);
            this.groupDelay.TabIndex = 9;
            this.groupDelay.TabStop = false;
            this.groupDelay.Text = "Delay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Delay in seconds";
            // 
            // btnUpdateDelay
            // 
            this.btnUpdateDelay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.btnUpdateDelay.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnUpdateDelay.FlatAppearance.BorderSize = 0;
            this.btnUpdateDelay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDelay.ForeColor = System.Drawing.Color.White;
            this.btnUpdateDelay.Location = new System.Drawing.Point(25, 115);
            this.btnUpdateDelay.Name = "btnUpdateDelay";
            this.btnUpdateDelay.Size = new System.Drawing.Size(146, 29);
            this.btnUpdateDelay.TabIndex = 2;
            this.btnUpdateDelay.Text = "UPDATE";
            this.btnUpdateDelay.UseVisualStyleBackColor = false;
            this.btnUpdateDelay.Click += new System.EventHandler(this.btnUpdateDelay_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.panel1.Controls.Add(this.LblSessionId);
            this.panel1.Controls.Add(this.BtnEndSession);
            this.panel1.Controls.Add(this.LblSessionName);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 52);
            this.panel1.TabIndex = 10;
            // 
            // BtnEndSession
            // 
            this.BtnEndSession.BackColor = System.Drawing.Color.White;
            this.BtnEndSession.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnEndSession.FlatAppearance.BorderSize = 0;
            this.BtnEndSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEndSession.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEndSession.ForeColor = System.Drawing.Color.IndianRed;
            this.BtnEndSession.Location = new System.Drawing.Point(306, 10);
            this.BtnEndSession.Name = "BtnEndSession";
            this.BtnEndSession.Size = new System.Drawing.Size(115, 31);
            this.BtnEndSession.TabIndex = 13;
            this.BtnEndSession.Text = "END SESSION";
            this.BtnEndSession.UseVisualStyleBackColor = false;
            this.BtnEndSession.Click += new System.EventHandler(this.BtnEndSession_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbCamera);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnUpdateCamera);
            this.groupBox1.Location = new System.Drawing.Point(12, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 168);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Camera View";
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 45);
            this.label4.TabIndex = 13;
            this.label4.Text = "Change the perspective of the user";
            // 
            // cmbCamera
            // 
            this.cmbCamera.FormattingEnabled = true;
            this.cmbCamera.Items.AddRange(new object[] {
            "FIRST",
            "THIRD",
            "FRONT"});
            this.cmbCamera.Location = new System.Drawing.Point(16, 92);
            this.cmbCamera.Name = "cmbCamera";
            this.cmbCamera.Size = new System.Drawing.Size(174, 25);
            this.cmbCamera.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Camera";
            // 
            // BtnUpdateCamera
            // 
            this.BtnUpdateCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdateCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.BtnUpdateCamera.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnUpdateCamera.FlatAppearance.BorderSize = 0;
            this.BtnUpdateCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateCamera.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateCamera.Location = new System.Drawing.Point(28, 129);
            this.BtnUpdateCamera.Name = "BtnUpdateCamera";
            this.BtnUpdateCamera.Size = new System.Drawing.Size(146, 29);
            this.BtnUpdateCamera.TabIndex = 2;
            this.BtnUpdateCamera.Text = "UPDATE";
            this.BtnUpdateCamera.UseVisualStyleBackColor = false;
            this.BtnUpdateCamera.Click += new System.EventHandler(this.BtnUpdateCamera_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.BtnStopRecord);
            this.groupBox2.Controls.Add(this.BtnStartRecord);
            this.groupBox2.Location = new System.Drawing.Point(225, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 168);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registrazione ";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 45);
            this.label3.TabIndex = 12;
            this.label3.Text = "Manage logging of positions of the right and left hands";
            // 
            // BtnStopRecord
            // 
            this.BtnStopRecord.BackColor = System.Drawing.Color.LightCoral;
            this.BtnStopRecord.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnStopRecord.FlatAppearance.BorderSize = 0;
            this.BtnStopRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStopRecord.ForeColor = System.Drawing.Color.White;
            this.BtnStopRecord.Location = new System.Drawing.Point(26, 129);
            this.BtnStopRecord.Name = "BtnStopRecord";
            this.BtnStopRecord.Size = new System.Drawing.Size(146, 29);
            this.BtnStopRecord.TabIndex = 11;
            this.BtnStopRecord.Text = "STOP RECORDING";
            this.BtnStopRecord.UseVisualStyleBackColor = false;
            this.BtnStopRecord.Click += new System.EventHandler(this.BtnStopRecord_Click);
            // 
            // BtnStartRecord
            // 
            this.BtnStartRecord.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnStartRecord.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnStartRecord.FlatAppearance.BorderSize = 0;
            this.BtnStartRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStartRecord.ForeColor = System.Drawing.Color.White;
            this.BtnStartRecord.Location = new System.Drawing.Point(26, 89);
            this.BtnStartRecord.Name = "BtnStartRecord";
            this.BtnStartRecord.Size = new System.Drawing.Size(146, 29);
            this.BtnStartRecord.TabIndex = 10;
            this.BtnStartRecord.Text = "START RECORDING";
            this.BtnStartRecord.UseVisualStyleBackColor = false;
            this.BtnStartRecord.Click += new System.EventHandler(this.BtnStartRecord_Click);
            // 
            // FormSimulationSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(431, 395);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupDelay);
            this.Controls.Add(this.groupBoolean);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(447, 436);
            this.MinimumSize = new System.Drawing.Size(447, 436);
            this.Name = "FormSimulationSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulation Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSimulationSetting_FormClosing);
            this.groupBoolean.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDelay)).EndInit();
            this.groupDelay.ResumeLayout(false);
            this.groupDelay.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnUpdateBooleans;
        private CheckedListBox chkListBoolParams;
        private Label LblSessionId;
        private Button btnSettings;
        private Label LblSessionName;
        private GroupBox groupBoolean;
        private NumericUpDown txtDelay;
        private GroupBox groupDelay;
        private Button btnUpdateDelay;
        private Label label2;
        private Panel panel1;
        private GroupBox groupBox1;
        private ComboBox cmbCamera;
        private Label label1;
        private Button BtnUpdateCamera;
        private Button BtnEndSession;
        private GroupBox groupBox2;
        private Label label3;
        private Button BtnStopRecord;
        private Button BtnStartRecord;
        private Label label4;
    }
}