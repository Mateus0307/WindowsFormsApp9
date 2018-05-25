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
    public partial class Tela2 : Form
    {

        MySqlDataReader puxar;
        
        public Tela2()
        {
            InitializeComponent();
        }

        private void Tela2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Configuracao = "server = bdmateus.mysql.dbaas.com.br; userid=bdmateus;PASSWORD= mateus1997; database=bdmateus";
            MySqlConnection CONEXAO = new MySqlConnection(Configuracao);
            try
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                listBox4.Items.Clear();

                CONEXAO.Open();
                MySqlCommand INSERT = new MySqlCommand("SELECT ID, Nome, Email, Senha FROM cadastro", CONEXAO);
                MySqlDataReader puxar = INSERT.ExecuteReader();
               
                    
                    
                    while (puxar.Read())
                    {
                        listBox1.Items.Add(puxar["ID"].ToString());
                        listBox2.Items.Add(puxar ["Nome"].ToString());
                        listBox3.Items.Add(puxar ["Senha"].ToString());
                        listBox4.Items.Add(puxar["Email"].ToString());  
                        


                    
                }
                CONEXAO.Close();
            }
            catch
            {
                MessageBox.Show("Nao conseguiu a conexao");
            }

        }
        
  //Ambos são Funcionais, porém o de cima é mais facil compreenção 

            /*listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            MySqlConnection CONEXAO = new MySqlConnection ("server=localhost; userid=root; database=teste");

            //string com o comando a ser executado 
            string sql = "SELECT ID, Nome, Senha from cadastro";

            //instância do comando recebendo como parâmetro 
            //a string com o comando e a conexão 
            MySqlCommand cmd = new MySqlCommand(sql, CONEXAO);
 
            CONEXAO.Open();

            //instância do leitor 
            MySqlDataReader leitor = cmd.ExecuteReader();

            //enquanto leitor lê 
            while (leitor.Read())
            {
                //para cada iteração adiciono o nome 
                //ao listbox 
                listBox1.Items.Add(leitor["ID"].ToString());
                listBox2.Items.Add(leitor["Nome"].ToString());
                listBox3.Items.Add(leitor["Senha"].ToString());
            }

            //fecha conexão 
            CONEXAO.Close();
        }*/
            private void button2_Click(object sender, EventArgs e)
        {
            string Configuracao = "server = bdmateus.mysql.dbaas.com.br; userid=bdmateus;PASSWORD= mateus1997; database=bdmateus";
            MySqlConnection CONEXAO = new MySqlConnection(Configuracao);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string IDex = txtex.Text;
            string Configuracao = "server = bdmateus.mysql.dbaas.com.br; userid=bdmateus;PASSWORD= mateus1997; database=bdmateus";
            MySqlConnection CONEXAO = new MySqlConnection(Configuracao);
            try
            {
                CONEXAO.Open();
                MySqlCommand Excluir = new MySqlCommand("DELETE FROM cadastro WHERE ID  = ('"+IDex+"')", CONEXAO);
                Excluir.ExecuteNonQuery();


                MessageBox.Show("Usuario Excluido!!");


               
            }
            catch
            {
                MessageBox.Show("Erro na Tabela, tabela não encontrada");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

