using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyKelontongKuApp
{
    public partial class Lpenjualan : Form
    {
        public Lpenjualan()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();  
            this.Hide();
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Lpelanggan lpelanggan = new Lpelanggan();
            this.Hide();
            lpelanggan.ShowDialog();    
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Lbarang lbarang = new Lbarang(); 
            this.Hide();
            lbarang.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Laperjenis laperjenis = new Laperjenis(); 
            this.Hide();
            laperjenis.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lpendapatan lpendapatan = new Lpendapatan();
            this.Hide();
            lpendapatan.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lkeuangan lkeuangan = new Lkeuangan();
            this.Hide();
            lkeuangan.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lpengembalian lpengembalian = new Lpengembalian();
            this.Hide();
            lpengembalian.ShowDialog();
        }
    }
}
