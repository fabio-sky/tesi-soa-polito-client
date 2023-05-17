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
            this.lblDate = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.groupBoolean = new System.Windows.Forms.GroupBox();
            this.txtDelay = new System.Windows.Forms.NumericUpDown();
            this.groupDelay = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdateDelay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnUpdateCamera = new System.Windows.Forms.Button();
            this.cmbCamera = new System.Windows.Forms.ComboBox();
            this.groupBoolean.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDelay)).BeginInit();
            this.groupDelay.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateBooleans
            // 
            this.btnUpdateBooleans.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdateBooleans.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnUpdateBooleans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateBooleans.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdateBooleans.Location = new System.Drawing.Point(6, 110);
            this.btnUpdateBooleans.Name = "btnUpdateBooleans";
            this.btnUpdateBooleans.Size = new System.Drawing.Size(300, 41);
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
            this.chkListBoolParams.Location = new System.Drawing.Point(6, 24);
            this.chkListBoolParams.Name = "chkListBoolParams";
            this.chkListBoolParams.Size = new System.Drawing.Size(300, 80);
            this.chkListBoolParams.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDate.Location = new System.Drawing.Point(12, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(120, 17);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Venerdì 12 Maggio";
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.BackgroundImage")));
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.Location = new System.Drawing.Point(285, 5);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(45, 42);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTime.Location = new System.Drawing.Point(12, 26);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(39, 17);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "10:37";
            // 
            // groupBoolean
            // 
            this.groupBoolean.Controls.Add(this.chkListBoolParams);
            this.groupBoolean.Controls.Add(this.btnUpdateBooleans);
            this.groupBoolean.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoolean.Location = new System.Drawing.Point(12, 57);
            this.groupBoolean.Name = "groupBoolean";
            this.groupBoolean.Size = new System.Drawing.Size(313, 156);
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
            this.txtDelay.Location = new System.Drawing.Point(118, 42);
            this.txtDelay.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(188, 25);
            this.txtDelay.TabIndex = 8;
            // 
            // groupDelay
            // 
            this.groupDelay.BackColor = System.Drawing.SystemColors.Control;
            this.groupDelay.Controls.Add(this.label2);
            this.groupDelay.Controls.Add(this.btnUpdateDelay);
            this.groupDelay.Controls.Add(this.txtDelay);
            this.groupDelay.Location = new System.Drawing.Point(12, 360);
            this.groupDelay.Name = "groupDelay";
            this.groupDelay.Size = new System.Drawing.Size(313, 135);
            this.groupDelay.TabIndex = 9;
            this.groupDelay.TabStop = false;
            this.groupDelay.Text = "Delay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Delay in seconds";
            // 
            // btnUpdateDelay
            // 
            this.btnUpdateDelay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdateDelay.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnUpdateDelay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDelay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdateDelay.Location = new System.Drawing.Point(6, 88);
            this.btnUpdateDelay.Name = "btnUpdateDelay";
            this.btnUpdateDelay.Size = new System.Drawing.Size(300, 41);
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
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 52);
            this.panel1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.cmbCamera);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnUpdateCamera);
            this.groupBox1.Location = new System.Drawing.Point(12, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 135);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Camera View";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Camera";
            // 
            // BtnUpdateCamera
            // 
            this.BtnUpdateCamera.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnUpdateCamera.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnUpdateCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateCamera.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnUpdateCamera.Location = new System.Drawing.Point(6, 88);
            this.BtnUpdateCamera.Name = "BtnUpdateCamera";
            this.BtnUpdateCamera.Size = new System.Drawing.Size(300, 41);
            this.BtnUpdateCamera.TabIndex = 2;
            this.BtnUpdateCamera.Text = "UPDATE";
            this.BtnUpdateCamera.UseVisualStyleBackColor = false;
            this.BtnUpdateCamera.Click += new System.EventHandler(this.BtnUpdateCamera_Click);
            // 
            // cmbCamera
            // 
            this.cmbCamera.FormattingEnabled = true;
            this.cmbCamera.Items.AddRange(new object[] {
            "FIRST PERSON",
            "FRONT",
            "FLOOR"});
            this.cmbCamera.Location = new System.Drawing.Point(123, 41);
            this.cmbCamera.Name = "cmbCamera";
            this.cmbCamera.Size = new System.Drawing.Size(183, 25);
            this.cmbCamera.TabIndex = 10;
            // 
            // FormSimulationSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(342, 505);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupDelay);
            this.Controls.Add(this.groupBoolean);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(358, 474);
            this.Name = "FormSimulationSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulation Settings";
            this.groupBoolean.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDelay)).EndInit();
            this.groupDelay.ResumeLayout(false);
            this.groupDelay.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnUpdateBooleans;
        private CheckedListBox chkListBoolParams;
        private Label lblDate;
        private Button btnSettings;
        private Label lblTime;
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
    }
}