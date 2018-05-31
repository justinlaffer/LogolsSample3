using System;

namespace ZombieSimulator
{
  public class Person
    {  
        public int DistanceTraveled{get;set;}
        
        public Person()
        {
         Console.WriteLine("new person created");
        }
      public void Walk(int minutes)
        {
            DistanceTraveled = DistanceTraveled + minutes;
        }
        public int CalculateDistance(int minutes)
        {
          return minutes*2;
        }
    }
}

