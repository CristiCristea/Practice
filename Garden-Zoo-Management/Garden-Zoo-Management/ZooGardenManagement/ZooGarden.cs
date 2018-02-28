using System.Collections.Generic;
using System.Linq;
using Garden_Zoo_Management.Animals;

namespace Garden_Zoo_Management.ZooGardenManagement
{
    public class ZooGarden 
    {
        public string Name { get; }
        private List<IAnimal> animalsAtZoo;

        public ZooGarden(string name)
        {
            Name = name;
            animalsAtZoo = new List<IAnimal>();
        }

        public void AddAnimal(IAnimal animal)
        {
            animalsAtZoo.Add(animal);
        }

        public void AddAnimal(List<IAnimal> animals)
        {
            animalsAtZoo.AddRange(animals);
        }

        public void RemoveAnimal(IAnimal animal)
        {
            animalsAtZoo.Remove(animal);
        }

        public void RemoveAnimal(List<IAnimal> animal)
        {
            animalsAtZoo = animalsAtZoo.Except(animal).ToList();
        }

        public void RemoveAnimal()
        {
            animalsAtZoo.Clear();
        }

        public List<IAnimal> GetAnimals()
        {
            return animalsAtZoo;
        }

        public override string ToString()
        {
            string result = "Numele gradinei zoologice este " + Name + "\n Si avem urmatoarele specii de animale: \n";

            foreach (var animal in animalsAtZoo)
            {
                result += "\t" + animal.Specie + " cu numele: " + animal.Name + "\n";
            }
            return result;
        }
    }
}