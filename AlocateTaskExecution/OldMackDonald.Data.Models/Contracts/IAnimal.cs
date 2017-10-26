using OldMackDonald.Data.Models.Enums;

namespace OldMackDonald.Data.Models.Abstraction
{
    public interface IAnimal
    {
        string AnimalName { get; }

        string AnimalSound { get; }

        AnimalType Type { get; }

        string GetCurrentAnimalName();

        string GetCurrentAnimalNameAndSound();

        string GetCurrentAnimalSound();
    }
}