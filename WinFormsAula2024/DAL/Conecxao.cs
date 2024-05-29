using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAula2024.DAL
{
    internal class Conecxao
    {
        public static SqlConnection GetConnection()
        {
            

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {
                ConnectionString = "Server=localhost;Database=treino;Trusted_Connection=True;MultipleActiveResultSets=true;Integrated Security=false;User ID=sa;Password=12345678;Encrypt=False"
            };


            SqlConnection? conexao = null; 
            try
            {
                conexao = new SqlConnection(builder.ConnectionString);
                conexao.Open();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return conexao;
        }
    }
}
