using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAula2024.DTO;

namespace WinFormsAula2024.DAL
{
    internal class NomesDAL
    {
        public bool CadastrarDados(NomesDTO objetoNomes) 
        {
            SqlConnection? conexao = null;
            SqlCommand? comando = null;
            try
            {
                conexao = Conecxao.GetConnection();

                if(conexao.State == ConnectionState.Open)
                {
                    string declaracao = $"INSERT INTO nomes (nome, email, telefone) VALUES ('{objetoNomes.Nome}', '{objetoNomes.Email}', '{objetoNomes.Telefone}');";
                    comando = new SqlCommand(declaracao, conexao);
                    comando.ExecuteNonQuery();
                    

                }
            }
            catch(Exception ex)
            {
                return false;
            }
            finally
            {
                comando.Dispose();
                conexao.Close();
            }
            return true;
        }
    }
}
