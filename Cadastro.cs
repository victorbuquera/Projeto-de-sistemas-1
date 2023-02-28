using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_projeto
{
    public partial class Cadastro : Form
    {
        Usuario usario = new Usuario();
        public Cadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            verificaValidadeDados();

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            principal.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verificaValidadeDados();
        }

        public void verificaValidadeDados()
        {
            errorProvider1.Clear();
            bool erro = false;
            if(textBox1.Text.Trim() == "")
            {
                errorProvider1.SetError(textBox1, "Digite um login");
                erro = true;
            }
            if (textBox2.Text.Trim() == "")
            {
                errorProvider1.SetError(textBox2, "Digite a senha");
                erro = true;
            }
            
            if(erro != true)
            {
                cadastrarDados();
            }
        }
        public void cadastrarDados()
        {
            Usuario usuario = new Usuario();

            usuario.Login = textBox1.Text;
            usuario.Password = textBox2.Text;
            usuario.Situacao = comboBox1.Text;

        }
    }
}
