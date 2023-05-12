namespace TesiSoaClient
{
    partial class FormGlobalSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGlobalSettings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIpError = new System.Windows.Forms.Label();
            this.btnConfirmIp = new System.Windows.Forms.Button();
            this.btnTestIp = new System.Windows.Forms.Button();
            this.txtIp4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIp3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIp2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIp1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIpError);
            this.groupBox1.Controls.Add(this.btnConfirmIp);
            this.groupBox1.Controls.Add(this.btnTestIp);
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
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP Oculus";
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
            this.btnConfirmIp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConfirmIp.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnConfirmIp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmIp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConfirmIp.Location = new System.Drawing.Point(104, 97);
            this.btnConfirmIp.Name = "btnConfirmIp";
            this.btnConfirmIp.Size = new System.Drawing.Size(256, 41);
            this.btnConfirmIp.TabIndex = 12;
            this.btnConfirmIp.Text = "CONFIRM";
            this.btnConfirmIp.UseVisualStyleBackColor = false;
            this.btnConfirmIp.Click += new System.EventHandler(this.btnConfirmIp_Click);
            // 
            // btnTestIp
            // 
            this.btnTestIp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(217)))), ((int)(((byte)(209)))));
            this.btnTestIp.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnTestIp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestIp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTestIp.Location = new System.Drawing.Point(11, 97);
            this.btnTestIp.Name = "btnTestIp";
            this.btnTestIp.Size = new System.Drawing.Size(87, 41);
            this.btnTestIp.TabIndex = 11;
            this.btnTestIp.Text = "TEST";
            this.btnTestIp.UseVisualStyleBackColor = false;
            this.btnTestIp.Click += new System.EventHandler(this.btnTestIp_Click);
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
            // FormGlobalSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 168);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGlobalSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GlobalSettings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtIp4;
        private Label label3;
        private TextBox txtIp3;
        private Label label2;
        private TextBox txtIp2;
        private Label label1;
        private TextBox txtIp1;
        private Button btnConfirmIp;
        private Button btnTestIp;
        private Label lblIpError;
    }
}