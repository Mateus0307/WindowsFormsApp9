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

namespace WindowsFormsApp9
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            MySqlDataReader puxar;
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string senha = txtSenha.Text;
            string Configuracao = "server=127.0.0.1:8080/apex/f?p=4950; userid=system; PASSWORD = 19971977; database=cadastro";
            MySqlConnection CONEXAO = new MySqlConnection(Configuracao);
            try
            {

                


                CONEXAO.Open();
                MySqlCommand login = new MySqlCommand("SELECT * FROM cadastro WHERE Nome = ('"+ nome +"') and Senha = ('" + senha +"')", CONEXAO);
                login.ExecuteNonQuery();

                //SqlCommand cmd = new SqlCommand(query, conn); 
                int v = (int)login.ExecuteScalar();
                if(v > 0)
                {
                    Inicio principal = new Inicio();
                    principal.ShowDialog();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("O usuario nao logou");
                }


                

                CONEXAO.Close();

                this.Close();
                txtNome.Text = "";
                txtSenha.Text = "";
                // $verifica = mysql_query("SELECT * FROM usuarios WHERE login = '$login' AND senha = '$senha'") or die("erro ao selecionar");





            }
            catch
            {
                MessageBox.Show("Não foi Possivel o Login");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
        }
    }
    }

