using OldMackDonald.Data.Models.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OldMackDonald.Data.Models.Enums;

namespace OldMackDonald.Data.Models.Models
{
    class Dog : Animal
    {
        public override string AnimalName
        {
            get
            {
                return "Dog";
            }
        }

        public override string AnimalSound
        {
            get
            {
                return "bauf";
            }
        }

        public override AnimalType Type
        {
            get
            {
                return AnimalType.Dog;
            }
        }

        protected override string AnimalNameAndSound()
        {
            throw new NotImplementedException();
        }
    }
}
