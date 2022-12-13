using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyKelontongKuApp
{
    public partial class Pelanggan : Form
    {
        public MySqlCommand cmd;
        public string idpelanggan;
        public Pelanggan()
        {
            InitializeComponent();
        }

        void tampil()
        {
            Koneksi.conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `tblpelanggan`", Koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            nopalganteng.DataSource = ds.Tables[0];
            Koneksi.conn.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Master master = new Master();
            this.Hide();
            master.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kategori kategori = new Kategori();
            this.Hide();
            kategori.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Satuan satuan = new Satuan();
            this.Hide();
            satuan.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Produk produk = new Produk();
            this.Hide();
            produk.ShowDialog();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
        }

        private void Pelanggan_Load(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `tblpelanggan`", Koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            nopalganteng.DataSource = ds.Tables[0];
            Koneksi.conn.Close();

            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("INSERT INTO `tblpelanggan` (`idpelanggan`, `namapelanggan`, `alamatpelanggan`, `notelpon`) VALUES (NULL, '" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox1.Text + "');", Koneksi.conn);
            cmd.ExecuteNonQuery();
            Koneksi.conn.Close();
        }

        private void nopalganteng_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = nopalganteng.CurrentCell.RowIndex;
            idpelanggan = nopalganteng.Rows[baris].Cells[0].Value.ToString();
            
            //MessageBox.Show(id);
           textBox1.Text = nopalganteng.Rows[baris].Cells[1].Value.ToString();
           textBox2.Text = nopalganteng.Rows[baris].Cells[2].Value.ToString();
           textBox3.Text = nopalganteng.Rows[baris].Cells[3].Value.ToString();
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("UPDATE `tblpelanggan` SET `namapelanggan` = '"+textBox1.Text+"', `alamatpelanggan` = '"+textBox2.Text+"', `notelpon` = '"+textBox3.Text+"' WHERE `tblpelanggan`.`idpelanggan` = '"+idpelanggan+"';", Koneksi.conn);
            cmd.ExecuteNonQuery();
            Koneksi.conn.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("DELETE FROM tblpelanggan WHERE `tblpelanggan`.`idpelanggan` = '"+idpelanggan+"';", Koneksi.conn);
            cmd.ExecuteNonQuery();
            Koneksi.conn.Close();
        }

        
        private void button10_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("INSERT INTO `tblpelanggan` (`idpelanggan`, `namapelanggan`, `alamatpelanggan`, `notelpon`) VALUES (NULL, '"+textBox1.Text+"', '"+textBox2.Text+"', '"+textBox1.Text+"');", Koneksi.conn);
            cmd.ExecuteNonQuery();
            Koneksi.conn.Close();

        }

        private void button6_Click_2(object sender, EventArgs e)
        {

        }

        private void nopalganteng_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = nopalganteng.CurrentCell.RowIndex;
            idpelanggan = nopalganteng.Rows[baris].Cells[0].Value.ToString();

            //MessageBox.Show(id);
            textBox1.Text = nopalganteng.Rows[baris].Cells[1].Value.ToString();
            textBox2.Text = nopalganteng.Rows[baris].Cells[2].Value.ToString();
            textBox3.Text = nopalganteng.Rows[baris].Cells[3].Value.ToString();
            textBox4.Text = nopalganteng.Rows[baris].Cells[4].Value.ToString();
        }
    }
}
