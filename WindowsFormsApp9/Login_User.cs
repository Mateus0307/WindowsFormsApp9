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
    public partial class Login_User : Form
    {
        

        public Login_User()
        {
            InitializeComponent();

            this.btnAdmin.BackColor = Color.Navy;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Login admin = new Login();
            admin.ShowDialog();

            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string nome = txtLogin.Text;
            string senha = txtSenha.Text;
            string Configuracao = "server = bdmateus.mysql.dbaas.com.br; userid=bdmateus;PASSWORD= mateus1997; database=bdmateus";
            MySqlConnection CONEXAO = new MySqlConnection(Configuracao);
            try
            {




                CONEXAO.Open();
                MySqlCommand login = new MySqlCommand("SELECT * FROM usuarios WHERE Nome = ('"+ nome +"') and Senha = ('" + senha + "')", CONEXAO);
                login.ExecuteNonQuery();               


                int v = (int)login.ExecuteScalar();
                if (v > 0)
                {
                    MessageBox.Show("O usuario logou");

                }
                else
                {
                    MessageBox.Show("O usuario nao logou");
                }




                CONEXAO.Close();

                this.Close();
                txtLogin.Text = "";
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

        

        private void txtSenha_TextChanged_1(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
        }
    }
}


    