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
                
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LJEA95K\\SQLEXPRESS;Initial Catalog=loginform;Integrated Security=True");
                String querry = "SELECT count(*) FROM login_tbl WHERE username = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                if (dt.Rows.Count > 0 ) 
                {
                    MessageBox.Show("Login concluído");
                    
                
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos.");
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Erro: " + ex);
            }

       
           
        }

       
    }
}