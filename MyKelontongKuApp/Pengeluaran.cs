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
    public partial class Pengeluaran : Form
    {
        public Pengeluaran()
        {
            InitializeComponent();
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

        private void button7_Click(object sender, EventArgs e)
        {
            Pemasukan pemasukan = new Pemasukan();
            this.Hide();
            pemasukan.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1 = new Form1();    
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
