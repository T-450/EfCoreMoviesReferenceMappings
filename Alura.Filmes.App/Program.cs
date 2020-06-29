using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Extensions;
using static System.Console;
using System;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace Alura.Filmes.App
{
    class Program
    {
        static string query = @"select distinct top(5) a.first_name, a.last_name, count(*) as total
	                    from [dbo].actor as a
		                inner join [dbo].film_actor as fa on fa.actor_id = a.actor_id
                        group by a.first_name, a.last_name
                        order by total desc;";
        static string atoresMaisAtuantesSql = @"select a.*
                                                from actor a
	                                                inner join
                                                (select top(5) a.actor_id, count(*) as total
                                                from actor a
	                                                inner join [dbo].film_actor fa on fa.actor_id = a.actor_id
                                                group by a.actor_id
                                                order by total desc) filmes on filmes.actor_id = a.actor_id
                                                ";
        static void Main(string[] args)
        {
            using (var contexto = new AluraFilmesContexto())
            {
                contexto.LogSQLToConsole();

                var categ = "Action";
                var paramCateg = new SqlParameter("category_name", categ);
                var paramTotal = new SqlParameter
                {
                    ParameterName = "@total_actors",
                    Size=4,
                    Direction = System.Data.ParameterDirection.Output
                };
                var result = contexto.Database.ExecuteSqlCommand($@"total_actors_from_given_category @category_name, @total_actors OUT",
                    paramCateg,
                    paramTotal);
                WriteLine($"O total de atores na categoria {categ} é de {paramTotal.Value}");
                

                //contexto.SaveChanges();
                ReadKey();
            }
        }
    }
}
