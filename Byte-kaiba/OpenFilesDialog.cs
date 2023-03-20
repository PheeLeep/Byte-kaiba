namespace Byte_kaiba {
    public partial class OpenFilesDialog : Form {

        private FileInfo? f1 = null;
        private FileInfo? f2 = null;
        public OpenFilesDialog() {
            InitializeComponent();
        }

        private void OpenFileComparerButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (f1 == null || f2 == null) {
                MessageBox.Show(this, "Files are empty.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult = DialogResult.OK;
            Comparator.Compare(f1, f2, !cBox.Checked);
            Close();
        }

        private void OpenFile1Button_Click(object sender, EventArgs e) {
            if (!CheckFilesExistence()) return;
            f1 = new FileInfo(OFD.FileName);
            FTextBox1.Text = OFD.FileName;
        }

        private void OpenFile2Button_Click(object sender, EventArgs e) {
            if (!CheckFilesExistence()) return;
            f2 = new FileInfo(OFD.FileName);
            FTextBox2.Text = OFD.FileName;
        }

        private bool CheckFilesExistence() {
            if (OFD.ShowDialog() != DialogResult.OK) return false;
            if (OFD.FileName.Equals(FTextBox1.Text) || OFD.FileName.Equals(FTextBox2.Text)) {
                MessageBox.Show(this, "File already added.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
    }
}
