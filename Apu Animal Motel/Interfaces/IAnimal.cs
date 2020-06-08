using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Animal_Motel
{
    interface IAnimal
    {
        // Properties that every animal must have
        GenderType Gender { get; set; }
        string ID { get; }
        string Name { get; set; }

        // Methods that every animal must implement
        EaterType GetEaterType();
        FoodSchedule GetFoodSchedule();
        string GetSpecies();
    }
}
