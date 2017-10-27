using OldMackDonald.Data.Models.Abstraction;

namespace Core.Contracts
{
    public interface IAnimalTamer<T>
        where T : IAnimal
    {
        string GetAllAnimals();
    }
}
