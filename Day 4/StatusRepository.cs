using System.Data;
using System.Collections.Generic;
using Dapper;
using System.Linq;


namespace Day4
{
   public class StatusRepository: Repository
   {
       public List<Status> GetAll()
       {
           using (IDbConnection dbConnection = Connection)
           {
                dbConnection.Open();
                string sql= "select p.FirstName, p.LastName, ps.StatusDescription "
                        + "from person p "
                        + "inner join personStatus ps "
                        + "on p.PersonStatusID = ps.PersonStatusID";
                  return dbConnection.Query<Status>(sql
                  , commandType: CommandType.Text).ToList();
           }
       }
   }
}