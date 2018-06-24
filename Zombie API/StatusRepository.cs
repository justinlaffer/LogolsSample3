using System.Data;
using System.Collections.Generic;
using Dapper;
using System.Linq;


namespace Zombie_API
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
        public void Insert(Status status)
        {
            using (IDbConnection dbConnection = Connection)
           {
                dbConnection.Open();
                dbConnection.Execute(
               "insert into person(FirstName,LastName)"
                + "values(@Firstname, @Lastname);"
                ,new {
                  FirstName = status.FirstName,
                  LastName = status.LastName
                }
                  , commandType: CommandType.Text);
           }
       } 
        public void Update(Status status)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "update Person"
                    + "set FirstName = @FirstName, LastName = @LastName, StatusDescription= @StatusDesciption "
                    + "where PersonStatusId = @PersonStatusId;"
                    ,new {
                        StatusDescription= status.StatusDescription,
                        FirstName = status.FirstName,
                        LastName = status.LastName,
                        PersonStatusId = status.PersonStatusId
                    } 
                    ,commandType: CommandType.Text);
                  }
        

         Public void Delete(int id)
        {
          using (IDbConnection dbConnection = Connection)
          {
              dbConnection.Open();
              dbConnection.Execute(
           
          
        
        
        
    }

   }
}

