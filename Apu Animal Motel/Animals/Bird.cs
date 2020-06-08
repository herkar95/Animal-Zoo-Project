using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Animal_Motel
{
    [Serializable]
    public abstract class Bird : Animal
    {
        // Properties
        public int FlyingSpeed { get; set; }

        // Returns the category specific attribute as a string
        public string getCategorySpecificData()
        {
            return "Flies at " + FlyingSpeed + " mph. ";
        }

    }
}
