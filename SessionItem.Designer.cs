namespace TesiSoaClient
{
    partial class SessionItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SessionItem));
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnDownload = new System.Windows.Forms.Button();
            this.LblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblID = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblDescription = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDelete.BackgroundImage")));
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(652, 33);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(34, 34);
            this.BtnDelete.TabIndex = 14;
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnDownload
            // 
            this.BtnDownload.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnDownload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDownload.BackgroundImage")));
            this.BtnDownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnDownload.FlatAppearance.BorderSize = 0;
            this.BtnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDownload.ForeColor = System.Drawing.Color.White;
            this.BtnDownload.Location = new System.Drawing.Point(602, 33);
            this.BtnDownload.Name = "BtnDownload";
            this.BtnDownload.Size = new System.Drawing.Size(34, 34);
            this.BtnDownload.TabIndex = 15;
            this.BtnDownload.UseVisualStyleBackColor = false;
            this.BtnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // LblName
            // 
            this.LblName.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblName.Location = new System.Drawing.Point(9, 9);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(587, 24);
            this.LblName.TabIndex = 16;
            this.LblName.Text = "Session di prova";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.panel1.Controls.Add(this.LblID);
            this.panel1.Controls.Add(this.LblDate);
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 30);
            this.panel1.TabIndex = 17;
            // 
            // LblID
            // 
            this.LblID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblID.ForeColor = System.Drawing.Color.White;
            this.LblID.Location = new System.Drawing.Point(426, 7);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(271, 17);
            this.LblID.TabIndex = 1;
            this.LblID.Text = "ID: 20230518 asd ";
            this.LblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.ForeColor = System.Drawing.Color.White;
            this.LblDate.Location = new System.Drawing.Point(9, 7);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(184, 17);
            this.LblDate.TabIndex = 0;
            this.LblDate.Text = "Lunedì, 12 Maggio 2023 12:34";
            // 
            // LblDescription
            // 
            this.LblDescription.Location = new System.Drawing.Point(9, 42);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(587, 55);
            this.LblDescription.TabIndex = 18;
            this.LblDescription.Text = "label2";
            // 
            // SessionItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.BtnDownload);
            this.Controls.Add(this.BtnDelete);
            this.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.Name = "SessionItem";
            this.Size = new System.Drawing.Size(700, 130);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnDelete;
        private Button BtnDownload;
        private Label LblName;
        private Panel panel1;
        private Label LblDate;
        private Label LblID;
        private Label LblDescription;
    }
}
