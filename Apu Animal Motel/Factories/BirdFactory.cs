using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Animal_Motel
{
    public class BirdFactory
    {
        // Constructor
        public BirdFactory() { }

        // Creates and returns a bird object of the selected animal specie 
        public static Bird CreateBird(BirdSpecies birdSpecie)
        {
            Animal birdObject;

            switch (birdSpecie)
            {
                case BirdSpecies.Crow:
                        birdObject = new Crow();
                        break;
                case BirdSpecies.Eagle:
                        birdObject = new Eagle();
                        break;
                case BirdSpecies.Vulture:
                        birdObject = new Vulture();
                        break;
                default:
                    birdObject = null;
                    break;
            }
            return ((Bird)birdObject);
        }
    }
}
