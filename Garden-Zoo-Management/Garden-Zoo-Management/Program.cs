using System;
using System.Collections.Generic;
using Garden_Zoo_Management.Animals;
using Garden_Zoo_Management.ZooGardenManagement;

namespace Garden_Zoo_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make a instance of ZooGraden
            // Add animals into Zoogarden
            // See some statistics about animals in this garden
            ZooGarden zooGardenIasi = new ZooGarden("Iasi");
            zooGardenIasi.AddAnimal(CreateSut());
            Console.WriteLine(zooGardenIasi);
            new Statistics().PrintFastestAndSlowestWlaker(zooGardenIasi.GetAnimals());
            new Statistics().PrintFlyingAnimals(zooGardenIasi.GetAnimals());

            //Prepare antoher instace of ZooGarden, populate with animals and prepare to transfer to Zoogarden of IASI
            ZooGarden zooGardenBacau = new ZooGarden("Bacau");
            zooGardenBacau.AddAnimal(CreateSut());
            Console.WriteLine(zooGardenBacau);
            
            //Make Transfer
            TransferAnimals transfer = new TransferAnimals();
            transfer.TransferAnimalToZoo(zooGardenBacau, zooGardenIasi);

            //Print the result of transfer
            Console.WriteLine(zooGardenBacau);
            Console.WriteLine(zooGardenIasi);
        }

        static List<IAnimal> CreateSut()
        {
            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(new Cat("Pisica-Tom", AnimalType.Mammalian, new Dictionary<MovementType, int> { { MovementType.Walk, 20 } }));
            animals.Add(new DuckBill("Ornitorincul0-Jack", AnimalType.Mammalian, new Dictionary<MovementType, int> { { MovementType.Walk, 25 }, { MovementType.Swimm, 10 } }));
            animals.Add(new WildDuck("Rata-Salbatica-Jonny", AnimalType.Bird, new Dictionary<MovementType, int> { { MovementType.Swimm, 15 }, { MovementType.Walk, 20 }, { MovementType.Fly, 25 } }));
            animals.Add(new Bat("Liliacul-BatMan", AnimalType.Mammalian, new Dictionary<MovementType, int> { { MovementType.Fly, 35 } }));
            animals.Add(new Ostrich("Strutul-boby", AnimalType.Bird, new Dictionary<MovementType, int> { { MovementType.Walk, 55 } }));
            return animals;
        }
    }
}
