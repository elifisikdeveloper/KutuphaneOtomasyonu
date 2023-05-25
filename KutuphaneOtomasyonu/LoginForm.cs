using System.Data.SqlClient;

namespace KutuphaneOtomasyonu
{
    public partial class LoginForm : Form
    {


        public LoginForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = ELIFISIK; Initial Catalog = Kutuphane; Integrated Security = True");



        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlKomut = new SqlCommand("SELECT * FROM Yonetim WHERE Sifre=@sifre AND Kullan�c�Ad� =@p1", baglanti);
                sqlKomut.Parameters.AddWithValue("@sifre", txtbpassword.Text);
                sqlKomut.Parameters.AddWithValue("@p1", tbuser.Text);
                SqlDataReader sqlDataReader = sqlKomut.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    MessageBox.Show("Giri� ba�ar�l�");
                    Home homepage = new Home();
                    this.Hide();
                    homepage.Show();
                }
                else
                {
                    MessageBox.Show("Giri� ba�ar�s�z");
                }


            }

            finally { baglanti.Close(); }


        }
    }
}