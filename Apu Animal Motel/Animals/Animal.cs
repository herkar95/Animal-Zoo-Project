using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Animal_Motel
{
    [Serializable]
    public abstract class Animal : IAnimal
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public GenderType Gender { get; set; }
        public string AdditionalInfo { get; set; }
        public string ID { get; set; }
        public EaterType EaterType { get; set; }
        public FoodSchedule FoodSchedule { get; set; }

        // Abstract methods
        public abstract EaterType GetEaterType();
        public abstract FoodSchedule GetFoodSchedule();
        public abstract string GetSpecies();
    }
}
