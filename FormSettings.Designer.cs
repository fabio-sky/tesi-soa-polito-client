namespace TesiSoaClient
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIpError = new System.Windows.Forms.Label();
            this.btnConfirmIp = new System.Windows.Forms.Button();
            this.txtIp4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIp3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIp2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIp1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumLogSamplig = new System.Windows.Forms.NumericUpDown();
            this.NumPositionSampling = new System.Windows.Forms.NumericUpDown();
            this.BtnSampling = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NumTableHeight = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumLogSamplig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPositionSampling)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumTableHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIpError);
            this.groupBox1.Controls.Add(this.btnConfirmIp);
            this.groupBox1.Controls.Add(this.txtIp4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIp3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIp2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIp1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 144);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP Address";
            // 
            // lblIpError
            // 
            this.lblIpError.AutoSize = true;
            this.lblIpError.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIpError.ForeColor = System.Drawing.Color.IndianRed;
            this.lblIpError.Location = new System.Drawing.Point(203, 63);
            this.lblIpError.Name = "lblIpError";
            this.lblIpError.Size = new System.Drawing.Size(153, 17);
            this.lblIpError.TabIndex = 13;
            this.lblIpError.Text = "Insert a valid IP address";
            this.lblIpError.Visible = false;
            // 
            // btnConfirmIp
            // 
            this.btnConfirmIp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(99)))), ((int)(((byte)(128)))));
            this.btnConfirmIp.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnConfirmIp.FlatAppearance.BorderSize = 0;
            this.btnConfirmIp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmIp.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConfirmIp.Location = new System.Drawing.Point(109, 103);
            this.btnConfirmIp.Name = "btnConfirmIp";
            this.btnConfirmIp.Size = new System.Drawing.Size(146, 29);
            this.btnConfirmIp.TabIndex = 12;
            this.btnConfirmIp.Text = "CONFIRM";
            this.btnConfirmIp.UseVisualStyleBackColor = false;
            this.btnConfirmIp.Click += new System.EventHandler(this.btnConfirmIp_Click);
            // 
            // txtIp4
            // 
            this.txtIp4.Location = new System.Drawing.Point(290, 34);
            this.txtIp4.MaximumSize = new System.Drawing.Size(70, 25);
            this.txtIp4.MaxLength = 3;
            this.txtIp4.MinimumSize = new System.Drawing.Size(70, 25);
            this.txtIp4.Name = "txtIp4";
            this.txtIp4.PlaceholderText = "150";
            this.txtIp4.Size = new System.Drawing.Size(70, 25);
            this.txtIp4.TabIndex = 8;
            this.txtIp4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIp4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIp1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = ".";
            // 
            // txtIp3
            // 
            this.txtIp3.Location = new System.Drawing.Point(197, 34);
            this.txtIp3.MaximumSize = new System.Drawing.Size(70, 25);
            this.txtIp3.MaxLength = 3;
            this.txtIp3.MinimumSize = new System.Drawing.Size(70, 25);
            this.txtIp3.Name = "txtIp3";
            this.txtIp3.PlaceholderText = "8";
            this.txtIp3.Size = new System.Drawing.Size(70, 25);
            this.txtIp3.TabIndex = 6;
            this.txtIp3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIp3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIp1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = ".";
            // 
            // txtIp2
            // 
            this.txtIp2.Location = new System.Drawing.Point(104, 34);
            this.txtIp2.MaximumSize = new System.Drawing.Size(70, 25);
            this.txtIp2.MaxLength = 3;
            this.txtIp2.MinimumSize = new System.Drawing.Size(70, 25);
            this.txtIp2.Name = "txtIp2";
            this.txtIp2.PlaceholderText = "168";
            this.txtIp2.Size = new System.Drawing.Size(70, 25);
            this.txtIp2.TabIndex = 4;
            this.txtIp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIp2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIp1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = ".";
            // 
            // txtIp1
            // 
            this.txtIp1.Location = new System.Drawing.Point(11, 34);
            this.txtIp1.MaximumSize = new System.Drawing.Size(70, 25);
            this.txtIp1.MaxLength = 3;
            this.txtIp1.MinimumSize = new System.Drawing.Size(70, 25);
            this.txtIp1.Name = "txtIp1";
            this.txtIp1.PlaceholderText = "192";
            this.txtIp1.Size = new System.Drawing.Size(70, 25);
            this.txtIp1.TabIndex = 0;
            this.txtIp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIp1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIp1_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.NumLogSamplig);
            this.groupBox2.Controls.Add(this.NumPositionSampling);
            this.groupBox2.Controls.Add(this.BtnSampling);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 262);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sampling";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(327, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "ms";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(153, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "ms";
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(11, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(349, 112);
            this.label6.TabIndex = 17;
            this.label6.Text = "Hand Position Sampling:\r\nSet the sampling rate of hand position when mirror is en" +
    "abled\r\n\r\nHand Log Frequency:\r\nSet the rate at which the hands position is logged" +
    "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Log";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Position";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // NumLogSamplig
            // 
            this.NumLogSamplig.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumLogSamplig.Location = new System.Drawing.Point(197, 176);
            this.NumLogSamplig.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NumLogSamplig.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumLogSamplig.Name = "NumLogSamplig";
            this.NumLogSamplig.Size = new System.Drawing.Size(124, 25);
            this.NumLogSamplig.TabIndex = 14;
            this.NumLogSamplig.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // NumPositionSampling
            // 
            this.NumPositionSampling.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumPositionSampling.Location = new System.Drawing.Point(23, 176);
            this.NumPositionSampling.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NumPositionSampling.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumPositionSampling.Name = "NumPositionSampling";
            this.NumPositionSampling.Size = new System.Drawing.Size(124, 25);
            this.NumPositionSampling.TabIndex = 13;
            this.NumPositionSampling.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // BtnSampling
            // 
            this.BtnSampling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(99)))), ((int)(((byte)(128)))));
            this.BtnSampling.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnSampling.FlatAppearance.BorderSize = 0;
            this.BtnSampling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSampling.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnSampling.Location = new System.Drawing.Point(109, 220);
            this.BtnSampling.Name = "BtnSampling";
            this.BtnSampling.Size = new System.Drawing.Size(146, 29);
            this.BtnSampling.TabIndex = 12;
            this.BtnSampling.Text = "CONFIRM";
            this.BtnSampling.UseVisualStyleBackColor = false;
            this.BtnSampling.Click += new System.EventHandler(this.BtnSampling_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.NumTableHeight);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(12, 430);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 110);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Table";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "cm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Height";
            // 
            // NumTableHeight
            // 
            this.NumTableHeight.Location = new System.Drawing.Point(125, 28);
            this.NumTableHeight.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumTableHeight.Name = "NumTableHeight";
            this.NumTableHeight.Size = new System.Drawing.Size(163, 25);
            this.NumTableHeight.TabIndex = 19;
            this.NumTableHeight.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(99)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(109, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 29);
            this.button1.TabIndex = 18;
            this.button1.Text = "CONFIRM";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 552);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(416, 593);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(416, 593);
            this.Name = "Settings";
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumLogSamplig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPositionSampling)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumTableHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label lblIpError;
        private Button btnConfirmIp;
        private TextBox txtIp4;
        private Label label3;
        private TextBox txtIp3;
        private Label label2;
        private TextBox txtIp2;
        private Label label1;
        private TextBox txtIp1;
        private GroupBox groupBox2;
        private Button BtnSampling;
        private Label label4;
        private NumericUpDown NumLogSamplig;
        private NumericUpDown NumPositionSampling;
        private Label label6;
        private Label label5;
        private GroupBox groupBox3;
        private Button button1;
        private Label label7;
        private NumericUpDown NumTableHeight;
        private Label label10;
        private Label label9;
        private Label label8;
    }
}