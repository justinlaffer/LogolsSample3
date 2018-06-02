using System;

namespace ZombieSimulator
{
    public interface IPerson
    {
        decimal DistanceTraveled {get;set;}
        void Walk(decimal minutes);
     
    }
}