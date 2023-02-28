namespace Cadastro_projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cadastrarBtn_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
            this.Hide();
        }

        private void cadastroBtn_Click(object sender, EventArgs e)
        {
            Exibicao exibicao = new Exibicao();
            exibicao.Show();
            this.Hide();
        }
    }
}