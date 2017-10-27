using System;
using OldMackDonald.Data.Models.Abstraction;
using OldMackDonald.Data.Models.Enums;

namespace OldMackDonald.Data.Models.Models
{
    public class Cat : Animal
    {
        public override string AnimalName
        {
            get
            {
                return "Cat";
            }
        }

        public override string AnimalSound
        {
            get
            {
                return "Meow";
            }
        }

        public override AnimalType Type
        {
            get
            {
                return AnimalType.Cat;
            }
        }

        protected override string AnimalNameAndSound()
        {
            return
              this.Verse
                  .Replace("@animal", this.AnimalName)
                  .Replace("@sound", this.AnimalSound)
                  .ToString();
        }
    }
}
