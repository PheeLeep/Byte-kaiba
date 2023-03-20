namespace Byte_kaiba {
    public partial class GoToPageDialog : Form {
        public GoToPageDialog() {
            InitializeComponent();
        }

        /// <summary>
        /// Gets the specified page number.
        /// </summary>
        public int SetPage { get; private set; }

        private void CancelButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void GoToPageDialog_Load(object sender, EventArgs e) {
            numericUpDown1.Maximum = Comparator.TotalPagesIndex + 1;
            MaxPageLabel.Text = "Maximum Pages: " + numericUpDown1.Maximum.ToString();
        }

        private void GoToButton_Click(object sender, EventArgs e) {
            if (numericUpDown1.Value < 1 || numericUpDown1.Value > numericUpDown1.Maximum) {
                MessageBox.Show(this, "Value is out of range.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
            }
            SetPage = (int)numericUpDown1.Value - 1;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
