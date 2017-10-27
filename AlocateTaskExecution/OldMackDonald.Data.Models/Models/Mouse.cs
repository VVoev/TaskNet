using OldMackDonald.Data.Models.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OldMackDonald.Data.Models.Enums;

namespace OldMackDonald.Data.Models.Models
{
    public class Mouse : Animal
    {
        public override string AnimalName
        {
            get
            {
                return "Mouse";
            }
        }

        public override string AnimalSound
        {
            get
            {
                return "Tzur";
            }
        }

        public override AnimalType Type
        {
            get
            {
                return AnimalType.Mouse;
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
