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

namespace PersonelPanel
{
    public partial class Form1 : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2M3AKP0;Initial Catalog=PersonelVeri;Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriDataSet.Tbl_Personel);

        }

       

        void temizle()
        {
            TxtID.Clear();
            TxtAD.Clear();
            TxtSOYAD.Clear();           
            MskMAAS.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            TxtAD.Focus();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (PerAd,PerSoyad,PerMaas,PerDurum) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAD.Text);
            komut.Parameters.AddWithValue("@p2", TxtSOYAD.Text);
            komut.Parameters.AddWithValue("@p3", MskMAAS.Text.ToString());
            komut.Parameters.AddWithValue("@p4", label8.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            temizle();
            MessageBox.Show("Personel Kaydedildi.");
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriDataSet.Tbl_Personel);
        }
       
        private void BtnListele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriDataSet.Tbl_Personel);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label8.Text = "True";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label8.Text = "False";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://yagizsen.w3spaces.com/index.html");
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmGiris giris = new FrmGiris();
            giris.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_istatistik form2 = new form_istatistik();
            form2.Show();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Personel set PerAd = @a1,PerSoyad = @a2,PerMaas = @a3,PerDurum = @a4 where PerID = @a5", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", TxtAD.Text);
            komutguncelle.Parameters.AddWithValue("@a2", TxtSOYAD.Text);
            komutguncelle.Parameters.AddWithValue("@a3", MskMAAS.Text);
            komutguncelle.Parameters.AddWithValue("@a4", label8.Text);
            komutguncelle.Parameters.AddWithValue("@a5", TxtID.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            temizle();
            MessageBox.Show("Bilgiler Kaydedildi.");
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriDataSet.Tbl_Personel);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete from Tbl_Personel Where PerID = @k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", TxtID.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            temizle();
            MessageBox.Show("Kayıt silindi.");
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriDataSet.Tbl_Personel);
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if (label8.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAD.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSOYAD.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MskMAAS.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}

    

