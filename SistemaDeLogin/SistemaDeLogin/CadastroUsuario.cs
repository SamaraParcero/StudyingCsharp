using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeLogin
{
    static class CadastroUsuario
    {
        private static Usuario[] usuarios =
        {
            new Usuario(){ Nome = "Wilson", Senha = "abc123"},
            new Usuario(){ Nome = "Samara", Senha = "abc1234"},
            new Usuario(){ Nome = "Pedro", Senha = "abc12345"}
        };

        private static Usuario userLogado = null;

        public static Usuario UsuarioLogado 
        { 
            get { return userLogado; } 
            private set { userLogado = value; }
        }

        public static bool Logar(string nome, string senha)
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
