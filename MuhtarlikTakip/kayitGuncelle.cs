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

    public partial class kayitGuncelle : Form
    {
        public string conn;
        public MySqlConnection connect;
        public MySqlDataAdapter mySqlDataAdapter;
        public kayitGuncelle()
        {
            InitializeComponent();
        }

        private void kayitGuncelle_Load(object sender, EventArgs e)
        {
            db_connection2();
        }
        public void db_connection2()
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

        private void guncellencekTc_TextChanged(object sender, EventArgs e)
        {

        }

        private void guncellemeArama_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM kimlik WHERE tcKimlik=" + guncellencekTc.Text;
            MySqlCommand cmd = new MySqlCommand(sql, connect);
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    tcGuncel.Text = rdr.GetString("tcKimlik");
                    isimGuncel.Text = rdr.GetString("adSoyad");
                    babaGuncel.Text = rdr.GetString("babaAd");
                    anneGuncel.Text = rdr.GetString("anneAd");
                    dogumTarihGuncel.Value = DateTime.Parse(rdr.GetString("dogumTarihi"));
                    dogumYerGuncel.Text = rdr.GetString("dogumYeri");
                    medeniHaliGuncel.Text = rdr.GetString("medeniHal");
                    kanGrubuGuncel.Text = rdr.GetString("kanGrubu");
                    ilGuncel.Text = rdr.GetString("il");
                    ilceGuncel.Text = rdr.GetString("ilce");
                    verildigiGuncel.Text = rdr.GetString("verildigiYer");
                    verilisNedeni.Text = rdr.GetString("verilisNedeni");
                    kayitGuncel.Text = rdr.GetString("kayitNo");
                    adresGuncel.Text = rdr.GetString("adres");
                }
            }
        }

        private void kayitEkleButton_Click(object sender, EventArgs e)
        {
            string cmdText = "UPDATE kimlik SET adSoyad=@adSoyad,medeniHal=@medeniHal,verildigiYer=@verildigiYer,verilisNedeni=@verilisNedeni,kayitNo=@kayitNo,adres=@adres WHERE tcKimlik="+tcGuncel.Text;
            MySqlCommand cmd = new MySqlCommand(cmdText, connect);
            cmd.Parameters.AddWithValue("@adSoyad", isimGuncel.Text);
            cmd.Parameters.AddWithValue("@medeniHal", medeniHaliGuncel.Text);
            cmd.Parameters.AddWithValue("@verildigiYer", verildigiGuncel.Text);
            cmd.Parameters.AddWithValue("@verilisNedeni", verilisNedeni.Text);
            cmd.Parameters.AddWithValue("@kayitNo", kayitGuncel.Text);
            cmd.Parameters.AddWithValue("@adres", adresGuncel.Text);
            cmd.ExecuteNonQuery();
        }
    }
    
}
