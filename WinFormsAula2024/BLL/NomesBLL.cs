using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using WinFormsAula2024.DAL;
using WinFormsAula2024.DTO;

namespace WinFormsAula2024.BLL
{
    internal class NomesBLL
    {
        public int CadastrarDados(NomesDTO objetoNomes)
        {
            int retornoDeSucesso = 1;
            int retornoDeFalha = 0;

            // VALIDAÇAO
            if (objetoNomes == null || objetoNomes.Nome == null || objetoNomes.Nome.Equals(""))
            {
                return retornoDeFalha;
            }

            if (objetoNomes == null || objetoNomes.Email == null || objetoNomes.Email.Equals(""))
            {
                return retornoDeFalha;
            }

            if (objetoNomes == null || objetoNomes.Telefone == null || objetoNomes.Telefone.Equals(""))
            {
                return retornoDeFalha;
            }

            NomesDAL nomesDAL = new NomesDAL();
            bool retorno = nomesDAL.CadastrarDados(objetoNomes);
            if (!retorno)
            {
                return retornoDeFalha;
            }

            return retornoDeSucesso;
        }

    }
}
