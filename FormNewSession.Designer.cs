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
            this.TxtSessionDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblNameError = new System.Windows.Forms.Label();
            this.TxtSessionName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.FlowLayoutBlock = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnCleanup = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnShuffle = new System.Windows.Forms.Button();
            this.BtnSplit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtSessionDesc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LblNameError);
            this.groupBox1.Controls.Add(this.TxtSessionName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // TxtSessionDesc
            // 
            this.TxtSessionDesc.Location = new System.Drawing.Point(6, 118);
            this.TxtSessionDesc.Multiline = true;
            this.TxtSessionDesc.Name = "TxtSessionDesc";
            this.TxtSessionDesc.Size = new System.Drawing.Size(354, 78);
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
            this.LblNameError.Location = new System.Drawing.Point(257, 78);
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
            this.TxtSessionName.Size = new System.Drawing.Size(354, 25);
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
            // BtnConfirm
            // 
            this.BtnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(99)))), ((int)(((byte)(128)))));
            this.BtnConfirm.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnConfirm.FlatAppearance.BorderSize = 0;
            this.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirm.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnConfirm.Location = new System.Drawing.Point(232, 8);
            this.BtnConfirm.MaximumSize = new System.Drawing.Size(146, 29);
            this.BtnConfirm.MinimumSize = new System.Drawing.Size(146, 29);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(146, 29);
            this.BtnConfirm.TabIndex = 13;
            this.BtnConfirm.Text = "START";
            this.BtnConfirm.UseVisualStyleBackColor = false;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // FlowLayoutBlock
            // 
            this.FlowLayoutBlock.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FlowLayoutBlock.AutoScroll = true;
            this.FlowLayoutBlock.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FlowLayoutBlock.Location = new System.Drawing.Point(5, 298);
            this.FlowLayoutBlock.Name = "FlowLayoutBlock";
            this.FlowLayoutBlock.Size = new System.Drawing.Size(378, 355);
            this.FlowLayoutBlock.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.SeaGreen;
            this.button1.Location = new System.Drawing.Point(344, 258);
            this.button1.MaximumSize = new System.Drawing.Size(34, 34);
            this.button1.MinimumSize = new System.Drawing.Size(34, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 34);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCleanup
            // 
            this.BtnCleanup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnCleanup.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnCleanup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCleanup.BackgroundImage")));
            this.BtnCleanup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCleanup.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnCleanup.FlatAppearance.BorderSize = 0;
            this.BtnCleanup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCleanup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnCleanup.Location = new System.Drawing.Point(304, 258);
            this.BtnCleanup.MaximumSize = new System.Drawing.Size(34, 34);
            this.BtnCleanup.MinimumSize = new System.Drawing.Size(34, 34);
            this.BtnCleanup.Name = "BtnCleanup";
            this.BtnCleanup.Size = new System.Drawing.Size(34, 34);
            this.BtnCleanup.TabIndex = 16;
            this.BtnCleanup.UseVisualStyleBackColor = false;
            this.BtnCleanup.Click += new System.EventHandler(this.BtnCleanup_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(5, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Session Blocks";
            // 
            // BtnShuffle
            // 
            this.BtnShuffle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnShuffle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnShuffle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnShuffle.BackgroundImage")));
            this.BtnShuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnShuffle.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnShuffle.FlatAppearance.BorderSize = 0;
            this.BtnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShuffle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnShuffle.Location = new System.Drawing.Point(264, 258);
            this.BtnShuffle.MaximumSize = new System.Drawing.Size(34, 34);
            this.BtnShuffle.MinimumSize = new System.Drawing.Size(34, 34);
            this.BtnShuffle.Name = "BtnShuffle";
            this.BtnShuffle.Size = new System.Drawing.Size(34, 34);
            this.BtnShuffle.TabIndex = 17;
            this.BtnShuffle.UseVisualStyleBackColor = false;
            this.BtnShuffle.Click += new System.EventHandler(this.BtnShuffle_Click);
            // 
            // BtnSplit
            // 
            this.BtnSplit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnSplit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnSplit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSplit.BackgroundImage")));
            this.BtnSplit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSplit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnSplit.FlatAppearance.BorderSize = 0;
            this.BtnSplit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSplit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnSplit.Location = new System.Drawing.Point(224, 258);
            this.BtnSplit.MaximumSize = new System.Drawing.Size(34, 34);
            this.BtnSplit.MinimumSize = new System.Drawing.Size(34, 34);
            this.BtnSplit.Name = "BtnSplit";
            this.BtnSplit.Size = new System.Drawing.Size(34, 34);
            this.BtnSplit.TabIndex = 18;
            this.BtnSplit.UseVisualStyleBackColor = false;
            this.BtnSplit.Click += new System.EventHandler(this.BtnSplit_Click);
            // 
            // FormNewSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 660);
            this.Controls.Add(this.BtnSplit);
            this.Controls.Add(this.BtnShuffle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnCleanup);
            this.Controls.Add(this.FlowLayoutBlock);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(407, 701);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(407, 701);
            this.Name = "FormNewSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Session";
            this.Activated += new System.EventHandler(this.FormNewSession_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TxtSessionName;
        private Label label1;
        private TextBox TxtSessionDesc;
        private Label label2;
        private Label LblNameError;
        private Button BtnConfirm;
        private FlowLayoutPanel FlowLayoutBlock;
        private Button button1;
        private Button BtnCleanup;
        private Label label3;
        private Button BtnShuffle;
        private Button BtnSplit;
    }
}