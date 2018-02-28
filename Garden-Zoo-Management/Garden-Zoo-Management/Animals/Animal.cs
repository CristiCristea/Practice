using System;
using System.Collections.Generic;

namespace Garden_Zoo_Management.Animals
{
    public  class Animal : IAnimal
    {
        public AnimalType Specie { get; protected set; }

        public Dictionary<MovementType, int> Moves { get; protected set; }

        public string Name { get; protected set; }

        public Animal(string name, AnimalType specie, Dictionary<MovementType, int> moves)
        {
            Name = name;
            Specie = specie;
            Moves = moves;
        }
        
        public virtual void Move()
        {
            foreach (var move in Moves)
            {
                Console.WriteLine("I can " + move.Key + " with speed=" + move.Value);
            }
        }

        public virtual void Eat()
        {
            //To Do
        }
    }
}