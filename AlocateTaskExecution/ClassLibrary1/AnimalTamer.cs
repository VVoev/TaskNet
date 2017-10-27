using System;
using Core.Contracts;
using OldMackDonald.Data.Models.Abstraction;
using System.Text;
using OldMackDonald.Data.Models.Enums;

namespace Core
{
    public class AnimalTamer<T> : IAnimalTamer<T>
        where T : IAnimal
    {
        public string GetAllAnimals()
        {
            StringBuilder textToBeReturned = new StringBuilder();
            int animalByIntRepresantation = 0;
            this.ParseTheAnimal(animalByIntRepresantation, textToBeReturned);

            return textToBeReturned.ToString();
        }

        private void ParseTheAnimal(int animalByIntRepresantation, StringBuilder textToBeReturned)
        {
            while (true)
            {
                AnimalType type;
                if (!Enum.TryParse(animalByIntRepresantation.ToString(), false, out type))
                {
                    continue;
                }

                if (Enum.IsDefined(typeof(AnimalType), type))
                {
                    textToBeReturned.Append(AnimalCreator(type).GetCurrentAnimalNameAndSound());

                    animalByIntRepresantation++;
                }
                else
                {
                    break;
                }
            }
        }

        private static Animal AnimalCreator(AnimalType type)
        {
            Animal newAnimal = null;
            switch (type)
            {
                case AnimalType.Tiger:
                    newAnimal = Animal.AnimalFactory(type);
                    break;
                case AnimalType.Dog:
                    newAnimal = Animal.AnimalFactory(type);
                    break;
                case AnimalType.Cat:
                    newAnimal = Animal.AnimalFactory(type);
                    break;
                case AnimalType.Mouse:
                    newAnimal = Animal.AnimalFactory(type);
                    break;
                case AnimalType.Frog:
                    newAnimal = Animal.AnimalFactory(type);
                    break;
            }

            return newAnimal;
        }

        public static string MakeCustomAnimal(string animal, string sound)
        {
            return Animal.GetAnimalByInternalUse(animal, sound);
        }
    }
}