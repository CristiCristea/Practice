using System.Collections.Generic;

namespace Garden_Zoo_Management.Animals
{
    public interface IAnimal
    {
        AnimalType Specie { get; }
        Dictionary<MovementType, int> Moves { get; }
        string Name { get; }
        void Move();
        void Eat();
    }
}