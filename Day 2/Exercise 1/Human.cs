using System;

namespace ZombieSimulator
{
  public class Human: IPerson 
   {
      public decimal DistanceTraveled{get;set;}
      public void Run(decimal minutes)
      {
           DistanceTraveled = DistanceTraveled +(minutes * 3.0M);
      }
       public void Walk(decimal minutes)
       {
         DistanceTraveled = DistanceTraveled + (minutes * 1.5M);
       } 
   }
}