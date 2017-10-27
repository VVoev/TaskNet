using Core;
using Core.Contracts;
using Ninject;
using OldMackDonald.Data.Models.Abstraction;

namespace ContainerConfiguration
{
    public static class Configuration
    {
        public static void InitialConfig(IKernel kernel)
        {
            kernel.Bind<IAnimalTamer<Animal>>().To<AnimalTamer<Animal>>().InSingletonScope();

            // As much models as is needed for DI
            kernel.Bind<IAnimal>().To<Animal>();
        }
    }
}
