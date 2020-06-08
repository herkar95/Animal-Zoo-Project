using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Animal_Motel
{
    [Serializable]
    public class FoodSchedule
    {
        // Private attribute(s)
        private List<string> foodDescriptionList;

        // Properties
        public int Count
        {
            get { return foodDescriptionList.Count; }
        }

        // Constructor(s)
        public FoodSchedule()
        {
            foodDescriptionList = new List<string>();
        }
        public FoodSchedule(List<string> foodList)
        {
            foodDescriptionList = foodList;
        }

        // Adds the given string to the list of strings.
        public bool AddFoodScheduleItem(string item)
        {
            if(item.Trim() != "")
            {
                foodDescriptionList.Add(item);
                return true;
            }
            else
            {
                return false;
            }
        }

        // Changes the value of a given index in the list
        public bool ChangeFoodScheduleItem(string item, int index)
        {
            if(ValidateIndex(index))
            {
                foodDescriptionList[index] = "(" + index + ") " + item + Environment.NewLine;
                return true;
            }
            else
            {
                return false;
            }
        }

        // Removes the string at the given index
        public bool DeleteFoodScheduleItem(int index)
        {
            if(ValidateIndex(index))
            {
                foodDescriptionList.RemoveAt(index);
                return true;
            }
            else
            {
                return false;
            }
        }

        // No feeding required
        public string DescribeNoFeedingRequired()
        {
            return " does not require any feeding.";
        }

        // Returns the string at a specific index in the list
        public string GetFoodSchedule(int index)
        {
            if(ValidateIndex(index))
            {
                return foodDescriptionList[index];
            }
            else
            {
                return "Nothing was found at the given index";
            }
        }

        // Concatenates the list of strings to a singular string
        public override string ToString()
        {
            return string.Join(String.Empty, foodDescriptionList);
        }

        // Returns true if the given index is within the range of items in the list.
        private bool ValidateIndex(int index)
        {
            // If the index is within the range
            if (index >= 0 && index <= foodDescriptionList.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
