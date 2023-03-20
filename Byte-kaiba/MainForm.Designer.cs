namespace Byte_kaiba {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TotalPercentageLabel = new System.Windows.Forms.Label();
            this.ByteDiffLabel = new System.Windows.Forms.Label();
            this.FileLengthLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearInfosButton = new System.Windows.Forms.Button();
            this.DetailsButton = new System.Windows.Forms.Button();
            this.CompareFilesButton = new System.Windows.Forms.Button();
            this.MainLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.AboutButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.AboutButton);
            this.MainPanel.Controls.Add(this.pictureBox1);
            this.MainPanel.Controls.Add(this.groupBox1);
            this.MainPanel.Controls.Add(this.DetailsButton);
            this.MainPanel.Controls.Add(this.CompareFilesButton);
            this.MainPanel.Controls.Add(this.MainLabel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(614, 395);
            this.MainPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Byte_kaiba.Properties.Resources.c01;
            this.pictureBox1.Location = new System.Drawing.Point(30, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.TotalPercentageLabel);
            this.groupBox1.Controls.Add(this.ByteDiffLabel);
            this.groupBox1.Controls.Add(this.FileLengthLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ClearInfosButton);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 229);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // TotalPercentageLabel
            // 
            this.TotalPercentageLabel.AutoSize = true;
            this.TotalPercentageLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalPercentageLabel.Location = new System.Drawing.Point(159, 57);
            this.TotalPercentageLabel.Name = "TotalPercentageLabel";
            this.TotalPercentageLabel.Size = new System.Drawing.Size(45, 31);
            this.TotalPercentageLabel.TabIndex = 11;
            this.TotalPercentageLabel.Text = "0%";
            // 
            // ByteDiffLabel
            // 
            this.ByteDiffLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ByteDiffLabel.Location = new System.Drawing.Point(41, 136);
            this.ByteDiffLabel.Name = "ByteDiffLabel";
            this.ByteDiffLabel.Size = new System.Drawing.Size(527, 20);
            this.ByteDiffLabel.TabIndex = 8;
            this.ByteDiffLabel.Text = "Byte Differences: (none)";
            // 
            // FileLengthLabel
            // 
            this.FileLengthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileLengthLabel.Location = new System.Drawing.Point(41, 113);
            this.FileLengthLabel.Name = "FileLengthLabel";
            this.FileLengthLabel.Size = new System.Drawing.Size(527, 20);
            this.FileLengthLabel.TabIndex = 9;
            this.FileLengthLabel.Text = "Length Similarities: (none)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "File Similarities:";
            // 
            // ClearInfosButton
            // 
            this.ClearInfosButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearInfosButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClearInfosButton.FlatAppearance.BorderSize = 0;
            this.ClearInfosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearInfosButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearInfosButton.Location = new System.Drawing.Point(429, 35);
            this.ClearInfosButton.Name = "ClearInfosButton";
            this.ClearInfosButton.Size = new System.Drawing.Size(139, 36);
            this.ClearInfosButton.TabIndex = 7;
            this.ClearInfosButton.Text = "Clear Result";
            this.ClearInfosButton.UseVisualStyleBackColor = false;
            this.ClearInfosButton.Click += new System.EventHandler(this.ClearInfosButton_Click);
            // 
            // DetailsButton
            // 
            this.DetailsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.DetailsButton.FlatAppearance.BorderSize = 0;
            this.DetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetailsButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DetailsButton.Location = new System.Drawing.Point(258, 71);
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.Size = new System.Drawing.Size(139, 36);
            this.DetailsButton.TabIndex = 3;
            this.DetailsButton.Text = "Details";
            this.DetailsButton.UseVisualStyleBackColor = false;
            this.DetailsButton.Click += new System.EventHandler(this.DetailsButton_Click);
            // 
            // CompareFilesButton
            // 
            this.CompareFilesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.CompareFilesButton.FlatAppearance.BorderSize = 0;
            this.CompareFilesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompareFilesButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CompareFilesButton.Location = new System.Drawing.Point(113, 71);
            this.CompareFilesButton.Name = "CompareFilesButton";
            this.CompareFilesButton.Size = new System.Drawing.Size(139, 36);
            this.CompareFilesButton.TabIndex = 3;
            this.CompareFilesButton.Text = "Compare Files";
            this.CompareFilesButton.UseVisualStyleBackColor = false;
            this.CompareFilesButton.Click += new System.EventHandler(this.CompareFilesButton_Click);
            // 
            // MainLabel
            // 
            this.MainLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainLabel.Location = new System.Drawing.Point(113, 37);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(479, 20);
            this.MainLabel.TabIndex = 0;
            this.MainLabel.Text = "Compare two files easily and precisely.";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSProgressBar,
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 395);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(614, 26);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TSProgressBar
            // 
            this.TSProgressBar.Name = "TSProgressBar";
            this.TSProgressBar.Size = new System.Drawing.Size(100, 18);
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.StatusLabel.ForeColor = System.Drawing.Color.Black;
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(45, 20);
            this.StatusLabel.Text = "Done";
            // 
            // AboutButton
            // 
            this.AboutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AboutButton.BackColor = System.Drawing.Color.Transparent;
            this.AboutButton.FlatAppearance.BorderSize = 0;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AboutButton.Image = global::Byte_kaiba.Properties.Resources.about;
            this.AboutButton.Location = new System.Drawing.Point(570, 12);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(32, 32);
            this.AboutButton.TabIndex = 10;
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(614, 421);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ByteKaiba";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel MainPanel;
        private Label MainLabel;
        private Button CompareFilesButton;
        private Button DetailsButton;
        private GroupBox groupBox1;
        private Label TotalPercentageLabel;
        private Label ByteDiffLabel;
        private Label FileLengthLabel;
        private Label label2;
        private Button ClearInfosButton;
        private PictureBox pictureBox1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel StatusLabel;
        private ToolStripProgressBar TSProgressBar;
        private Button AboutButton;
    }
}