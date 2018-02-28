using System.Collections.Generic;
using Garden_Zoo_Management.Animals;

namespace Garden_Zoo_Management.ZooGardenManagement
{
    public class TransferAnimals
    {
        public void TransferAnimalToZoo(IAnimal animal, ZooGarden sourceGarden, ZooGarden destinationGardenGarden)
        {
            sourceGarden.RemoveAnimal(animal);
            destinationGardenGarden.AddAnimal(animal);
        }

        public void TransferAnimalToZoo(List<IAnimal> animals, ZooGarden sourceGarden, ZooGarden destinationGardenGarden)
        {
            sourceGarden.RemoveAnimal(animals);
            destinationGardenGarden.AddAnimal(animals);
        }

        public void TransferAnimalToZoo(ZooGarden sourceGarden, ZooGarden destinationGardenGarden)
        {
            destinationGardenGarden.AddAnimal(sourceGarden.GetAnimals());
            sourceGarden.RemoveAnimal();
        }

    }
}
