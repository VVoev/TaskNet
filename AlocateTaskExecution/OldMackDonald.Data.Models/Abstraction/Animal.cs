using OldMackDonald.Data.Models.Enums;

namespace OldMackDonald.Data.Models.Abstraction
{
    public abstract class Animal : IAnimal
    {
        private Animal currentAnimal
        {
            get
            {
                return this;
            }
        }

        public abstract string AnimalName
        {
            get;
        }

        public abstract string AnimalSound
        {
            get;
        }

        public abstract AnimalType Type { get; }

        public string GetCurrentAnimalName()
        {
            return this.AnimalName;
        }

        public string GetCurrentAnimalSound()
        {
            return this.AnimalSound;
        }

        public string GetCurrentAnimalNameAndSound()
        {
            return this.currentAnimal.AnimalNameAndSound();
        }

        protected abstract string AnimalNameAndSound();
    }
}
