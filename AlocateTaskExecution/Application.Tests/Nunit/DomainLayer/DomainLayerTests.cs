using Core;
using NUnit.Framework;
using OldMackDonald.Data.Models.Abstraction;
using OldMackDonald.Data.Models.Enums;
using OldMackDonald.Data.Models.Models;

namespace Application.Tests.Nunit.DomainLayer
{
    [TestFixture]
    class DomainLayerTests
    {
        private Dog dog;
        private Cat cat;
        private Frog frog;
        private Mouse mouse;
        private Tiger tiger;


        [SetUp]
        public void testInitialize()
        {
            this.dog = new Dog();
            this.cat = new Cat();
            this.frog = new Frog();
            this.mouse = new Mouse();
            this.tiger = new Tiger();
        }

        [Test]
        public void ConstructorSuccesfullyCreatedTheObjects_WhenIsCalled()
        {
            var dog = new Dog();

            Assert.That(AnimalType.Dog, Is.EqualTo(dog.Type));
            Assert.That("Dog", Is.EqualTo(dog.AnimalName));
            Assert.That("Bauf", Is.EqualTo(dog.AnimalSound));
        }

        [Test]
        public void AnimalTamerCanGetASpecifikAnimalWithItsSound_WhenGeTallAnimalsIsInvoked()
        {
            var dog = new Dog();
            var animalTamer = new AnimalTamer<Animal>();

            Assert.That(animalTamer.GetAllAnimals(),
                Contains.Substring(this.dog.GetCurrentAnimalNameAndSound()));
        }

        [Test]
        public void CheckIfAClassIdDerivedFromItsBaseClass()
        {
            var dog = new Dog();

            bool isDerived = typeof(Animal).IsAssignableFrom(typeof(Dog));

            Assert.IsTrue(isDerived);
        }
    }
}
