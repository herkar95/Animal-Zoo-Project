using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Apu_Animal_Motel
{
    [Serializable]
    [XmlRoot ("Recipe")] // mapping of XML elements
    public class Recipe
    {
        // Private fields
        private List<string> m_ingredients;
        private string name;
        
        // Properties
        [XmlElement("Name", DataType = "string")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [XmlArray("Ingredients")]
        [XmlArrayItem("Ingredient", DataType = "string")]
        public List<string> Ingredients
        {
            get { return m_ingredients; }
            set { m_ingredients = value; }
        }

        // Constructor(s)
        public Recipe()
        {
            m_ingredients = new List<string>();
        }

        // Returns the recipe object as a string, formatted accordingly.
        public override string ToString()
        {
            List<string> list = m_ingredients;
            string finalRecipe = "(Recipe) " + Name + " - ";

            for(int i = 0; i<list.Count; i++)
            {
                // Adds a comma if there are more ingredients to follow.
                if(i != (list.Count-1) )
                {
                    finalRecipe += list[i] + ", ";
                }
                // Adds a dot if it's the last ingredient.
                else
                {
                    finalRecipe += list[i] + ".";
                }
            }
            return finalRecipe;
        }
    }
}
