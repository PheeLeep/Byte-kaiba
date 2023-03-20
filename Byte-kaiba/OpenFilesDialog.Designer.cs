namespace Byte_kaiba {
    partial class OpenFilesDialog {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.CancelBtn = new System.Windows.Forms.Button();
            this.CompareButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenFile1Button = new System.Windows.Forms.Button();
            this.OpenFile2Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.FTextBox1 = new System.Windows.Forms.TextBox();
            this.FTextBox2 = new System.Windows.Forms.TextBox();
            this.cBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelBtn.Location = new System.Drawing.Point(373, 224);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(117, 36);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.OpenFileComparerButton_Click);
            // 
            // CompareButton
            // 
            this.CompareButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CompareButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.CompareButton.FlatAppearance.BorderSize = 0;
            this.CompareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompareButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CompareButton.Location = new System.Drawing.Point(250, 224);
            this.CompareButton.Name = "CompareButton";
            this.CompareButton.Size = new System.Drawing.Size(117, 36);
            this.CompareButton.TabIndex = 2;
            this.CompareButton.Text = "Compare";
            this.CompareButton.UseVisualStyleBackColor = false;
            this.CompareButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "File 1:";
            // 
            // OpenFile1Button
            // 
            this.OpenFile1Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.OpenFile1Button.FlatAppearance.BorderSize = 0;
            this.OpenFile1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFile1Button.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenFile1Button.Location = new System.Drawing.Point(76, 19);
            this.OpenFile1Button.Name = "OpenFile1Button";
            this.OpenFile1Button.Size = new System.Drawing.Size(59, 24);
            this.OpenFile1Button.TabIndex = 4;
            this.OpenFile1Button.Text = "...";
            this.OpenFile1Button.UseVisualStyleBackColor = false;
            this.OpenFile1Button.Click += new System.EventHandler(this.OpenFile1Button_Click);
            // 
            // OpenFile2Button
            // 
            this.OpenFile2Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.OpenFile2Button.FlatAppearance.BorderSize = 0;
            this.OpenFile2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFile2Button.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenFile2Button.Location = new System.Drawing.Point(76, 91);
            this.OpenFile2Button.Name = "OpenFile2Button";
            this.OpenFile2Button.Size = new System.Drawing.Size(59, 24);
            this.OpenFile2Button.TabIndex = 7;
            this.OpenFile2Button.Text = "...";
            this.OpenFile2Button.UseVisualStyleBackColor = false;
            this.OpenFile2Button.Click += new System.EventHandler(this.OpenFile2Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "File 2:";
            // 
            // OFD
            // 
            this.OFD.SupportMultiDottedExtensions = true;
            this.OFD.Title = "Open FIle";
            // 
            // FTextBox1
            // 
            this.FTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.FTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FTextBox1.ForeColor = System.Drawing.Color.White;
            this.FTextBox1.Location = new System.Drawing.Point(23, 49);
            this.FTextBox1.Name = "FTextBox1";
            this.FTextBox1.ReadOnly = true;
            this.FTextBox1.Size = new System.Drawing.Size(457, 20);
            this.FTextBox1.TabIndex = 9;
            // 
            // FTextBox2
            // 
            this.FTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.FTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FTextBox2.ForeColor = System.Drawing.Color.White;
            this.FTextBox2.Location = new System.Drawing.Point(23, 121);
            this.FTextBox2.Name = "FTextBox2";
            this.FTextBox2.ReadOnly = true;
            this.FTextBox2.Size = new System.Drawing.Size(457, 20);
            this.FTextBox2.TabIndex = 10;
            // 
            // cBox
            // 
            this.cBox.AutoSize = true;
            this.cBox.Location = new System.Drawing.Point(23, 157);
            this.cBox.Name = "cBox";
            this.cBox.Size = new System.Drawing.Size(161, 24);
            this.cBox.TabIndex = 11;
            this.cBox.Text = "Skip Compute Hash";
            this.cBox.UseVisualStyleBackColor = true;
            // 
            // OpenFilesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(502, 272);
            this.Controls.Add(this.cBox);
            this.Controls.Add(this.FTextBox2);
            this.Controls.Add(this.FTextBox1);
            this.Controls.Add(this.OpenFile2Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OpenFile1Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CompareButton);
            this.Controls.Add(this.CancelBtn);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OpenFilesDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Open Files for Comparison";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CancelBtn;
        private Button CompareButton;
        private Label label1;
        private Button OpenFile1Button;
        private Button OpenFile2Button;
        private Label label3;
        private OpenFileDialog OFD;
        private TextBox FTextBox1;
        private TextBox FTextBox2;
        internal CheckBox cBox;
    }
}