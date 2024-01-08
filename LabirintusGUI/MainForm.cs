using System.Windows.Forms;

namespace LabirintusGUI
{
    public partial class MainForm : Form
    {
        public CheckBox[,]? CbxMatrix { get; set; }

        public MainForm()
        {
            InitializeComponent();
            InitDropDowns();
            btnLetrehozas.Click += BtnLetrehozas_Click;
            btnMentes.Click += BtnMentes_Click;
        }

        private void BtnMentes_Click(object? sender, EventArgs e)
        {
            try
            {
                if (CbxMatrix is null) throw new Exception("még nem hoztál létre labirintust!");

                using StreamWriter sw = new($@"..\..\..\sae\Lab{cbxIndex.SelectedItem}.txt");
                for (int s = 0; s < CbxMatrix.GetLength(0); s++)
                {
                    string sor = string.Empty;
                    for (int o = 0; o < CbxMatrix.GetLength(1); o++)
                    {
                        sor += CbxMatrix[s, o].Checked ? 'X' : ' ';
                    }
                    sw.WriteLine(sor);
                }

                MessageBox.Show(
                    caption: "siker!",
                    text: "Az állomány mentése sikeres!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    caption: "hiba!",
                    text: ex.Message);
            }
        }

        private void BtnLetrehozas_Click(object? sender, EventArgs e)
        {
            pnlMain.Controls.Clear();

            CbxMatrix = new CheckBox[
                (int)cbxSor.SelectedItem, 
                (int)cbxOszlop.SelectedItem];

            for (int s = 0; s < CbxMatrix.GetLength(0); s++)
            {
                for (int o = 0; o < CbxMatrix.GetLength(1); o++)
                {
                    CbxMatrix[s, o] = new CheckBox()
                    {
                        Bounds = new(
                            x: o * 20,
                            y: s * 20,
                            width: 20,
                            height: 20),
                        Enabled = 
                               s != 0 
                            && o != 0 
                            && s != CbxMatrix.GetLength(0) - 1
                            && o != CbxMatrix.GetLength(1) - 1,
                    };
                    CbxMatrix[s, o].Checked = !CbxMatrix[s,o].Enabled;
                    pnlMain.Controls.Add(CbxMatrix[s, o]);
                }
            }
            CbxMatrix[1, 0].Checked = false;
            CbxMatrix[CbxMatrix.GetLength(0) - 2, CbxMatrix.GetLength(1) - 1].Checked = false;
        }

        public void InitDropDowns()
        {
            for (int d = 1; d <= 20; d++)
            {
                if (d >= 5)
                {
                    cbxSor.Items.Add(d);
                    cbxOszlop.Items.Add(d);
                }
                if (d <= 16) cbxIndex.Items.Add(d);
            }
            cbxSor.SelectedItem = 12;
            cbxOszlop.SelectedItem = 12;
            cbxIndex.SelectedItem = 3;
        }
    }


}
