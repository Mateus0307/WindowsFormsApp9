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
    public partial class cad_User : Form
    {
        public cad_User()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string Senha = txtSenha.Text;
            string Nome = txtLogin.Text;
            
            string Configuracao = "server = bdmateus.mysql.dbaas.com.br; userid=bdmateus;PASSWORD= mateus1997; database=bdmateus";
            MySqlConnection CONEXAO = new MySqlConnection(Configuracao);
            try
            {
                CONEXAO.Open();

                MySqlCommand INSERT = new MySqlCommand("INSERT INTO usuarios (ID, Nome,  Senha) VALUES ('" + id + "','" + Nome + "','" + Senha + "')", CONEXAO);
                INSERT.ExecuteNonQuery();



                MessageBox.Show("Usuario Cadastrado");

                txtId.Text = "";
                txtLogin.Text = "";
                txtSenha.Text = "";
               
            }
            catch
            {
                MessageBox.Show("Nao conseguiu a conexao");
            }


        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
        }
    }
    }
