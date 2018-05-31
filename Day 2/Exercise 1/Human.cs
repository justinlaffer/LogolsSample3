using System;

namespace ZombieSimulator
{
  public sealed class Human: Person 
   {
       
      public void Run(int minutes)
      {
         DistanceTraveled = DistanceTraveled * minutes;
      }
       
   }
}