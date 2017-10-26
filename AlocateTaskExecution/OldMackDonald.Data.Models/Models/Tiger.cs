using OldMackDonald.Data.Models.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OldMackDonald.Data.Models.Enums;

namespace OldMackDonald.Data.Models.Models
{
    class Tiger : Animal
    {
        public override string AnimalName
        {
            get
            {
                return "Tiger";
            }
        }

        public override string AnimalSound
        {
            get
            {
                return "YAaaaaaaaaaauuw";
            }
        }

        public override AnimalType Type
        {
            get
            {
                return AnimalType.Tiger;
            }
        }

        protected override string AnimalNameAndSound()
        {
            return $"i am {this.AnimalName} and i can make {this.AnimalSound}";
        }
    }
}
