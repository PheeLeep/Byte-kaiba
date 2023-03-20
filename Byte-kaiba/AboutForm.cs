using System.Diagnostics;

namespace Byte_kaiba {
    public partial class AboutForm : Form {
        public AboutForm() {
            InitializeComponent();
        }

        private void LicenseLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            RunLink(@"https://github.com/PheeLeep/Byte-kaiba/blob/master/LICENSE");
        }

        private void GHLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            RunLink(@"https://github.com/PheeLeep/Byte-kaiba");
        }

        private void RunLink(string link) {
            try {
                Process.Start(link);
            } catch (Exception ex) {
                MessageBox.Show(this, "Failed to open a link.\n\nCause: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
