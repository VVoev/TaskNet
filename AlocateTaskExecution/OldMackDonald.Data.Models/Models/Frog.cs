using System;
using OldMackDonald.Data.Models.Abstraction;
using OldMackDonald.Data.Models.Enums;

namespace OldMackDonald.Data.Models.Models
{
    public class Frog : Animal
    {
        public override string AnimalName
        {
            get
            {
                return "Frog";
            }
        }

        public override string AnimalSound
        {
            get
            {
                return "Kwack";
            }
        }

        public override AnimalType Type
        {
            get
            {
                return AnimalType.Frog;
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
