using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Animal_Motel
{
    ///<summary>
    /// Interface for implementation by manager classes hosting a collection
    /// of the type List<T> where T can be any object type. In this documentation,
    /// the collection is referred to as objectList.
    /// IListManager can be implemented by different classes passing any type <T> at
    /// declaration but then T MUST HAVE THE SAME TYPE IN ALL METHODS INCLUDED IN THIS
    /// INTERFACE.
    ///</summary>
    ///<typeparam name="T">object type</typeparam>
    interface IListManager<T>
    {
        ///<summary>
        ///Returns the number of items in collection objectList
        ///</summary>
        int Count { get; }

        ///<summary>
        ///Adds an object to the list
        ///</summary>
        ///<param name="aType">A type</param>
        ///<returns> true if successful, false otherwise</returns>
        bool Add(T aType);

        ///<summary>
        ///Replaces an object at a specific index in the list
        ///</summary>
        ///<param name="aType">A type</param>
        ///<param name="index">Index of object in the list to be changed</param>
        ///<returns> true if successful, false otherwise</returns>
        bool ChangeAt(T aType, int index);

        ///<summary>
        ///Checks if the index is within the range of the list        
        ///</summary>
        ///<param name="index">Index in the list to be verified</param>
        ///<returns> true if successful, false otherwise</returns>
        bool CheckIndex(int index);

        ///<summary>
        ///Removes all of the objects from the list
        ///</summary>
        void DeleteAll();

        ///<summary>
        ///Removes an object from the list at the given index
        ///</summary>
        ///<param name="index">Index of the object you wish to remove from the list</param>
        ///<returns> true if successful, false otherwise</returns>
        bool DeleteAt(int index);

        ///<summary>
        ///Retrieves the object at the given index 
        ///</summary>
        ///<param name="index">Index of the object you wish to retrieve </param>
        ///<returns> Type object</returns>
        T GetAt(int index);

        ///<summary>
        ///Converts the list of objects to an array of strings
        ///Inspiration taken from https://stackoverflow.com/questions/4515847/how-to-convert-listint-to-string/4515851
        ///</summary>
        ///<returns> String array of object values</returns>
        string[] ToStringArray();

        ///<summary>
        ///Converts the list of objects to a list of strings
        ///</summary>
        ///<returns> List of strings of object values</returns>
        List<string> ToStringList();

        ///<summary>
        ///Serializes the objects in a manager class and writes them to a binary file
        ///</summary>
        ///<param name="fileName">Path to where the binary file should be saved</param>
        void BinarySerialize(string fileName);

        ///<summary>
        ///Deserializes the contents of the binary file selected
        ///</summary>
        ///<param name="fileName">Path to binary file you want to deserialize</param>
        void BinaryDeSerialize(string fileName);

        ///<summary>
        ///Serializes the objects in a manager class and writes them to an XML file
        ///</summary>
        ///<param name="fileName">Path to where the XML file should be saved</param>
        void XMLSerialize(string fileName);

        ///<summary>
        ///DeSerializes the objects in a manager class and writes them to file as XML
        ///</summary>
        ///<param name="fileName">Path to XML file you want to deserialize</param>
        void XMLDeSerialize(string fileName);

        ///<summary>
        ///Serializes the objects in a manager class and writes them to a text file as JSon
        ///</summary>
        ///<param name="fileName">Path to where the text file should be saved</param>
        void JSONSerialize(string fileName);

        ///<summary>
        ///DeSerializes the objects in a manager class and writes them to a text file as JSON
        ///</summary>
        ///<param name="fileName">Path to text file you want to deserialize</param>
        void JSONDeSerialize(string fileName);
    }
}
