using System;
using System.Collections.Generic;
using System.Linq;

namespace Apu_Animal_Motel
{
    ///<summary>
    ///Class which implements all of the methods in the IListManager interface.
    ///All of the methods, including parameters and return values, are 
    ///well documented in the IListManager interface.
    ///</summary>
    [Serializable]
    public class ListManager<T> : IListManager<T>
    {
        private List<T> objectList;

        // Properties
        public int Count
        {
            get { return objectList.Count; }
        }

        // Constructor(s)
        public ListManager()
        {
            objectList = new List<T>();
        }

        public bool Add(T aType)
        {
            if (aType != null)
            {
                objectList.Add(aType);
                return true;
            }
            return false;
        }

        public bool ChangeAt(T aType, int index)
        {
            if (CheckIndex(index) && aType != null)
            {
                objectList[index] = aType;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckIndex(int index)
        {
            // If the index is within the range
            if (index >= 0 && index <= objectList.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DeleteAll()
        {
            objectList.Clear();
        }

        public bool DeleteAt(int index)
        {
            if (CheckIndex(index))
            {
                objectList.RemoveAt(index);
                return true;
            }
            else
            {
                return false;
            }
        }

        public T GetAt(int index)
        {
            return objectList[index];
        }

        // Resets the objectList to a new one
        public void Reset()
        {
            objectList = new List<T>();
        }

        public string[] ToStringArray()
        {
            string[] arrayOfStrings = objectList.Select(item => item.ToString()).ToArray();
            return arrayOfStrings;
        }

        public List<string> ToStringList()
        {
            List<string> objectListAsStrings = new List<string>();

            foreach (var item in objectList)
            {
                objectListAsStrings.Add(item.ToString());
            }

            return objectListAsStrings;
        }

        public void BinarySerialize(string fileName)
        {
            BinSerializerUtility.Serialize(fileName, objectList);
        }

        public void BinaryDeSerialize(string fileName)
        {
            objectList = BinSerializerUtility.DeSerialize<List<T>>(fileName);
        }

        public void XMLSerialize(string fileName)
        {
            XMLSerializerUtility.XMLSerialize(fileName, objectList); ;
        }

        public void XMLDeSerialize(string fileName)
        {
            objectList = XMLSerializerUtility.XMLDeSerialize<List<T>>(fileName);
        }

        public void JSONSerialize(string fileName)
        {
            TextFileHandler.WriteToFileAsJSON(fileName, objectList);
        }

        public void JSONDeSerialize(string fileName)
        {
            objectList = TextFileHandler.ReadJSONFromFile<List<T>>(fileName);
        }
    }
}
