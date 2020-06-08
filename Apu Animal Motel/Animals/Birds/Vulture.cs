using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Animal_Motel
{
    [Serializable]
    public class Vulture : Bird
    {
        // Public properties 
        public string NeckColor { get; set; }

        // Constructor
        public Vulture()
        {
            EaterType = EaterType.Carnivore;
            FoodSchedule = new FoodSchedule();
            HardCodeFoodSchedule();
        }

        // Returns the animal specific attribute as a a string
        public string getAnimalSpecificData()
        {
            return "Neck color is " + NeckColor + ".";
        }

        // Returns the type of species as a string
        public override string GetSpecies()
        {
            return "Vulture";
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
            FoodSchedule.AddFoodScheduleItem("(0) Morning: carrion." + Environment.NewLine);
            FoodSchedule.AddFoodScheduleItem("(1) Lunch: more carrion." + Environment.NewLine);
            FoodSchedule.AddFoodScheduleItem("(2) 3 PM: even more carrion!" + Environment.NewLine);
            FoodSchedule.AddFoodScheduleItem("(3) Evenings: maybe some more carrion!" + Environment.NewLine);
        }

        // Provides useful information about the animal object and its properties
        public override string ToString()
        {
            string s = ID + ", " + Name + ", " + Age + ", " + Gender + ", " + AdditionalInfo;
            return s;
        }
    }
}
