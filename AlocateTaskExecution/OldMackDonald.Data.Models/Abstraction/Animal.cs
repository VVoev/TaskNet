using System;
using OldMackDonald.Data.Models.Enums;
using OldMackDonald.Data.Models.Models;
using OldMackDonald.Data.Models.Providers;
using System.Text;

namespace OldMackDonald.Data.Models.Abstraction
{
    public abstract class Animal : IAnimal
    {
        private Animal CurrentAnimal
        {
            get
            {
                return this;
            }
        }

        public abstract string AnimalName { get; }

        public abstract string AnimalSound { get; }

        public abstract AnimalType Type { get; }

        public string GetCurrentAnimalName()
        {
            return this.AnimalName;
        }

        public string GetCurrentAnimalSound()
        {
            return this.AnimalSound;
        }

        public StringBuilder Verse
        {
            get
            {
                return Providers.Verse.ReturnDefaultVerse();
            }
        }

        protected abstract string AnimalNameAndSound();

        private string GetUserAnimalByNameAndSound(string name, string sound)
        {
            return Providers.Verse.ReturnDefaultVerse()
                    .Replace("@animal", name)
                    .Replace("@sound", sound)
                    .ToString();
        }

        private static string GetNewCustomAnimalByNameAndSound(string animal, string sound)
        {
            return Providers.Verse.ReturnDefaultVerse().Replace("@animal", animal)
                    .Replace("@sound", sound)
                    .ToString();
        }

        public string GetCurrentAnimalNameAndSound()
        {
            return this.CurrentAnimal.AnimalNameAndSound();
        }

        public static string GetAnimalByInternalUse(string animal, string sound)
        {
            return GetNewCustomAnimalByNameAndSound(animal, sound);
        }

        public static Animal AnimalFactory(AnimalType animalAsEnum)
        {
            Animal animal = null;

            switch (animalAsEnum)
            {
                case AnimalType.Cat:
                    animal = new Cat();
                    break;
                case AnimalType.Dog:
                    animal = new Dog();
                    break;
                case AnimalType.Mouse:
                    animal = new Mouse();
                    break;
                case AnimalType.Frog:
                    animal = new Frog();
                    break;
                case AnimalType.Tiger:
                    animal = new Tiger();
                    break;
                default:
                    break;
            }

            return animal;
        }

        public string GetAnimalByUserInput(string name, string sound)
        {
            return this.GetUserAnimalByNameAndSound(name, sound);
        }
    }
}
