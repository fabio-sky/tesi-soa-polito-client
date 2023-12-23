namespace TesiSoaClient
{
    partial class FrmNewBlock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewBlock));
            this.label1 = new System.Windows.Forms.Label();
            this.NumTry = new System.Windows.Forms.NumericUpDown();
            this.NumRestTime = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.NumDelay = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbSpawnMethod = new System.Windows.Forms.ComboBox();
            this.BtnAddBlock = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkLocalMirror = new System.Windows.Forms.CheckBox();
            this.chkTPV = new System.Windows.Forms.CheckBox();
            this.chkCharacterMirror = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumTry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRestTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of tries";
            // 
            // NumTry
            // 
            this.NumTry.Location = new System.Drawing.Point(12, 29);
            this.NumTry.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumTry.Name = "NumTry";
            this.NumTry.Size = new System.Drawing.Size(200, 25);
            this.NumTry.TabIndex = 3;
            this.NumTry.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumRestTime
            // 
            this.NumRestTime.Location = new System.Drawing.Point(12, 87);
            this.NumRestTime.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.NumRestTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumRestTime.Name = "NumRestTime";
            this.NumRestTime.Size = new System.Drawing.Size(138, 25);
            this.NumRestTime.TabIndex = 5;
            this.NumRestTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rest Time [s]";
            // 
            // NumDelay
            // 
            this.NumDelay.Location = new System.Drawing.Point(12, 140);
            this.NumDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumDelay.Name = "NumDelay";
            this.NumDelay.Size = new System.Drawing.Size(115, 25);
            this.NumDelay.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Delay [ms]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(12, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Target spawn method";
            // 
            // CmbSpawnMethod
            // 
            this.CmbSpawnMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSpawnMethod.FormattingEnabled = true;
            this.CmbSpawnMethod.Items.AddRange(new object[] {
            "FIXED",
            "RANDOM"});
            this.CmbSpawnMethod.Location = new System.Drawing.Point(12, 197);
            this.CmbSpawnMethod.Name = "CmbSpawnMethod";
            this.CmbSpawnMethod.Size = new System.Drawing.Size(200, 25);
            this.CmbSpawnMethod.TabIndex = 9;
            // 
            // BtnAddBlock
            // 
            this.BtnAddBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(99)))), ((int)(((byte)(128)))));
            this.BtnAddBlock.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnAddBlock.FlatAppearance.BorderSize = 0;
            this.BtnAddBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddBlock.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnAddBlock.Location = new System.Drawing.Point(35, 334);
            this.BtnAddBlock.MaximumSize = new System.Drawing.Size(146, 29);
            this.BtnAddBlock.MinimumSize = new System.Drawing.Size(146, 29);
            this.BtnAddBlock.Name = "BtnAddBlock";
            this.BtnAddBlock.Size = new System.Drawing.Size(146, 29);
            this.BtnAddBlock.TabIndex = 14;
            this.BtnAddBlock.Text = "ADD";
            this.BtnAddBlock.UseVisualStyleBackColor = false;
            this.BtnAddBlock.Click += new System.EventHandler(this.BtnAddBlock_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(156, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "seconds";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(133, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "milliseconds";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // chkLocalMirror
            // 
            this.chkLocalMirror.AutoSize = true;
            this.chkLocalMirror.Location = new System.Drawing.Point(12, 242);
            this.chkLocalMirror.Name = "chkLocalMirror";
            this.chkLocalMirror.Size = new System.Drawing.Size(118, 21);
            this.chkLocalMirror.TabIndex = 17;
            this.chkLocalMirror.Text = "LOCAL MIRROR";
            this.chkLocalMirror.UseVisualStyleBackColor = true;
            this.chkLocalMirror.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkTPV
            // 
            this.chkTPV.AutoSize = true;
            this.chkTPV.Location = new System.Drawing.Point(12, 292);
            this.chkTPV.Name = "chkTPV";
            this.chkTPV.Size = new System.Drawing.Size(150, 21);
            this.chkTPV.TabIndex = 18;
            this.chkTPV.Text = "THIRD PERSON VIEW";
            this.chkTPV.UseVisualStyleBackColor = true;
            // 
            // chkCharacterMirror
            // 
            this.chkCharacterMirror.AutoSize = true;
            this.chkCharacterMirror.Location = new System.Drawing.Point(12, 267);
            this.chkCharacterMirror.Name = "chkCharacterMirror";
            this.chkCharacterMirror.Size = new System.Drawing.Size(151, 21);
            this.chkCharacterMirror.TabIndex = 19;
            this.chkCharacterMirror.Text = "CHARACTER MIRROR";
            this.chkCharacterMirror.UseVisualStyleBackColor = true;
            // 
            // FrmNewBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 375);
            this.Controls.Add(this.chkCharacterMirror);
            this.Controls.Add(this.chkTPV);
            this.Controls.Add(this.chkLocalMirror);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnAddBlock);
            this.Controls.Add(this.CmbSpawnMethod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumDelay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumRestTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumTry);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(240, 326);
            this.Name = "FrmNewBlock";
            this.Text = "New Block";
            ((System.ComponentModel.ISupportInitialize)(this.NumTry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRestTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private NumericUpDown NumTry;
        private NumericUpDown NumRestTime;
        private Label label2;
        private NumericUpDown NumDelay;
        private Label label3;
        private Label label4;
        private ComboBox CmbSpawnMethod;
        private Button BtnAddBlock;
        private Label label5;
        private Label label6;
        private CheckBox chkLocalMirror;
        private CheckBox chkTPV;
        private CheckBox chkCharacterMirror;
    }
}