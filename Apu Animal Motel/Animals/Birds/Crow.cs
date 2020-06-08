using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Animal_Motel
{
    [Serializable]
    public class Crow : Bird
    {
        // Public properties 
        public int Weight { get; set; }

        // Constructor
        public Crow()
        {
            EaterType = EaterType.Omnivorous;
            FoodSchedule = new FoodSchedule();
            HardCodeFoodSchedule();
        }

        // Returns the animal specific attribute as a string
        public string getAnimalSpecificData()
        {
            return "Weighs " + Weight + " kg.";
        }

        // Returns the type of species as a string
        public override string GetSpecies()
        {
            return "Crow";
        }

        // Returns what eater type the animal is. List of options taken from the enum 'EaterType'
        public override EaterType GetEaterType()
        {
            return EaterType;
        }

        // Returns the food schedule for this animal type
        public override FoodSchedule GetFoodSchedule()
        {
            return FoodSchedule;
        }

        // Hardcoded values of the food schedule. This method will be present in all specific animal classes.
        private void HardCodeFoodSchedule()
        {
            FoodSchedule.AddFoodScheduleItem("(0) Morning: worms." + Environment.NewLine);
            FoodSchedule.AddFoodScheduleItem("(1) Lunch: some veggies." + Environment.NewLine);
            FoodSchedule.AddFoodScheduleItem("(2) 3 PM: even more worms!" + Environment.NewLine);
            FoodSchedule.AddFoodScheduleItem("(3) Evenings: no more food." + Environment.NewLine);
        }

        // Provides useful information about the animal object and its properties
        public override string ToString()
        {
            string s = ID + ", " + Name + ", " + Age + ", " + Gender + ", " + AdditionalInfo;
            return s;
        }
    }
}
