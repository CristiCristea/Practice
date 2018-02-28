using System.Collections.Generic;

namespace Garden_Zoo_Management.Animals
{
    class Cat : Animal
    {
        public Cat(string name, AnimalType specie, Dictionary<MovementType, int> moves) : base(name, specie, moves)
        {
        }
    }
}
