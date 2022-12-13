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
    public partial class Satuan : Form
    {
        public MySqlCommand cmd;
        public string idsatuan;
        public Satuan()
        {
            InitializeComponent();
        }

        void tampil()
        {
            Koneksi.conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `tblsatuan`", Koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            nopalganteng3.DataSource = ds.Tables[0];
            Koneksi.conn.Close();
        }

        private void Satuan_Load(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `tblsatuan`", Koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            nopalganteng3.DataSource = ds.Tables[0];
            Koneksi.conn.Close();
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

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("INSERT INTO `tblsatuan` (`idsatuan`, `satuankecil`, `satuanbesar`, `nilaisatuankecil`) VALUES (NULL, '"+textBox1.Text+"', '"+textBox2.Text+"', '"+textBox3.Text+"););", Koneksi.conn);
            cmd.ExecuteNonQuery();
            Koneksi.conn.Close();

            tampil();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("UPDATE `tblsatuan` SET `nilaisatuankecil` = '100' WHERE `tblsatuan`.`idsatuan` = '"+idsatuan+"';", Koneksi.conn);
            cmd.ExecuteNonQuery();
            Koneksi.conn.Close();

            tampil();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("DELETE FROM tblsatuan WHERE `tblsatuan`.`idsatuan` = '"+idsatuan+"'", Koneksi.conn);
            cmd.ExecuteNonQuery();
            Koneksi.conn.Close();

            tampil();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("UPDATE `tblsatuan` SET `nilaisatuankecil` = '100' WHERE `tblsatuan`.`idsatuan` = '" + idsatuan + "';", Koneksi.conn);
            cmd.ExecuteNonQuery();
            Koneksi.conn.Close();

            tampil();
        
        }

        private void nopalganteng3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = nopalganteng3.CurrentCell.RowIndex;
            idsatuan = nopalganteng3.Rows[baris].Cells[0].Value.ToString();

            //MessageBox.Show(id);
            textBox1.Text = nopalganteng3.Rows[baris].Cells[1].Value.ToString();
            textBox2.Text = nopalganteng3.Rows[baris].Cells[2].Value.ToString();
            textBox3.Text = nopalganteng3.Rows[baris].Cells[3].Value.ToString();
        }

        private void nopalganteng3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = nopalganteng3.CurrentCell.RowIndex;
            idsatuan = nopalganteng3.Rows[baris].Cells[0].Value.ToString();

            //MessageBox.Show(id);
            textBox1.Text = nopalganteng3.Rows[baris].Cells[1].Value.ToString();
            textBox2.Text = nopalganteng3.Rows[baris].Cells[2].Value.ToString();
            textBox3.Text = nopalganteng3.Rows[baris].Cells[3].Value.ToString();
        }
    }
}
