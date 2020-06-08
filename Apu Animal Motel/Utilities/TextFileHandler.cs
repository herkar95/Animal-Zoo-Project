using Newtonsoft.Json;
using System.IO;

namespace Apu_Animal_Motel
{
    /// <summary>
    /// This class handles all operations regarding opening and writing to file in regular text format.
    /// </summary>
    public class TextFileHandler
    {
        /// <summary>
        /// A generic method that can be used to write text content to file as JSON.
        /// </summary>
        /// <param name="fileName">Name of the text file to be saved</param>
        /// <param name="obj">To object to be written to file as JSON</param>
        public static void WriteToFileAsJSON<T>(string fileName, T obj)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                string output = JsonConvert.SerializeObject(obj, Formatting.Indented, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Objects
                });
                writer.Write(output);
            }
        }

        /// <summary>
        /// A generic method that can be used to deserialize JSON text.
        /// </summary>
        /// <param name="fileName">Name of the text file to be read</param>
        public static T ReadJSONFromFile<T>(string fileName)
        {
            // Represents the object with the deserialized jsondata to be returned
            object obj = null;
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string contents = ""; // represents the final string (the entire text file)
                    string line = ""; // represents each line read
                    while ((line = reader.ReadLine()) != null)
                    {
                        contents += line;
                    }
                    obj = JsonConvert.DeserializeObject<T>(contents, new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.Objects
                    });
                }
            }
            catch (JsonReaderException)
            {
                throw new JsonReaderException("The JSON file you are trying to open seems to be corrupt or damaged.");
            }
            catch (JsonSerializationException)
            {
                throw new JsonSerializationException("The structure of the JSON file you're trying to deserialize seems to be incopatible with this program");
            }
            return (T)obj;
        }
    }
}
