Using System.Data;

namespace Day4
{
   public class StatusRespository : Respository
   {
       public List<Status> GetAll()
       {
           using (IDbConnection dbConnection = Connection)
           {
                dbConnection.Open();
                string sql= "select p.FistName, p.LastName, ps.StatusDescription"
                        + "from person p"
                        + "inner join personStatus ps"
                        + "on p.PersonStatusID = ps.PersonStatusID";
                   return dbConnection.Query<Status>(sql,commandType: CommandText.Text).ToList();
           }
       }
   }
}