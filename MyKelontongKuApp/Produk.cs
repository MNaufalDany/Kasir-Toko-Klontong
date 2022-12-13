using MySql.Data.MySqlClient;
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
   
    public partial class Produk : Form
    {
        public MySqlCommand cmd;
        public string idproduk;
        public Produk()
        {
            InitializeComponent();
        }

        void tampil()
        {
            Koneksi.conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `tblbarang`", Koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            nopalganteng1.DataSource = ds.Tables[0];
            Koneksi.conn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            Pelanggan pelanggan = new Pelanggan();
            this.Hide();
            pelanggan.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();  
            this.Hide();
            form.ShowDialog();
        }

        private void Produk_Load(object sender, EventArgs e)
        {
                Koneksi.conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `tblbarang`", Koneksi.conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                nopalganteng1.DataSource = ds.Tables[0];
                Koneksi.conn.Close();


        }

        private void nopalganteng1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nopalganteng1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = nopalganteng1.CurrentCell.RowIndex;
            idproduk = nopalganteng1.Rows[baris].Cells[0].Value.ToString();

            //MessageBox.Show(id);
            textBox1.Text = nopalganteng1.Rows[baris].Cells[1].Value.ToString();
            textBox2.Text = nopalganteng1.Rows[baris].Cells[2].Value.ToString();     
            textBox4.Text = nopalganteng1.Rows[baris].Cells[4].Value.ToString();
            textBox5.Text = nopalganteng1.Rows[baris].Cells[5].Value.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("INSERT INTO `tblbarang` (`idbarang`, `idkategori`, `idsatuan`, `nama_barang`, `stok`, `hargasatuanbesar`, `hargasatuankecil`, `keterangan`, `kulakan`, `titipan`) VALUES (NULL, '"+comboBox1.SelectedItem+"', '"+comboBox3.SelectedItem+"', '"+textBox1.Text+"', '"+textBox2.Text+"', '"+textBox4.Text+"', '"+textBox5.Text+"', '"+textBox3.Text+"', '"+comboBox2.Text+"', '"+comboBox2.Text+"');", Koneksi.conn);
            cmd.ExecuteNonQuery();
            Koneksi.conn.Close();

            tampil();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("UPDATE `tblbarang` SET `stok` = '5' WHERE `tblbarang`.`idbarang` = 1;", Koneksi.conn);
            cmd.ExecuteNonQuery();
            Koneksi.conn.Close();

            tampil();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("DELETE FROM tblbarang WHERE `tblbarang`.`idbarang` = 1", Koneksi.conn);
            cmd.ExecuteNonQuery();
            Koneksi.conn.Close();

            tampil();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("UPDATE `tblbarang` SET `stok` = '5' WHERE `tblbarang`.`idbarang` = 1;", Koneksi.conn);
            cmd.ExecuteNonQuery();
            Koneksi.conn.Close();

            tampil();
        }
    }
    }

