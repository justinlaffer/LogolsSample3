using System;

namespace ZombieSimulator
{
  public abstract class Person
    {  
        public decimal DistanceTraveled{get;set;}
        
        public Person()
        {
         Console.WriteLine("new person created");
        }
      public virtual void Walk(decimal minutes)
        {
            DistanceTraveled = DistanceTraveled + (minutes * 1.5M);
        }
        public int CalculateDistance(int minutes)
        {
          return minutes*2;
        }
    }
}

