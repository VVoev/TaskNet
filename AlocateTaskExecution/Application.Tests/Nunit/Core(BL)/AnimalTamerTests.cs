using Core;
using Core.Contracts;
using Moq;
using NUnit.Framework;
using OldMackDonald.Data.Models.Abstraction;
using System;

namespace Application.Tests.Nunit.Core_BL_
{
    [TestFixture]
    public class AnimalTamerTests
    {
        private readonly string verseText = $@"Old MacDonald had a farm, E I E I O,{Environment.NewLine}
                      And on his farm he had a @animal, E I E I O.{Environment.NewLine}
                      With a @sound @sound here and a @sound @sound there,{Environment.NewLine}
                      Here a @sound, there a @sound, ev'rywhere a @sound @sound.{Environment.NewLine}
                      Old MacDonald had a farm, E I E I O.{Environment.NewLine}";

        private string animalName;
        private string animalSound;
        private Mock<IAnimalTamer<IAnimal>> verseMock;

        [SetUp]
        public void TestInitialize()
        {
            this.verseMock = new Mock<IAnimalTamer<IAnimal>>();
            this.animalName = "Dog";
            this.animalSound = "Bauf";
        }

        [TearDown]
        public void CleanUp()
        {
            this.verseMock = null;
            this.animalName = null;
            this.animalSound = null;
        }

        [Test]
        public void AllAnimalShouldBeInitialized_WhenCustomAnimalMethodIsInvoked()
        {
            //Arrange
            string managedVerse =this.verseText.Replace("@animal", this.animalName).Replace("@sound", this.animalSound);

            //Act
            string getAnimalFromBase =AnimalTamer<Animal>.MakeCustomAnimal(this.animalName, this.animalSound)
                .Replace("@animal", this.animalName)
                .Replace("@sound", this.animalSound);

            //Assert
            Assert.That(managedVerse, Is.EqualTo(getAnimalFromBase));
        }

        [Test]
        public void AllAnimalsCanBeGetten_WhenInitializedMethodIsInvoked()
        {
            //Arange && Act
            verseMock.Setup(x => x.GetAllAnimals()).Returns(verseText);
            var animalMock = verseMock.Object;

            var animal = animalMock.GetAllAnimals().Replace("@animal", this.animalName).Replace("@sound", this.animalSound);
            var defaultAnimals = AnimalTamer<Animal>.MakeCustomAnimal(animalName, animalSound)
                .Replace("@animal", this.animalName)
                .Replace("@sound", this.animalSound);

            //Assert
            Assert.That(animal, Is.EqualTo(defaultAnimals));
        }

        [Test]
        [TestCase("Lion")]
        [TestCase("Puma")]
        [TestCase("Gepard")]
        public void AnimalShouldNotBePartOfTheList_WhenIsNotActuallyExisting(string newAnimal)
        {
            //Arange
            var animalTamer = new AnimalTamer<Animal>();
            verseMock.Setup(x => x.GetAllAnimals()).Returns(verseText);

            //Act
            string allAnimals = verseMock.Object.GetAllAnimals()
                .Replace("@animal", this.animalName)
                .Replace("@sound", this.animalSound);
            var isContaining = allAnimals.IndexOf(newAnimal);

            //Assert
            Assert.Less(isContaining,0);
        }

        [Test]
        [TestCase("Dog","Bauf")]
        public void AnimalShouldBePartOfTheList_WhenTheyActuallyExist(string newAnimal,string sound)
        {
            //Arange
            var animalTamer = new AnimalTamer<Animal>();
            verseMock.Setup(x => x.GetAllAnimals()).Returns(verseText);

            //Act
            string allAnimals = verseMock.Object.GetAllAnimals()
                .Replace("@animal", this.animalName)
                .Replace("@sound", this.animalSound);
            var isContainingAnimal = allAnimals.Contains(newAnimal);
            var isContainingSound = allAnimals.Contains(sound);

            //Assert
            Assert.IsTrue(isContainingAnimal);
            Assert.IsTrue(isContainingSound);
        }
    }
}
