using LivrariaSystem.views.cadastro;

namespace LivrariaSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void lIvroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroLivro childForm = new CadastroLivro();
            childForm.MdiParent = this; // Define o formulário pai
            childForm.Show();
        }

        private void leitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroLeitor childForm = new CadastroLeitor();
            childForm.MdiParent = this; // Define o formulário pai
            childForm.Show();
        }

        private void alugarLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
