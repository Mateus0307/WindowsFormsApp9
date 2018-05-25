using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Form1 cadastro = new Form1();
            cadastro.ShowDialog();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Tela2 consulta = new Tela2();
            consulta.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Nvsenha senha = new Nvsenha();
            senha.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cad_User cadastro = new cad_User();
            cadastro.ShowDialog();
        }

        private void btnConUser_Click(object sender, EventArgs e)
        {
            Busca campo = new Busca();
            campo.ShowDialog();
        }
    }
}
