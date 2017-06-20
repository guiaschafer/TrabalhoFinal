using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TrabalhoFinal.Models;

namespace TrabalhoFinal.Services
{
    public class ServiceAluno
    {
        public void CadastrarAluno(Aluno model)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(ConfigurationManager.ConnectionStrings["BD"].ConnectionString))
                {
                    sql.Open();

                    SqlCommand comando = new SqlCommand($"INSERT INTO ALUNO VALUES('{model.Nome}',{model.Idade})", sql);

                    var reader = comando.ExecuteNonQuery();

                    sql.Close();
                }
          
            }
            catch (Exception e)
            {
              throw new Exception(e.Message);
            }
        }
    }
}