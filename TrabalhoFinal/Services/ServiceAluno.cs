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

        public List<Aluno> BuscarAlunos()
        {
            var retorno = new List<Aluno>();
            try
            {
                using (SqlConnection sql = new SqlConnection(ConfigurationManager.ConnectionStrings["BD"].ConnectionString))
                {
                    sql.Open();

                    SqlCommand comando = new SqlCommand($"select * From Aluno", sql);

                    var reader = comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            retorno.Add(new Aluno()
                            {
                                Nome = reader["Nome"].ToString(),
                                Idade = Convert.ToInt32(reader["Idade"].ToString())
                            });
                        }
                    }

                    sql.Close();
                }

                return retorno;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}