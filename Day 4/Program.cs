using System;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
          StatusRespository respository = new StatusRespository();
          List<Status> status = respository.GetAll();

          foreach(Status status in statuses)
          {
              Console.WriteLine(status.FirstName + " " + 
              status.LastName + "has status" + 
              status.Status.Description);
          }
        }
    }
}
