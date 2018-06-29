using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Web;
using MySql.Data.Common;
using System.Data.SqlClient;
using MuhtarlikTakip;


namespace MuhtarlikTakip
{
    public partial class Form1 : Form
    {
        long guncellenecekTC;
        public string conn;
        public MySqlConnection connect;
        public MySqlDataAdapter mySqlDataAdapter;
        public void db_connection()
        {
            try
            {
                conn = "Server=127.0.0.1;Database=muhtarliktakip;uid=root;Pwd=kod123641my;";
                connect = new MySqlConnection(conn);
                connect.Open();
                //MessageBox.Show("Db baglanti ok");
            }
            catch (MySqlException e)
            {
                throw;
            }
        }
        public Form1()
        {
            InitializeComponent();
            //dogumTarihiListele.Value = new DateTime(1990, 1, 1);
            db_connection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ikametgahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İkametgah baskı yazıcıya gönderilirdi");

        }

        private void nüfusSuretiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nüfus sureti baskı yazıcıya gönderilirdi");
        }

        private void babaAdi_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kayitNo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void kayıtListelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guncellemeArama_Click(object sender, EventArgs e)
        {
            kayitGuncelle kayitGuncelle = new kayitGuncelle();
            this.Visible = true;
            kayitGuncelle.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                long arananTC = Int64.Parse(listelenecekTC.Text);
                if (arananTC >= 10000000000 && arananTC <= 99999999999)
                {
                    string sql = "SELECT * FROM kimlik WHERE tcKimlik=" + arananTC;
                    MySqlCommand cmd = new MySqlCommand(sql, connect);
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            tcknListele.Text = rdr.GetString("tcKimlik");
                            isimListele.Text = rdr.GetString("adSoyad");
                            babaAdiListele.Text = rdr.GetString("babaAd");
                            anneAdiListele.Text = rdr.GetString("anneAd");
                            dogumTarihiListele.Value = DateTime.Parse(rdr.GetString("dogumTarihi"));
                            dogumYeriListele.Text = rdr.GetString("dogumYeri");
                            medeniHaliListele.Text = rdr.GetString("medeniHal");
                            kanGrubuListele.Text = rdr.GetString("kanGrubu");
                            ilListele.Text = rdr.GetString("il");
                            ilceListele.Text = rdr.GetString("ilce");
                            verildigiYerListele.Text = rdr.GetString("verildigiYer");
                            verilisNedeniListele.Text = rdr.GetString("verilisNedeni");
                            kayıtNoListele.Text = rdr.GetString("kayitNo");
                            adresListele2.Text = rdr.GetString("adres");

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Gecerli bir TC girin!");
                }
            }
            catch
            {
                MessageBox.Show("Gecerli bir TC girin!");
            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void temizle_Click(object sender, EventArgs e)
        {
            tcknListele.Text = "";
            isimListele.Text = "";
            babaAdiListele.Text = "";
            anneAdiListele.Text = "";
            dogumTarihiListele.Value = new DateTime(1990, 1, 1);
            dogumYeriListele.Text = "";
            medeniHaliListele.SelectedIndex = -1;
            kanGrubuListele.SelectedIndex = -1;
            ilListele.SelectedIndex = -1;
            ilceListele.Text = "";
            verildigiYerListele.Text = "";
            verilisNedeniListele.Text = "";
            kayıtNoListele.Text = "";
            adresListele2.Text = "";
        }

        private void kayitEkleButton_Click(object sender, EventArgs e)
        {
            try
            {
                long eklenenTC = Int64.Parse(tcknoYeni3.Text);
                if (eklenenTC >= 10000000000 && eklenenTC <= 99999999999)
                {
                    string cmdText = "INSERT INTO kimlik(tcKimlik, adSoyad, anneAd, babaAd, dogumTarihi, dogumYeri, medeniHal, kanGrubu, il, ilce, verildigiYer, verilisNedeni, kayitNo, adres) VALUES (@tcKimlik, @adSoyad, @anneAd, @babaAd, @dogumTarihi, @dogumYeri, @medeniHal, @kanGrubu, @il, @ilce, @verildigiYer, @verilisNedeni, @kayitNo, @adres)";
                    MySqlCommand cmd = new MySqlCommand(cmdText, connect);
                    cmd.Parameters.AddWithValue("@tcKimlik", Int64.Parse(tcknoYeni3.Text));
                    cmd.Parameters.AddWithValue("@adSoyad", isimYeni.Text);
                    cmd.Parameters.AddWithValue("@anneAd", anneYeni2.Text);
                    cmd.Parameters.AddWithValue("@babaAd", babaYeni2.Text);
                    cmd.Parameters.AddWithValue("@dogumTarihi", dogumYeni2.Value);
                    cmd.Parameters.AddWithValue("@dogumYeri", dogumYeriYeni.Text);
                    cmd.Parameters.AddWithValue("@medeniHal", medeniHalYeni.Text);
                    cmd.Parameters.AddWithValue("@kanGrubu", kanGrubuYeni.Text);
                    cmd.Parameters.AddWithValue("@il", ilSecenekYeni.Text);
                    cmd.Parameters.AddWithValue("@ilce", ilceYeni.Text);
                    cmd.Parameters.AddWithValue("@verildigiYer", verildigiYerYeni.Text);
                    cmd.Parameters.AddWithValue("@verilisNedeni", verilisNedeniYeni.Text);
                    cmd.Parameters.AddWithValue("@kayitNo", kayitNoYeni.Text);
                    cmd.Parameters.AddWithValue("@adres", adresYeni.Text);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Gecerli bir TC girin!");
                }
            }
            catch(MySqlException a)
            {
                throw;
                //MessageBox.Show("Gecerli bir TC girin!");
            }
            catch
            {
                MessageBox.Show("Gecerli bir TC girin!");
            }
        }

        private void guncellencekTc_TextChanged(object sender, EventArgs e)
        {
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab== tabControl1.TabPages["TabPage2"])
            {
                kayitGuncelle kayitGuncelle = new kayitGuncelle();
                this.Visible = true;
                kayitGuncelle.ShowDialog();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                MessageBox.Show("Transferiniz tamamlandı");
            string cmdText = "DELETE FROM kimlik WHERE tcKimlik="+silincekTc.Text;
            MySqlCommand cmd = new MySqlCommand(cmdText, connect);
            cmd.ExecuteNonQuery();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Tcnosilinecek_Click(object sender, EventArgs e)
        {

        }
    }
}
