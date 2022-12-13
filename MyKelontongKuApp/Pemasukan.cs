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
    public partial class Pemasukan : Form
    {
        public Pemasukan()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Penjualan penjualan = new Penjualan();
            this.Hide();
            penjualan.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Pengembalian pengembalian = new Pengembalian();
            this.Hide();
            pengembalian.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Pengeluaran pengeluaran = new Pengeluaran();
            this.Hide();
            pengeluaran.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1 = new Form1();
        }
    }
}
