using System.Collections.Generic;

namespace Garden_Zoo_Management.Animals
{
    class Bat : Animal
    {
        public Bat(string name, AnimalType specie, Dictionary<MovementType, int> moves) : base(name, specie, moves)
        {
        }
    }
}
