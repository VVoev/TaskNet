using ContainerConfiguration;
using Core;
using Ninject;
using OldMackDonald.Data.Models.Abstraction;
using System;
using System.Collections.Generic;

namespace App
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            StandardKernel kernel = InitializeNinject();
            AnimalTamer<Animal> manager = kernel.Get<AnimalTamer<Animal>>();
            Console.Write(manager.GetAllAnimals());

            SeparateTheTwoVerces();

            var newAnimals = InitializeCustomAnnimals();
            MakeSongWithNewAnimals(newAnimals);
        }

        private static void SeparateTheTwoVerces()
        {
            int space = 10;
            for (int i = 0; i < space; i++)
            {
                if (i == space / 2)
                {
                    Console.WriteLine("-------------------------------New Song Start From Below-------------------------------");
                }

                Console.WriteLine();
            }
        }

        private static void MakeSongWithNewAnimals(Dictionary<string, string> newAnimals)
        {
            foreach (var animal in newAnimals)
            {
                Console.WriteLine(AnimalTamer<Animal>.MakeCustomAnimal(animal.Key, animal.Value));
            }
        }

        private static Dictionary<string, string> InitializeCustomAnnimals()
        {
            var moreAnimals = new Dictionary<string, string>
            {
                {
                 "Raven",
                 "Gaa"
                },
                {
                    "Owl",
                    "Buhu"
                },
                {
                    "Parrot",
                    "Pipii"
                },
                {
                    "Turkey",
                    "Kluuu"
                }
            };

            return moreAnimals;
        }

        private static StandardKernel InitializeNinject()
        {
            StandardKernel kernel = new StandardKernel();
            Configuration.InitialConfig(kernel);
            return kernel;
        }
    }
}
