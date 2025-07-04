using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLogin {
    public partial class formLogin : Form {

        public static bool Cancelar = false;


        public formLogin() {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void btnSenha_Click(object sender, EventArgs e) {
            string nome = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (CadastroUsuario.Login(nome, senha)) {
                this.Close();
            }
            else {
                MessageBox.Show("Acesso Negado");
                txtUsuario.Text = ""; //utilizado as "" para limpar os campos
                txtSenha.Text = "";
                txtUsuario.Focus();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            Cancelar = true;    
            this.Close();


        }
    }
}
