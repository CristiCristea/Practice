using System.Collections.Generic;

namespace Garden_Zoo_Management.Animals
{
    class Ostrich : Animal
    {
        public Ostrich(string name, AnimalType specie, Dictionary<MovementType, int> moves) : base(name, specie, moves)
        {
        }
    }
}
