﻿namespace TesiSoaClient
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblDate = new System.Windows.Forms.Label();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnNewSession = new System.Windows.Forms.Button();
            this.BtnSync = new System.Windows.Forms.Button();
            this.FlowLayoutSession = new System.Windows.Forms.FlowLayoutPanel();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.LblDownload = new System.Windows.Forms.Label();
            this.BtnSetupRoom = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.panel1.Controls.Add(this.LblDate);
            this.panel1.Controls.Add(this.BtnSettings);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 55);
            this.panel1.TabIndex = 11;
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblDate.Location = new System.Drawing.Point(12, 16);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(120, 17);
            this.LblDate.TabIndex = 2;
            this.LblDate.Text = "Venerdì 12 Maggio";
            // 
            // BtnSettings
            // 
            this.BtnSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSettings.BackgroundImage")));
            this.BtnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSettings.FlatAppearance.BorderSize = 0;
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSettings.Location = new System.Drawing.Point(684, 7);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(45, 42);
            this.BtnSettings.TabIndex = 3;
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // BtnNewSession
            // 
            this.BtnNewSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.BtnNewSession.FlatAppearance.BorderSize = 0;
            this.BtnNewSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewSession.ForeColor = System.Drawing.Color.White;
            this.BtnNewSession.Location = new System.Drawing.Point(53, 70);
            this.BtnNewSession.Name = "BtnNewSession";
            this.BtnNewSession.Size = new System.Drawing.Size(146, 34);
            this.BtnNewSession.TabIndex = 12;
            this.BtnNewSession.Text = "NEW SESSION";
            this.BtnNewSession.UseVisualStyleBackColor = false;
            this.BtnNewSession.Click += new System.EventHandler(this.BtnNewSession_Click);
            // 
            // BtnSync
            // 
            this.BtnSync.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnSync.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSync.BackgroundImage")));
            this.BtnSync.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSync.FlatAppearance.BorderSize = 0;
            this.BtnSync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSync.ForeColor = System.Drawing.Color.White;
            this.BtnSync.Location = new System.Drawing.Point(13, 70);
            this.BtnSync.Name = "BtnSync";
            this.BtnSync.Size = new System.Drawing.Size(34, 34);
            this.BtnSync.TabIndex = 13;
            this.BtnSync.UseVisualStyleBackColor = false;
            this.BtnSync.Click += new System.EventHandler(this.BtnSync_Click);
            // 
            // FlowLayoutSession
            // 
            this.FlowLayoutSession.AutoScroll = true;
            this.FlowLayoutSession.Location = new System.Drawing.Point(12, 110);
            this.FlowLayoutSession.Name = "FlowLayoutSession";
            this.FlowLayoutSession.Size = new System.Drawing.Size(731, 572);
            this.FlowLayoutSession.TabIndex = 14;
            // 
            // LblDownload
            // 
            this.LblDownload.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblDownload.AutoSize = true;
            this.LblDownload.Font = new System.Drawing.Font("Segoe UI", 8.830189F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LblDownload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.LblDownload.Location = new System.Drawing.Point(519, 79);
            this.LblDownload.Name = "LblDownload";
            this.LblDownload.Size = new System.Drawing.Size(224, 17);
            this.LblDownload.TabIndex = 15;
            this.LblDownload.Text = "Downloading session_!23123_DATA";
            this.LblDownload.Visible = false;
            // 
            // BtnSetupRoom
            // 
            this.BtnSetupRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.BtnSetupRoom.FlatAppearance.BorderSize = 0;
            this.BtnSetupRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSetupRoom.ForeColor = System.Drawing.Color.White;
            this.BtnSetupRoom.Location = new System.Drawing.Point(205, 70);
            this.BtnSetupRoom.Name = "BtnSetupRoom";
            this.BtnSetupRoom.Size = new System.Drawing.Size(146, 34);
            this.BtnSetupRoom.TabIndex = 16;
            this.BtnSetupRoom.Text = "SETUP ROOM";
            this.BtnSetupRoom.UseVisualStyleBackColor = false;
            this.BtnSetupRoom.Click += new System.EventHandler(this.BtnSetupRoom_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 694);
            this.Controls.Add(this.BtnSetupRoom);
            this.Controls.Add(this.LblDownload);
            this.Controls.Add(this.FlowLayoutSession);
            this.Controls.Add(this.BtnSync);
            this.Controls.Add(this.BtnNewSession);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tesi - Sense Of Agency - PoliTO";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label LblDate;
        private Button BtnSettings;
        private Button BtnNewSession;
        private Button BtnSync;
        private FlowLayoutPanel FlowLayoutSession;
        private FolderBrowserDialog folderBrowser;
        private Label LblDownload;
        private Button BtnSetupRoom;
    }
}