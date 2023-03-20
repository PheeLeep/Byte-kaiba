namespace Byte_kaiba {
    public partial class HexViewerTab : UserControl {

        private Comparator.PagingFileResult? loadedHex = null;
        public HexViewerTab() {
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

        public bool IsSecondView { get; set; }

        internal void DetachEvent() {
            Comparator.LoadHexValues -= Comparator_LoadHexValues;
        }

        private void HexViewerTab_Load(object sender, EventArgs e) {
            dgv.ForeColor = Color.Black;
            dgv.BackColor = Color.White;
            dgv.Columns.Clear();
            dgv.Columns[dgv.Columns.Add("Offset", "Offset")].Width = 100;
            dgv.Columns[dgv.Columns.Add("Hex", "Hex (00 - 0F)")].Width = 100;
            dgv.Columns[dgv.Columns.Add("ASCIICol", "ASCII Text")].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Comparator.LoadHexValues += Comparator_LoadHexValues;
        }

        private void Comparator_LoadHexValues(Comparator.PagingFileResult result1, Comparator.PagingFileResult result2) {
            if (Comparator.File1 == null || Comparator.File2 == null) return;
            loadedHex = !IsSecondView ? result1 : result2;
            Invoke(new Action(() => {
                groupBox1.Text = (!IsSecondView ? Comparator.File1 : Comparator.File2).FullName;
                dgv.RowCount = 0;
                dgv.RowCount = loadedHex.Offset.Length;
                dgv.Refresh();
            }));
        }

        private void dgv_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e) {
            try {
                if (loadedHex == null) return;
                switch (e.ColumnIndex) {
                    case 0:
                        e.Value = loadedHex.Offset[e.RowIndex];
                        break;
                    case 1:
                        e.Value = loadedHex.ByteArrayValue[e.RowIndex];
                        break;
                    case 2:
                        e.Value = loadedHex.ASCIIResult[e.RowIndex];
                        break;
                    default:
                        break;
                }
            } catch (Exception ex) {
                Console.WriteLine("Something ain't right. ERROR: " + ex.Message);
            }
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            try {
                if (e == null || e.CellStyle == null || loadedHex == null) return;
                e.CellStyle.BackColor = Color.FromArgb(255, 24, 24, 24);
                if (e.ColumnIndex == 1) {
                    e.CellStyle.ForeColor = loadedHex.ByteDifferenceValue[e.RowIndex] ? Color.Green : Color.Red;
                } else {
                    e.CellStyle.ForeColor = Color.White;
                }
            } catch (Exception ex) {
                Console.WriteLine("Something ain't right. ERROR: " + ex.Message);
            }
        }
    }
}
