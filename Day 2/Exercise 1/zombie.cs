using System;

namespace ZombieSimulator
{
  public sealed class Zombie : Person
    {
        public override void Walk(int minutes)
        { 
            DistanceTraveled = DistanceTraveled + minutes;
        }
    }
}


    
