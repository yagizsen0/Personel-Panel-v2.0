using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PersonelPanel
{

    
    public partial class form_istatistik : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2M3AKP0;Initial Catalog=PersonelVeri;Integrated Security=True;");
        public form_istatistik()
        {
            InitializeComponent();
        }

        private void form_istatistik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand personelsayi = new SqlCommand("Select count(*) from Tbl_Personel", baglanti);
            SqlDataReader personelreader = personelsayi.ExecuteReader();
            while (personelreader.Read())
            {
                Lbl_PersonelToplam.Text = personelreader[0].ToString();
            }
            baglanti.Close();
        }
    }
}
