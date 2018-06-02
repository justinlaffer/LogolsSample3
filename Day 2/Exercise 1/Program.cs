using System;
using System.Collections.Generic;

namespace ZombieSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPerson>people = new List <IPerson>();
            people.Add(new Human());
            people.Add(new Zombie());
            people.Add(new Human());

            foreach(IPerson person in people) 
            {
              person.Walk(5);
              Console.WriteLine(person.DistanceTraveled);
            }
           /* 
            Human Justin= new Human();
            Zombie Sam= new Zombie();
            Justin.Run(3.0M);
            Sam.Walk(3.0M);
            Justin.Walk(4.0M);
            Sam.Run(4.0M);
            Console.WriteLine("")
            */
        }
    }
}