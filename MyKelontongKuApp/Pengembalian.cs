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
    public partial class Pengembalian : Form
    {
        public Pengembalian()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Penjualan penjualan = new Penjualan();
            this.Hide();
            penjualan.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
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
