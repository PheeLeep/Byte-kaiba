namespace Byte_kaiba {
    partial class HexReader {
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "SHA1",
            "",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "SHA256",
            "",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "SHA512",
            "",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "MD5",
            "",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "CRC32",
            "",
            ""}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HexReader));
            this.HexViewerPanel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.hxv1 = new Byte_kaiba.HexViewerTab();
            this.hxv2 = new Byte_kaiba.HexViewerTab();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RightPageButton = new System.Windows.Forms.Button();
            this.JumpToButton = new System.Windows.Forms.Button();
            this.PageLabel = new System.Windows.Forms.Label();
            this.LeftPageButton = new System.Windows.Forms.Button();
            this.StagePanel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.HexViewerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.StagePanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // HexViewerPanel
            // 
            this.HexViewerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.HexViewerPanel.Controls.Add(this.splitContainer1);
            this.HexViewerPanel.Controls.Add(this.vScrollBar1);
            this.HexViewerPanel.Controls.Add(this.panel1);
            this.HexViewerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HexViewerPanel.Location = new System.Drawing.Point(3, 3);
            this.HexViewerPanel.Name = "HexViewerPanel";
            this.HexViewerPanel.Size = new System.Drawing.Size(842, 454);
            this.HexViewerPanel.TabIndex = 9;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 50);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.hxv1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.hxv2);
            this.splitContainer1.Size = new System.Drawing.Size(816, 404);
            this.splitContainer1.SplitterDistance = 408;
            this.splitContainer1.TabIndex = 1;
            // 
            // hxv1
            // 
            this.hxv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.hxv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hxv1.ForeColor = System.Drawing.Color.White;
            this.hxv1.IsSecondView = false;
            this.hxv1.Location = new System.Drawing.Point(0, 0);
            this.hxv1.Name = "hxv1";
            this.hxv1.Size = new System.Drawing.Size(408, 404);
            this.hxv1.TabIndex = 0;
            // 
            // hxv2
            // 
            this.hxv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.hxv2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hxv2.ForeColor = System.Drawing.Color.White;
            this.hxv2.IsSecondView = true;
            this.hxv2.Location = new System.Drawing.Point(0, 0);
            this.hxv2.Name = "hxv2";
            this.hxv2.Size = new System.Drawing.Size(404, 404);
            this.hxv2.TabIndex = 1;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(816, 50);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(26, 404);
            this.vScrollBar1.TabIndex = 2;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RightPageButton);
            this.panel1.Controls.Add(this.JumpToButton);
            this.panel1.Controls.Add(this.PageLabel);
            this.panel1.Controls.Add(this.LeftPageButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 50);
            this.panel1.TabIndex = 0;
            // 
            // RightPageButton
            // 
            this.RightPageButton.BackColor = System.Drawing.Color.Transparent;
            this.RightPageButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.RightPageButton.FlatAppearance.BorderSize = 0;
            this.RightPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RightPageButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RightPageButton.Location = new System.Drawing.Point(314, 0);
            this.RightPageButton.Name = "RightPageButton";
            this.RightPageButton.Size = new System.Drawing.Size(47, 50);
            this.RightPageButton.TabIndex = 6;
            this.RightPageButton.Text = ">";
            this.RightPageButton.UseVisualStyleBackColor = false;
            this.RightPageButton.Click += new System.EventHandler(this.RightPageButton_Click);
            // 
            // JumpToButton
            // 
            this.JumpToButton.BackColor = System.Drawing.Color.Transparent;
            this.JumpToButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.JumpToButton.FlatAppearance.BorderSize = 0;
            this.JumpToButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JumpToButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.JumpToButton.Image = global::Byte_kaiba.Properties.Resources.JumpTo;
            this.JumpToButton.Location = new System.Drawing.Point(267, 0);
            this.JumpToButton.Name = "JumpToButton";
            this.JumpToButton.Size = new System.Drawing.Size(47, 50);
            this.JumpToButton.TabIndex = 7;
            this.JumpToButton.UseVisualStyleBackColor = false;
            this.JumpToButton.Click += new System.EventHandler(this.JumpToButton_Click);
            // 
            // PageLabel
            // 
            this.PageLabel.AutoEllipsis = true;
            this.PageLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.PageLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PageLabel.Location = new System.Drawing.Point(47, 0);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(220, 50);
            this.PageLabel.TabIndex = 5;
            this.PageLabel.Text = "Page 1/1";
            this.PageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LeftPageButton
            // 
            this.LeftPageButton.BackColor = System.Drawing.Color.Transparent;
            this.LeftPageButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPageButton.FlatAppearance.BorderSize = 0;
            this.LeftPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeftPageButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LeftPageButton.Location = new System.Drawing.Point(0, 0);
            this.LeftPageButton.Name = "LeftPageButton";
            this.LeftPageButton.Size = new System.Drawing.Size(47, 50);
            this.LeftPageButton.TabIndex = 4;
            this.LeftPageButton.Text = "<";
            this.LeftPageButton.UseVisualStyleBackColor = false;
            this.LeftPageButton.Click += new System.EventHandler(this.LeftPageButton_Click);
            // 
            // StagePanel
            // 
            this.StagePanel.Controls.Add(this.tabControl1);
            this.StagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StagePanel.Location = new System.Drawing.Point(0, 0);
            this.StagePanel.Name = "StagePanel";
            this.StagePanel.Size = new System.Drawing.Size(856, 493);
            this.StagePanel.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(856, 493);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.HexViewerPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(848, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hex Viewer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(848, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Checksum";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(842, 454);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Checksums";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "File 1";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "File 2";
            this.columnHeader3.Width = 200;
            // 
            // HexReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(856, 493);
            this.Controls.Add(this.StagePanel);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "HexReader";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "More Info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HexReader_FormClosing);
            this.Load += new System.EventHandler(this.HexReader_Load);
            this.HexViewerPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.StagePanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel HexViewerPanel;
        private SplitContainer splitContainer1;
        private Panel panel1;
        private Button LeftPageButton;
        private Label PageLabel;
        private Button RightPageButton;
        private HexViewerTab hxv1;
        private HexViewerTab hxv2;
        private Panel StagePanel;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private VScrollBar vScrollBar1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button JumpToButton;
    }
}