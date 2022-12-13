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

namespace MyKelontongKuApp
{
    public partial class Master : Form
    {
        public MySqlCommand cmd;
        public string ididentitas;
        public Master()
        {
            InitializeComponent();
        }

        void tampil()
        {
            Koneksi.conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `tblidentitas`", Koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            nopalelek.DataSource = ds.Tables[0];
            Koneksi.conn.Close();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

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

        private void Master_Load(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `tblidentitas`", Koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            nopalelek.DataSource = ds.Tables[0];
            Koneksi.conn.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("INSERT INTO `tblpelanggan` (`idpelanggan`, `namapelanggan`, `alamatpelanggan`, `notelpon`) VALUES (NULL, '" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox1.Text + "');", Koneksi.conn);
            cmd.ExecuteNonQuery();
            Koneksi.conn.Close();
        }


        private void button6_Click_2(object sender, EventArgs e)
        {

        }

        private void nopalelek_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = nopalelek.CurrentCell.RowIndex;
            ididentitas = nopalelek.Rows[baris].Cells[0].Value.ToString();

            //MessageBox.Show(id);
            textBox1.Text = nopalelek.Rows[baris].Cells[1].Value.ToString();
            textBox2.Text = nopalelek.Rows[baris].Cells[2].Value.ToString();
            textBox3.Text = nopalelek.Rows[baris].Cells[3].Value.ToString();
            textBox4.Text = nopalelek.Rows[baris].Cells[4].Value.ToString();
            textBox5.Text = nopalelek.Rows[baris].Cells[5].Value.ToString();
            textBox6.Text = nopalelek.Rows[baris].Cells[6].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("INSERT INTO `tblidentitas` (`id_identitas`, `nama_toko`, `alamat_toko`, `notelp`, `caption_pertama`, `caption_kedua`, `caption_ketiga`) VALUES(NULL, '"+textBox1.Text+"', '"+textBox2.Text+"', '"+textBox3.Text+"', '"+textBox4.Text+"', '"+textBox5.Text+"', '"+textBox6.Text+"');", Koneksi.conn);
            cmd.ExecuteNonQuery();
            Koneksi.conn.Close();

            tampil();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand(" UPDATE `tblidentitas` SET `nama_toko` = '"+textBox1.Text+"', `alamat_toko` = '"+textBox2.Text+"', `notelp` = '"+textBox3.Text+"', `caption_pertama` = '"+textBox4.Text+"', `caption_kedua` = '"+textBox5.Text+"', `caption_ketiga` = '"+textBox6.Text+"' WHERE `tblidentitas`.`id_identitas` = '"+ididentitas+"';", Koneksi.conn);
            cmd.ExecuteNonQuery();
            Koneksi.conn.Close();

            tampil();

        }
       private void button8_Click_1(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("DELETE FROM tblidentitas WHERE `tblidentitas`.`id_identitas` = '"+ididentitas+"';", Koneksi.conn);
            cmd.ExecuteNonQuery();
            Koneksi.conn.Close();

            tampil();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("INSERT INTO `tblidentitas` (`id_identitas`, `nama_toko`, `alamat_toko`, `notelp`, `caption_pertama`, `caption_kedua`, `caption_ketiga`) VALUES (NULL, '" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "');");
            cmd.ExecuteNonQuery();
            Koneksi.conn.Close();

            tampil();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
  
