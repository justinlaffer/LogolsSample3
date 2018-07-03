using System.Data;
using System.Collections.Generic;
using Dapper;
using System.Linq;


namespace Zombie_API
{
   public class StatusRepository : repository
    {
        public IEnumerable<Status> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Status>(
                    "select p.PersonId, p.FirstName, p.LastName, p.PersonStatusId, ps.StatusDescription"
                    + " from Person p inner join PersonStatus ps on p.PersonStatusId = ps.PersonStatusId;"
                    , commandType: CommandType.Text);
            }
        }

        public Status Get(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Status>(
                    "select PersonId, FirstName, LastName, PersonStatusId "
                    + "from Person "
                    + "where PersonId = @PersonId;"
                    ,new {PersonId = id} ,commandType: CommandType.Text).FirstOrDefault();
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "delete "
                    + "from Person "
                    + "where PersonId = @PersonId;"
                    ,new {PersonId = id} ,commandType: CommandType.Text);
            }
        }

        public void Update(Status Status)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "update Person "
                    + "set FirstName = @FirstName, LastName = @LastName, PersonStatusId = @PersonStatusId "
                    + "where PersonId = @PersonId;"
                    ,new {
                        PersonId = Status.PersonId, 
                        FirstName = Status.FirstName,
                        LastName = Status.LastName,
                        PersonStatusId = Status.PersonStatusId
                    } 
                    ,commandType: CommandType.Text);
            }
        }

        public void Insert(Status Status)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "insert into Person(FirstName, LastName, PersonStatusId) "
                    + "values(@FirstName, @LastName, @PersonStatusId);"
                    ,new { 
                        FirstName = Status.FirstName,
                        LastName = Status.LastName,
                        PersonStatusId = Status.PersonStatusId
                    } 
                    ,commandType: CommandType.Text);
            }
        }
    }
}

