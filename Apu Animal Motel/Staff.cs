using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Animal_Motel
{
    /// <summary>
    /// The personnel of the company have various qualifications.
    /// One can work as an elephant keeper, elephant trainer while
    /// another can have qualifications such as dolphine trainer.
    /// This class provides a register of the staff, saving all
    /// qualifications (as strings) for each person.
    /// </summary>
    public class Staff
    {
        // Private fields
        private string name;
        private IListManager<string> m_qualifications;

        // Constructor(s)
        public Staff()
        {
            m_qualifications = new ListManager<string>();
        }

        // Properties
        public ListManager<string> Qualifications
        {
            get { return (ListManager<string>)m_qualifications; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Returns the staff object as a string, formatted accordingly.
        public override string ToString()
        {
            List<string> list = m_qualifications.ToStringList();
            string staffInfo = "(Staff) " + Name + " - ";

            for (int i = 0; i < list.Count; i++)
            {
                // Adds a comma if there are more qualifications to follow.
                if (i != (list.Count - 1))
                {
                    staffInfo += list[i] + ", ";
                }
                // Adds a dot if it's the last qualification.
                else
                {
                    staffInfo += list[i] + ".";
                }
            }
            return staffInfo;
        }
    }
}
