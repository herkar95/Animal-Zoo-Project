using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Animal_Motel
{
    [Serializable]
    public class Lion : Mammal
    {
        // Public properties 
        public int TailLength { get; set; }

        // Constructor
        public Lion()
        {
            EaterType = EaterType.Carnivore;
            FoodSchedule = new FoodSchedule();
            HardCodeFoodSchedule();
        }

        // Returns the animal specific attribute as a string
        public string getAnimalSpecificData()
        {
            return "Tail length is " + TailLength + " cm.";
        }

        // Returns the type of species as a string
        public override string GetSpecies()
        {
            return "Lion";
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
            FoodSchedule.AddFoodScheduleItem("(0) Morning: meat." + Environment.NewLine);
            FoodSchedule.AddFoodScheduleItem("(1) Lunch: more meat." + Environment.NewLine);
            FoodSchedule.AddFoodScheduleItem("(2) 3 PM: even more meat!" + Environment.NewLine);
            FoodSchedule.AddFoodScheduleItem("(3) Evenings: no more food for today." + Environment.NewLine);
        }

        // Provides useful information about the animal object and its properties
        public override string ToString()
        {
            string s = ID + ", " + Name + ", " + Age + ", " + Gender + ", " + AdditionalInfo;
            return s;
        }
    }
}
