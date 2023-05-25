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

namespace KutuphaneOtomasyonu
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = ELIFISIK; Initial Catalog = Kutuphane; Integrated Security = True");
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }




        private void buttonadd_Click(object sender, EventArgs e)
        {
            try

            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Kitaplar (KitapAdi,YazarAdi,YazarSoyadi,ISBN,Durum,KitapturKodu) VALUES(@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);

                sqlCommand.Parameters.AddWithValue("@p2", textBoxka.Text);
                sqlCommand.Parameters.AddWithValue("@p3", textBoxya.Text);
                sqlCommand.Parameters.AddWithValue("@p4", textBoxys.Text);
                sqlCommand.Parameters.AddWithValue("@p6", "True");
                sqlCommand.Parameters.AddWithValue("@p5", textBoxısbn.Text);
                sqlCommand.Parameters.AddWithValue("@p7", Convert.ToInt32(textBoxktk.Text));


                sqlCommand.ExecuteNonQuery();
                verilerigöster();
            }
            catch (Exception)
            {
                MessageBox.Show("sorun oluştu");

            }
            finally
            {
                baglanti.Close();
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void verilerigöster()
        {
            string q = "SELECT * FROM Kitaplar";
            SqlDataAdapter da = new SqlDataAdapter(q, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }




        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatır = dataGridView1.SelectedCells[0].RowIndex;
            labelıd.Text = dataGridView1.Rows[secilenSatır].Cells[0].Value.ToString();
            textBoxka.Text = dataGridView1.Rows[secilenSatır].Cells[1].Value.ToString();
            textBoxya.Text = dataGridView1.Rows[secilenSatır].Cells[2].Value.ToString();
            textBoxys.Text = dataGridView1.Rows[secilenSatır].Cells[3].Value.ToString();
            textBoxdurum.Text = dataGridView1.Rows[secilenSatır].Cells[5].Value.ToString();
            textBoxısbn.Text = dataGridView1.Rows[secilenSatır].Cells[4].Value.ToString();
            textBoxktk.Text = dataGridView1.Rows[secilenSatır].Cells[8].Value.ToString();
            textBox7.Text = dataGridView1.Rows[secilenSatır].Cells[6].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[secilenSatır].Cells[7].Value.ToString();



        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sqlCommand = new SqlCommand("UPDATE Kitaplar SET KitapAdi =@P2, YazarAdi=@p3,YazarSoyadi=@p4,Durum=@p5,ISBN=@p6,KitapTurKodu=@p7 WHERE Id=@p1", baglanti);
            try

            {

                sqlCommand.Parameters.AddWithValue("@p1", labelıd.Text);
                sqlCommand.Parameters.AddWithValue("@p2", textBoxka.Text);
                sqlCommand.Parameters.AddWithValue("@p3", textBoxya.Text);
                sqlCommand.Parameters.AddWithValue("@p4", textBoxys.Text);
                sqlCommand.Parameters.AddWithValue("@p5", textBoxdurum.Text);
                sqlCommand.Parameters.AddWithValue("@p6", textBoxısbn.Text);
                sqlCommand.Parameters.AddWithValue("@p7", Convert.ToInt32(textBoxktk.Text));
                sqlCommand.ExecuteNonQuery();
                verilerigöster();
            }
            catch (Exception)
            {
                MessageBox.Show("sorun oluştu");

            }
            finally
            {
                baglanti.Close();
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE Kitaplar SET OduncAlan=@p2 ,OduncAlmaTarihi=@p3,Durum=@p4 WHERE Id=@p1", baglanti);
                sqlCommand.Parameters.AddWithValue("@p1", labelıd.Text);
                sqlCommand.Parameters.AddWithValue("@p2", textBox7.Text);
                sqlCommand.Parameters.AddWithValue("@p4", "False");
                sqlCommand.Parameters.AddWithValue("@p3", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                sqlCommand.ExecuteNonQuery();
                verilerigöster();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Kitap ödünç işlemi sırasında hata oluştu");
            }

            finally { baglanti.Close(); }



        }

        private void buttonhesapla_Click(object sender, EventArgs e)
        {
            if (labelıd.Text != "-")
            {
                DateTime thisToday = DateTime.Now;
                int gunFarki = (int)(thisToday - dateTimePicker1.Value.Date).TotalDays;
                if (gunFarki > 10)
                {
                    int gecikmebedeli = (gunFarki - 10) * 1;
                    label3.Text = gecikmebedeli.ToString();
                }

            }
        }

        private void buttoniade_Click(object sender, EventArgs e)
        {
            if (labelıd.Text != "-")
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE Kitaplar SET OduncAlan=@p1,OduncAlmaTarihi=@p2 WHERE Id=@p3", baglanti);
                    sqlCommand.Parameters.AddWithValue("p3", labelıd.Text);
                    sqlCommand.Parameters.AddWithValue("p1", "");
                    sqlCommand.Parameters.Add("p2", SqlDbType.Date).Value = DBNull.Value;
                    sqlCommand.ExecuteNonQuery();
                    verilerigöster();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap iade işlemi gerçekleşmedi");

                }
                finally
                {
                    baglanti.Close();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            aramasonuclarınıgöster();
        }
        private void aramasonuclarınıgöster()
        {
            string q = "SELECT *FROM Kitaplar WHERE OduncAlan LIKE '" + textBox1.Text + "'";

            SqlDataAdapter da = new SqlDataAdapter(q, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }




        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            if (labelıd.Text != "-")
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("DELETE  FROM Kitaplar WHERE Id=@p3", baglanti);
                    sqlCommand.Parameters.AddWithValue("p3", labelıd.Text);
                    sqlCommand.ExecuteNonQuery();
                    verilerigöster();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap sİlme  işlemi gerçekleşmedi");

                }
                finally
                {
                    baglanti.Close();
                }
            }
        }

        private void buttontemizle_Click(object sender, EventArgs e)
        {
            labelıd.Text = "";
            textBoxka.Text = "";
            textBoxya.Text = "";
            textBoxys.Text = "";
            textBoxdurum.Text = "";
            textBoxısbn.Text = "";
            textBox7.Text = "";
            textBoxktk.Text = "";
            textBox1.Text = "";
        }

        private void veri_Click(object sender, EventArgs e)
        {
            verilerigöster();
        }
    }
}





