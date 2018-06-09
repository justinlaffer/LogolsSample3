using System;

namespace Day_1
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("A status report is needed of all government employees");
      int counter=0;
      int[] statuses = {1,2,3,4};
      string[]names= {"Justin","Adam","Elliott","Jeremey"};

      for(counter = 0; counter < statuses.Length; counter++)
      {
        Console.WriteLine(GetStatus(statuses[counter]));
      }
    }

    private static string GetStatus(int status)
    {
        if (status == 1)
        {
          return "Status:Alive";
        }
        else if(status == 2)
        {
          return "Status:Zombie"; 
        }
        else if(status == 3)
        {
          return "Status:Dead";
        }
        else
        {
          return "Status:Unknown";
        }
    }
  }
}
/* 
  counter = 0;
while(counter<statuses.Length)
{Console.WriteLine(names[counter]);counter++;
}

 counter = 0;
do
{
   Console.WriteLine(names[counter]);counter++;
} while (counter < statuses.Length);
     
switch (statuses[counter])
{
case 1:
Console.WriteLine("Alive");
break;
case 2:
Console.WriteLine("Zombie");
break;
case 3:
Console.WriteLine("Dead");
break;
case 4:
Console.WriteLine("Unknown");
break;
} 

{
  List<Statuses> Statuses = new List<Statuses>();
statusesList.Add(Justin());
statusesList.Add(Adam());
statusesList.Add(Jeremy());
}

}
}
}
*/


