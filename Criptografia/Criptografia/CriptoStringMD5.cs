using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Criptografia
{
    internal class CriptoStringMD5
    {
        //Recebe a senha
        public string RetornarMD5(string senha){
            using (MD5 md5Hash = MD5.Create())
            {
                //chama o método para criptografização
                return RetornarHash(md5Hash, senha);
            }
        }

        public bool CompararMD5(string senhaDigitada, string senhaMD5)
        {
            string senha = RetornarMD5(senhaDigitada);
            if(VerificarHash(senhaMD5, senha))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        //Criptografa
        private string RetornarHash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            //Faz o stringbuilder para criação da senha criptografada, percorrendo cada byte da senha
            StringBuilder sBuilder = new StringBuilder();

            for(int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("X2"));
            }

            return sBuilder.ToString();
        }

        //Comparar as hashs
        private bool VerificarHash(string input, string hash)
        {
            StringComparer comparar = StringComparer.OrdinalIgnoreCase;
            //Retorna 0 quando são iguais
            if(comparar.Compare(input, hash) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
