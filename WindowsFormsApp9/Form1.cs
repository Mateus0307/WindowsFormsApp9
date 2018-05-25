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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Configuracao = "server = bdmateus.mysql.dbaas.com.br; userid=bdmateus;PASSWORD= mateus1997; database=bdmateus";
            MySqlConnection CONEXAO = new MySqlConnection(Configuracao);
            
        }

        private void btnEnvia_Click(object sender, EventArgs e)
        {

           

                string id = textId.Text;
                string Senha = txtPass.Text;
                string Nome = txtUser.Text;
                string Email = txtEmail.Text;
                string Configuracao = "server = bdmateus.mysql.dbaas.com.br; userid=bdmateus;PASSWORD= mateus1997; database=bdmateus";
                MySqlConnection CONEXAO = new MySqlConnection(Configuracao);
                try
                {
                    CONEXAO.Open();

                    MySqlCommand INSERT = new MySqlCommand("INSERT INTO cadastro (ID,Nome, Email,  Senha) VALUES ('" + id + "','" + Nome + "','"+ Email +"','" + Senha + "')", CONEXAO);
                    INSERT.ExecuteNonQuery();



                    MessageBox.Show("Conseguiu");

                    textId.Text = "";
                    txtPass.Text = "";
                    txtUser.Text = "";
                txtEmail.Text = "";
                }
                catch
                {
                    MessageBox.Show("Nao conseguiu a conexao");
                }
            

        }

        

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
