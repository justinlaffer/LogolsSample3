using System.Data;
using System.Collections.Generic;
using Dapper;
using System.Linq;


namespace Final
{
   public class StatusRepository : Repository
    {
        public IEnumerable<Member> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Member>(
                    "select m.FirstName, m.LastName, ms.MemberStatusID, ms.MemberStatusDescription, c.ClassDescription"
                    + "from Member m"
                    + "inner join MemberStatus ms"
                    + "ON m.MemberStatusID = ms.MemberStatusID"
                    + "inner join ClassMember cm"
                    + "On m.MemberId = cm.MemberID"
                    + "inner join Class c"
                    + "On c.ClassID = cm.ClassID; " 
                    , commandType: CommandType.Text);
            }
        }

        public Member Get(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Member>(
                     "select m.FirstName, m.LastName, ms.MemberStatusID, ms.MemberStatusDescription, c.ClassDescription"
                    + "from Member m"
                    + "inner join MemberStatus ms"
                    + "ON m.MemberStatusID = ms.MemberStatusID"
                    + "inner join ClassMember cm"
                    + "On m.MemberId = cm.MemberID"
                    + "inner join Class c"
                    + "On c.ClassID = cm.ClassID; " 
                    , commandType: CommandType.Text).FirstOrDefault();
            }
        }

       
    }
}

