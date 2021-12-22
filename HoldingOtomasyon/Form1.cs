using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HoldingOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        
        SqlConnection baglanti = new SqlConnection("Server = .;Database=Holding;uid=sa;pwd=11072010");

        public void Listele(string ulas)
        {
            SqlDataAdapter goruntule = new SqlDataAdapter(ulas, baglanti);
            DataSet doldur = new DataSet();
            goruntule.Fill(doldur);
            dataGridView1.DataSource = doldur.Tables[0];

            //DataTable doldur = new DataTable();
            //goruntule.Fill(doldur);
            //dataGridView1.DataSource = doldur,
        }
        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            Listele("select * from Musteriler");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand("insert into Musteriler(MAdSoyad,MDogumTarihi,MCinsiyet,MTelefon,MResim)values(@MAdSoyad,@MDogumTarihi,@MCinsiyet,@MTelefon,@MResim)", baglanti);
            command.Parameters.AddWithValue("@MAdSoyad", textMusteriAdSoyad.Text);
            command.Parameters.AddWithValue("MDogumTarihi", dateTimePicker1.Value);
            command.Parameters.AddWithValue("@MCinsiyet", comboMusteriCinsiyet.SelectedItem);
            command.Parameters.AddWithValue("@MTelefon", maskedTextBox1.Text);
            command.Parameters.AddWithValue("@Mresim", textBoxResim.Text);
            command.ExecuteNonQuery();
            baglanti.Close();
            Listele("select * from Musteriler");


        }
    }
}
