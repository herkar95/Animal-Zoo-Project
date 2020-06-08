using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Animal_Motel
{
    [Serializable]
    public class Cat : Mammal
    {
        // Public properties 
        public int WhiskerLength { get; set; }

        // Constructor
        public Cat()
        {
            EaterType = EaterType.Carnivore;
            FoodSchedule = new FoodSchedule();
            HardCodeFoodSchedule();
        }

        // Returns the animal specific attribute as a string
        public string getAnimalSpecificData()
        {
            return "Whisker length is " + WhiskerLength + " cm.";
        }

        // Returns the type of species as a string
        public override string GetSpecies()
        {
            return "Cat";
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
            FoodSchedule.AddFoodScheduleItem("(0) Morning: cat food." + Environment.NewLine);
            FoodSchedule.AddFoodScheduleItem("(1) Lunch: more cat food." + Environment.NewLine);
            FoodSchedule.AddFoodScheduleItem("(2) 3 PM: even more cat food!" + Environment.NewLine);
            FoodSchedule.AddFoodScheduleItem("(3) Evenings: maybe some more cat food." + Environment.NewLine);
        }

        // Provides useful information about the animal object and its properties
        public override string ToString()
        {
            string s = ID + ", " + Name + ", " + Age + ", " + Gender + ", " + AdditionalInfo;
            return s;
        }
    }
}
