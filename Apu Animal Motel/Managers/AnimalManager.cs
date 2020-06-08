using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Animal_Motel
{
    ///<summary>
    ///This class uses most of the methods in the ListManager class directly.
    ///However, before adding a new object to the collection, it generates a unique ID
    ///depending on the object type, and then attaches it to the object's ID property.
    ///</summary>
    public class AnimalManager : ListManager<Animal>
    {
        // Unique ID for each animal. Starts at 100 when initialized
        private int uniqueAnimalId;

        // Constructor(s)
        public AnimalManager()
        {
            uniqueAnimalId = 100;
        }

        // Generates a unique ID for each animal
        public void generateUniqueId(Animal animal)
        {
            string generatedId = "";
            // The id will differentiate depending on the animal's category
            if(animal is Mammal)
            {
                generatedId = "Mmml" + uniqueAnimalId;
            }
            else if(animal is Bird)
            {
                generatedId = "Bird" + uniqueAnimalId;
            }
            uniqueAnimalId++;

            animal.ID = generatedId;
        }
    }
}
