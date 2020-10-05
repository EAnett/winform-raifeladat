using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformóraifeladat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_rendszam.Text.Trim()))
            {
                MessageBox.Show("Nem töltötte ki a rendszám mezőt!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_rendszam.Focus();
            }
            if (String.IsNullOrEmpty(tb_rendszamszam.Text.Trim()))
            {
                MessageBox.Show("Nem töltötte ki a rendszám2 mezőt!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_rendszamszam.Focus();
            }
            autocl kocsi = new autocl(tb_rendszam.Text.Trim(), tb_rendszamszam.Text.Trim(), tb_tipus.Text.Trim(), (int)numericUpDown1.Value, tb_teljesítmény.Text.Trim()) ;
            lb_adatok.Items.Add(kocsi);
        }
        private void lb_adatok_SelectedIndexChanged(object sender, EventArgs e)
        {
            autocl kocsi = (autocl)lb_adatok.Items[lb_adatok.SelectedIndex];
            tb_rendszam.Text = kocsi.Rendszam1;
            tb_rendszamszam.Text = kocsi.Rendszam2;
            numericUpDown1.Value = kocsi.Gyartmany;
            tb_tipus.Text = kocsi.Tipus;
            tb_teljesítmény.Text = kocsi.Teljesitmeny;

        }
    }
}
