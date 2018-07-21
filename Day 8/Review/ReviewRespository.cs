using System.Data;
using System.Collections.Generic;
using Dapper;
using System.Linq;

namespace Day_8
{
    public class ReviewController : repository
    {
        public IEnumerable<Status>GetAll()
        {
          using (IDbConnection dbConnection= Connection)
          {
               dbConnection.Open();
                return dbConnection.Query<Status>(
                "select  p.FirstName,p.LastName,ps.PersonStatusID,ps.StatusDescription"
                 + "from Person p inner join PersonStatus ps on p.PersonStatusID = ps.PersonStatusID;"
                , commandType: CommandType.Text);
          }
        }
    }         
}         
             
         
         

      
