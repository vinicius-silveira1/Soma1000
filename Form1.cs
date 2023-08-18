using System.Data;
using System.Data.SqlClient;

namespace SomaLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                // Iniciando conexão com SQL Server

                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LJEA95K\\SQLEXPRESS;Initial Catalog=loginform;Integrated Security=True");

                // Variável contendo SQL querry

                String querry = "SELECT count(*) FROM login_tbl WHERE username = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    // Caso usuário e senha estejam corretos, abre o segundo forms com o programa de soma

                    Form2 f = new Form2();
                    f.ShowDialog();
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }



        }


    }
}