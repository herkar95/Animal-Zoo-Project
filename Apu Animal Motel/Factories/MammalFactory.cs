using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Animal_Motel
{
    public class MammalFactory
    {
        // Constructor
        public MammalFactory() { }

        // Creates and returns a mammal object of the selected animal specie 
        public static Mammal CreateMammal(MammalSpecies mammalSpecie)
        {
            Animal mammalObject;

            switch (mammalSpecie)
            {
                case MammalSpecies.Cat:
                        mammalObject = new Cat();
                        break;
                case MammalSpecies.Dog:
                        mammalObject = new Dog();
                        break;
                case MammalSpecies.Lion:
                        mammalObject = new Lion();
                        break;
                default:
                    mammalObject = null;
                    break;
            } 
            return ((Mammal)mammalObject);
        } 
    }
}
