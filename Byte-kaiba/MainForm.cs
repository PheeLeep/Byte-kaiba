namespace Byte_kaiba {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override CreateParams CreateParams {
            get {
                // Minimize form and control flickering.
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void CompareFilesButton_Click(object sender, EventArgs e) {
            new OpenFilesDialog().ShowDialog(this);
            TSProgressBar.Value = 0;
            TSProgressBar.Maximum = 0;
        }

        private void BackButton_Click(object sender, EventArgs e) {
            MainPanel.BringToFront();
        }

        private void DetailsButton_Click(object sender, EventArgs e) {
            if (Comparator.File1 == null || Comparator.File2 == null) {
                MessageBox.Show(this, "Please add two files to compare.", "No files found.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            new HexReader().ShowDialog(this);
        }

        private void MainForm_Load(object sender, EventArgs e) {
            Comparator.ComparisonCompleted += Comparator_ComparisonCompleted;
            Comparator.ExceptionOccurred += Comparator_ExceptionOccurred;
            Comparator.IsOngoingChanged += Comparator_IsOngoingChanged; ;
            Comparator.ComparisonOngoing += Comparator_ComparisonOngoing;
        }

        private void Comparator_IsOngoingChanged() {
            Invoke(new Action(() => {
                CompareFilesButton.Enabled = !Comparator.IsOngoing;
                DetailsButton.Enabled = !Comparator.IsOngoing;
                ClearInfosButton.Enabled = !Comparator.IsOngoing;
            }));
        }

        private void Comparator_ComparisonOngoing(string text, int current = 0, int goal = 0) {
            Invoke(new Action(() => {
                StatusLabel.Text = text;
                TSProgressBar.Maximum = goal;
                TSProgressBar.Value = current;
            }));
        }

        private void Comparator_ExceptionOccurred(Exception ex) {
            Invoke(new Action(() => {
                MessageBox.Show(this, "An error was occurred while performing a task.\n\nError: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }));
        }

        private void Comparator_ComparisonCompleted(decimal percentage, decimal lenDifference, decimal bytesDiffered) {
            Invoke(new Action(() => {
                TotalPercentageLabel.Text = percentage.ToString() + "%";
                ByteDiffLabel.Text = "Byte Difference: " + Program.CalculateBytes((long)bytesDiffered) + " (" + bytesDiffered.ToString() + " bytes)";
                FileLengthLabel.Text = "File Length Difference: ";
                if (lenDifference == 0) {
                    FileLengthLabel.Text += "same length.";
                } else {
                    decimal absLenDifference = Math.Abs(lenDifference);
                    FileLengthLabel.Text += Program.CalculateBytes((long)absLenDifference) + " (" + absLenDifference.ToString() + " bytes) " + (lenDifference < 0 ? "behind." : "ahead.");
                }
            }));
        }

        private void ClearInfosButton_Click(object sender, EventArgs e) {
            if (Comparator.File1 != null && Comparator.File2 != null && !Comparator.IsOngoing) {
                Comparator.Clear();
                FileLengthLabel.Text = "Length Similarities: (none)";
                ByteDiffLabel.Text = "Byte Differences: (none)";
                TotalPercentageLabel.Text = "0%";
                StatusLabel.Text = "Result cleared.";
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (Comparator.IsOngoing) {
                e.Cancel = true;
                MessageBox.Show(this, "You cannot close this program while comparison is ongoing.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AboutButton_Click(object sender, EventArgs e) {
            new AboutForm().ShowDialog(this);
        }
    }
}