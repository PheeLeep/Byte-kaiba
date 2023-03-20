namespace Byte_kaiba {
    public partial class HexReader : Form {
        private int pageIndex = 0;

        public HexReader() {
            InitializeComponent();
        }

        private void HexReader_Load(object sender, EventArgs e) {
            hxv1.CreateControl();
            hxv2.CreateControl();
            new Thread(() => {
                while (!IsHandleCreated || !hxv1.IsHandleCreated || !hxv2.IsHandleCreated) {
                    Thread.Sleep(500);
                }
                Comparator.LoadHexValues += Comparator_LoadHexValues;
                Thread.Sleep(500);
                Comparator.PageReadFiles(pageIndex);
            }).Start();
            SetEnable(false);
            ShowComputedResults(Comparator.Computed1, 1);
            ShowComputedResults(Comparator.Computed2, 2);
        }

        private void Comparator_LoadHexValues(Comparator.PagingFileResult result1, Comparator.PagingFileResult result2) {
            SetEnable(true);
        }

        private void HexReader_FormClosing(object sender, FormClosingEventArgs e) {
            hxv1.DetachEvent();
            hxv2.DetachEvent();
            Comparator.LoadHexValues -= Comparator_LoadHexValues;
        }

        private void LeftPageButton_Click(object sender, EventArgs e) {
            if (pageIndex == 0 || Comparator.IsOngoing) return;
            SetEnable(false);
            pageIndex--;
            Comparator.PageReadFiles(pageIndex);
        }

        private void RightPageButton_Click(object sender, EventArgs e) {
            if (pageIndex == Comparator.TotalPagesIndex || Comparator.IsOngoing) return;
            SetEnable(false);
            pageIndex++;
            Comparator.PageReadFiles(pageIndex);
        }

        private void SetEnable(bool isEnabled) {
            if (InvokeRequired) {
                Invoke(new Action(() => SetEnable(!(pageIndex == Comparator.TotalPagesIndex && Comparator.TotalPagesIndex == 0) && isEnabled)));
                return;
            }
            LeftPageButton.Enabled = isEnabled;
            RightPageButton.Enabled = isEnabled;
            JumpToButton.Enabled = isEnabled;
            if (isEnabled) {
                PageLabel.Text = "Page " + (pageIndex + 1).ToString() + "/" + (Comparator.TotalPagesIndex + 1).ToString();
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e) {
            vScrollBar1.Maximum = Math.Max(Math.Max(hxv1.dgv.RowCount, hxv2.dgv.RowCount) - hxv1.dgv.DisplayedRowCount(false), 0);
            int scVal = Math.Min(vScrollBar1.Value, vScrollBar1.Maximum);
            hxv1.dgv.FirstDisplayedScrollingRowIndex = scVal;
            hxv2.dgv.FirstDisplayedScrollingRowIndex = scVal;
            vScrollBar1.Value = (hxv1.dgv.FirstDisplayedScrollingRowIndex < vScrollBar1.Minimum ? hxv1 : hxv2).dgv.FirstDisplayedScrollingRowIndex;
        }

        private void ShowComputedResults(ComputedHashClass? chc, int subitemIndex) {
            if (chc == null || subitemIndex < 1 || subitemIndex > 2) return;
            listView1.Columns[subitemIndex].Text = chc.File.Name;
            listView1.Items[0].SubItems[subitemIndex].Text = chc.SHA1Result;
            listView1.Items[1].SubItems[subitemIndex].Text = chc.SHA256Result;
            listView1.Items[2].SubItems[subitemIndex].Text = chc.SHA512Result;
            listView1.Items[3].SubItems[subitemIndex].Text = chc.MD5Result;
            listView1.Items[4].SubItems[subitemIndex].Text = chc.CRC32Result;
        }

        private void JumpToButton_Click(object sender, EventArgs e) {
            if (pageIndex == 0 && Comparator.TotalPagesIndex == 1) return;
            using GoToPageDialog gtpage = new();
            if (gtpage.ShowDialog(this) != DialogResult.OK) return;
            pageIndex = gtpage.SetPage;
            Comparator.PageReadFiles(pageIndex);
        }
    }
}
