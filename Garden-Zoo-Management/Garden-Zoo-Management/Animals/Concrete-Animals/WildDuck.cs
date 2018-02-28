using System.Collections.Generic;

namespace Garden_Zoo_Management.Animals
{
    public class WildDuck : Animal
    {
        public WildDuck(string name, AnimalType specie, Dictionary<MovementType, int> moves) : base(name, specie, moves)
        {
        }
    }
}