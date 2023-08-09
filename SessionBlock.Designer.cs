namespace TesiSoaClient
{
    partial class SessionBlock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SessionBlock));
            this.BtnDelete = new System.Windows.Forms.Button();
            this.LblTry = new System.Windows.Forms.Label();
            this.LblRestTime = new System.Windows.Forms.Label();
            this.LblDelay = new System.Windows.Forms.Label();
            this.LblSpawn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblBlockIndex = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnUp = new System.Windows.Forms.Button();
            this.BtnDown = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDelete.BackgroundImage")));
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(317, 3);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(34, 34);
            this.BtnDelete.TabIndex = 16;
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LblTry
            // 
            this.LblTry.AutoSize = true;
            this.LblTry.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTry.Location = new System.Drawing.Point(3, 7);
            this.LblTry.Name = "LblTry";
            this.LblTry.Size = new System.Drawing.Size(96, 17);
            this.LblTry.TabIndex = 19;
            this.LblTry.Text = "Numero try: 10";
            this.LblTry.Click += new System.EventHandler(this.LblTry_Click);
            // 
            // LblRestTime
            // 
            this.LblRestTime.AutoSize = true;
            this.LblRestTime.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblRestTime.Location = new System.Drawing.Point(3, 30);
            this.LblRestTime.Name = "LblRestTime";
            this.LblRestTime.Size = new System.Drawing.Size(101, 17);
            this.LblRestTime.TabIndex = 20;
            this.LblRestTime.Text = "Rest time [s]: 10";
            // 
            // LblDelay
            // 
            this.LblDelay.AutoSize = true;
            this.LblDelay.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDelay.Location = new System.Drawing.Point(3, 53);
            this.LblDelay.Name = "LblDelay";
            this.LblDelay.Size = new System.Drawing.Size(97, 17);
            this.LblDelay.TabIndex = 21;
            this.LblDelay.Text = "Delay [ms]: 300";
            // 
            // LblSpawn
            // 
            this.LblSpawn.AutoSize = true;
            this.LblSpawn.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSpawn.Location = new System.Drawing.Point(3, 76);
            this.LblSpawn.Name = "LblSpawn";
            this.LblSpawn.Size = new System.Drawing.Size(126, 17);
            this.LblSpawn.TabIndex = 22;
            this.LblSpawn.Text = "Target spawn: FIXED";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(99)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.LblBlockIndex);
            this.panel1.Location = new System.Drawing.Point(249, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 25);
            this.panel1.TabIndex = 23;
            // 
            // LblBlockIndex
            // 
            this.LblBlockIndex.AutoSize = true;
            this.LblBlockIndex.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblBlockIndex.Location = new System.Drawing.Point(23, 4);
            this.LblBlockIndex.Name = "LblBlockIndex";
            this.LblBlockIndex.Size = new System.Drawing.Size(65, 17);
            this.LblBlockIndex.TabIndex = 0;
            this.LblBlockIndex.Text = "Blocco #1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.BtnUp);
            this.panel2.Controls.Add(this.BtnDown);
            this.panel2.Controls.Add(this.LblTry);
            this.panel2.Controls.Add(this.BtnDelete);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.LblRestTime);
            this.panel2.Controls.Add(this.LblSpawn);
            this.panel2.Controls.Add(this.LblDelay);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 107);
            this.panel2.TabIndex = 24;
            // 
            // BtnUp
            // 
            this.BtnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnUp.BackgroundImage")));
            this.BtnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnUp.FlatAppearance.BorderSize = 0;
            this.BtnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUp.ForeColor = System.Drawing.Color.White;
            this.BtnUp.Location = new System.Drawing.Point(237, 3);
            this.BtnUp.Name = "BtnUp";
            this.BtnUp.Size = new System.Drawing.Size(34, 34);
            this.BtnUp.TabIndex = 25;
            this.BtnUp.UseVisualStyleBackColor = false;
            this.BtnUp.Click += new System.EventHandler(this.BtnUp_Click);
            // 
            // BtnDown
            // 
            this.BtnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDown.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDown.BackgroundImage")));
            this.BtnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnDown.FlatAppearance.BorderSize = 0;
            this.BtnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDown.ForeColor = System.Drawing.Color.White;
            this.BtnDown.Location = new System.Drawing.Point(277, 3);
            this.BtnDown.Name = "BtnDown";
            this.BtnDown.Size = new System.Drawing.Size(34, 34);
            this.BtnDown.TabIndex = 24;
            this.BtnDown.UseVisualStyleBackColor = false;
            this.BtnDown.Click += new System.EventHandler(this.BtnDown_Click);
            // 
            // SessionBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "SessionBlock";
            this.Size = new System.Drawing.Size(354, 107);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnDelete;
        private Label LblTry;
        private Label LblRestTime;
        private Label LblDelay;
        private Label LblSpawn;
        private Panel panel1;
        private Label LblBlockIndex;
        private Panel panel2;
        private Button BtnUp;
        private Button BtnDown;
    }
}
