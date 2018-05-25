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
    public partial class Nvsenha : Form
    {
        public Nvsenha()
        {
            InitializeComponent();
        }

        private void Nvsenha_Load(object sender, EventArgs e)
        {

        }

        private void btnSenha_Click(object sender, EventArgs e )
        {

            string newsenha = txtNewsenha.Text;
            string Configuracao = "server = bdmateus.mysql.dbaas.com.br; userid=bdmateus;PASSWORD= mateus1997; database=bdmateus";
            MySqlConnection CONEXAO = new MySqlConnection(Configuracao);
            try
            {
                CONEXAO.Open();
                MySqlCommand INSERT = new MySqlCommand("UPDATE cadastro SET Senha = ('" + newsenha + "') WHERE ID = ('"+txtIds.Text+"')", CONEXAO);//Aleluia funcionou
                INSERT.ExecuteNonQuery();

                /*MySqlCommand cmdtext = new MySqlCommand("UPDATE cadastro SET Senha=('"+txtNewsenha.Text+"') WHERE ID = '"+txtIds.Text+"')", CONEXAO);
                cmdtext.ExecuteReader();
                CONEXAO.Close();*/
                // UPDATE.ExecuteNonQuery();

                //UPDATE.Parameters.AddWithValue("@senha", newP.txtNewSenha);
                //UPDATE.Parameters.AddWithValue("@id", id);
                //UPDATE `cadastro` SET `ID`=(),`Nome`=(value - 2),`Senha`=(value - 3) WHERE 1
                //UPDATE `cadastro` SET `Senha`= (3) WHERE ID = (1)
                //UPDATE Student SET Address = @add, City = @cit Where FirstName = @fn and LastName = @add

                MessageBox.Show("Senha alterada com SUCESSO");
            }
            catch
            {
                MessageBox.Show("Não foi possivel a conexão");
            }

    }

        private void txtNewsenha_TextChanged(object sender, EventArgs e)
        {
            txtNewsenha.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }