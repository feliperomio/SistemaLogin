namespace SistemaLogin
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            formLogin f = new formLogin(); //é feita uma instancia, para puxar a outra tela

            while (CadastroUsuario.UsuarioLogado == null) {
                Visible = false;
                f.ShowDialog();                 //mostra a outra tela


                if (formLogin.Cancelar ) {

                    Application.Exit();
                    return;
                }
                labelBoasVindas.Text = "Bem Vindo \n" + CadastroUsuario.UsuarioLogado.Nome;
                Visible = true;

            }
        }

    }
}
