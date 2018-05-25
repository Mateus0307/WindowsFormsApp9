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
    public partial class Busca : Form
    {
        public Busca()
        {
            InitializeComponent();
        }
        
        private void Busca_Load(object sender, EventArgs e)
        {

         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBusca.Text = " ";
            listBox2.Text = " ";
            listBox1.Text = " ";
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string Configuracao = "server = bdmateus.mysql.dbaas.com.br; userid=bdmateus;PASSWORD= mateus1997; database = bdmateus";
            MySqlConnection CONEXAO = new MySqlConnection(Configuracao);
            try
            {

                listBox1.Items.Clear();
                listBox2.Items.Clear();


                CONEXAO.Open();
                MySqlCommand INSERT = new MySqlCommand("SELECT * FROM usuarios WHERE Nome like '" + txtBusca.Text + "'", CONEXAO);
                MySqlDataReader leitor = INSERT.ExecuteReader();

                if (leitor.HasRows)
                {
                    //enquanto lê 
                    while (leitor.Read())
                    {
                        listBox1.Items.Add(leitor["ID"].ToString());
                        listBox2.Items.Add(leitor["Nome"].ToString());

                        CONEXAO.Close();
                    }
                }
                
                else{
                    MessageBox.Show("Usuario não encontrado ");
                }
            }



            catch
            {
                MessageBox.Show("Nao conseguiu a conexao");
            }


        
    }
    }
}
