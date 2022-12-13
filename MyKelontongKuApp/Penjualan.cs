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
    public partial class Penjualan : Form
    {
        public Penjualan()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Pengembalian pengembalian = new Pengembalian();
            this.Hide();
            pengembalian.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Pemasukan pemasukan = new Pemasukan();
            this.Hide();
            pemasukan.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Pengeluaran pengeluaran = new Pengeluaran();
            this.Hide();
            pengeluaran.ShowDialog();
        }
    }
}
