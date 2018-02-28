using System;
using System.Collections.Generic;
using Garden_Zoo_Management.Animals;

namespace Garden_Zoo_Management
{
    public class Statistics
    {
        public void PrintFlyingAnimals(List<IAnimal> animlas)
        {
            Console.WriteLine("Animale ce pot zbura: ");

            foreach (var animal in animlas)
            {
                if (animal.Moves.ContainsKey(MovementType.Fly))
                {
                    Console.Write("\tCategoria=" + animal.Specie + "\t Nume=" + animal.Name + "\t Viteza maxima in zbor=" + animal.Moves[MovementType.Fly] + "\n");
                }
            }
            Console.WriteLine();
        }

        public void PrintFastestAndSlowestWlaker(List<IAnimal> animlas)
        {
            IAnimal fastetAnimal = null;
            IAnimal slowestAnimal = null;
            int maxSpeed = Int32.MinValue;
            int minSpeed = Int32.MaxValue;
            foreach (var animal in animlas)
            {
                if (animal.Moves.ContainsKey(MovementType.Walk))
                {
                    if (maxSpeed < animal.Moves[MovementType.Walk])
                    {
                        maxSpeed = animal.Moves[MovementType.Walk];
                        fastetAnimal = animal;
                    }
                    if (minSpeed > animal.Moves[MovementType.Walk])
                    {
                        minSpeed = animal.Moves[MovementType.Walk];
                        slowestAnimal = animal;
                    }
                }
            }
            Console.Write("Cel mai rapid animal umblator este \n\tdin Categoria=" + fastetAnimal.Specie + "\t Nume=" + fastetAnimal.Name + "\t Viteza maxima in alergare=" + fastetAnimal.Moves[MovementType.Walk] + "\n");
            Console.Write("Cel mai incet animal umblator este \n\tdin Categoria=" + slowestAnimal.Specie + "\t Nume=" + slowestAnimal.Name + "\t Viteza maxima in alergare=" + slowestAnimal.Moves[MovementType.Walk] + "\n");
            Console.WriteLine();
        }
    }
}