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
    public partial class Kategori : Form
    {
        public MySqlCommand cmd;
        public string idkategori;
        public Kategori()
        {
            InitializeComponent();
        }

        void tampil()
        {
            Koneksi.conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `tblkategori`", Koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            nopalganteng2.DataSource = ds.Tables[0];
            Koneksi.conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Master master = new Master();
            this.Hide();
            master.ShowDialog();
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

        private void button5_Click(object sender, EventArgs e)
        {
            Pelanggan pelanggan = new Pelanggan();
            this.Hide();
            pelanggan.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kategori_Load(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `tblkategori`", Koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            nopalganteng2.DataSource = ds.Tables[0];
            Koneksi.conn.Close();


        }

        private void button10_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("INSERT INTO `tblkategori` (`id_kategori`, `nama_kategori`) VALUES(NULL, 'Snack');", Koneksi.conn);
            cmd.ExecuteNonQuery();
            Koneksi.conn.Close();

            tampil();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("UPDATE `tblkategori` SET `nama_kategori` = '"+textBox1.Text+"' WHERE `tblkategori`.`id_kategori` = 1;", Koneksi.conn);
            cmd.ExecuteNonQuery();
            Koneksi.conn.Close();

            tampil();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("DELETE FROM tblkategori WHERE `tblkategori`.`id_kategori` = 1", Koneksi.conn);
            cmd.ExecuteNonQuery();
            Koneksi.conn.Close();

            tampil();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("UPDATE `tblkategori` SET `nama_kategori` = 'Snack' WHERE `tblkategori`.`id_kategori` = 1;", Koneksi.conn);
            cmd.ExecuteNonQuery();
            Koneksi.conn.Close();

            tampil();
        }

        private void nopalganteng2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = nopalganteng2.CurrentCell.RowIndex;
            idkategori = nopalganteng2.Rows[baris].Cells[0].Value.ToString();

            //MessageBox.Show(id);
            textBox1.Text = nopalganteng2.Rows[baris].Cells[1].Value.ToString();
        }
    }
}
