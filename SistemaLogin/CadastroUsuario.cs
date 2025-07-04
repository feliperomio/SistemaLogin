using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin {
    internal class CadastroUsuario {
        //              tipo do array[] nome do array
        private static Usuario[] usuarios =
            {
                new Usuario(){Nome = "Felipe", Senha = "1234"},
                new Usuario(){Nome = "Analice", Senha = "root"}
            };

        private static Usuario UserLogado = null;

        public static Usuario UsuarioLogado {
            get { return UserLogado; }
            private set { UserLogado = value; }
        }
        public static bool Login(string nome, string senha)          //verificação para ver se existe esse usuario 
            {  

            foreach (Usuario usuario in usuarios) 
                {
               if(usuario.Nome == nome && usuario.Senha == senha) 
                    {
                    UsuarioLogado = usuario;   
                    return true;
                    }
                }
            return false;
            }

    }  
}
