using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Animal_Motel
{
    [Serializable]
    public abstract class Mammal : Animal
    {
        // Properties
        public int Teeth { get; set; }

        // Returns the category specific attribute as a string
        public string getCategorySpecificData()
        {
            return "Has " + Teeth + " teeth. ";
        }
    }
}
