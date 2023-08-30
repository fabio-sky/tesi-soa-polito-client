namespace TesiSoaClient
{
    partial class FrmManageSimulation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageSimulation));
            this.BtnEndSession = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnEndSession
            // 
            this.BtnEndSession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEndSession.BackColor = System.Drawing.Color.IndianRed;
            this.BtnEndSession.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnEndSession.FlatAppearance.BorderSize = 0;
            this.BtnEndSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEndSession.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEndSession.ForeColor = System.Drawing.Color.White;
            this.BtnEndSession.Location = new System.Drawing.Point(186, 12);
            this.BtnEndSession.MaximumSize = new System.Drawing.Size(155, 48);
            this.BtnEndSession.MinimumSize = new System.Drawing.Size(155, 48);
            this.BtnEndSession.Name = "BtnEndSession";
            this.BtnEndSession.Size = new System.Drawing.Size(155, 48);
            this.BtnEndSession.TabIndex = 29;
            this.BtnEndSession.Text = "END SESSION";
            this.BtnEndSession.UseVisualStyleBackColor = false;
            this.BtnEndSession.Click += new System.EventHandler(this.BtnEndSession_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.OliveDrab;
            this.BtnStart.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnStart.FlatAppearance.BorderSize = 0;
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStart.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnStart.ForeColor = System.Drawing.Color.White;
            this.BtnStart.Location = new System.Drawing.Point(12, 12);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(155, 48);
            this.BtnStart.TabIndex = 30;
            this.BtnStart.Text = "ENABLE SESSION";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // FrmManageSimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 75);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.BtnEndSession);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmManageSimulation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Simulation";
            this.ResumeLayout(false);

        }

        #endregion
        private Button BtnEndSession;
        private Button BtnStart;
    }
}