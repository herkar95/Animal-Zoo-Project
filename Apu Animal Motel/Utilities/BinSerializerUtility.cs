using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// This class handles all operations regarding binary serialization and deserialization.
/// </summary>
namespace Apu_Animal_Motel
{
    public class BinSerializerUtility
    {

        /// <summary>
        /// A generic method that can be used to serialize any Type to binary file.
        /// </summary>
        /// <typeparam name="T">Type of the object.</typeparam>
        /// <param name="fileName">Name of the file with the serialized data</param>
        /// <param name="obj">Object containing the data to be serialized. This object 
        /// must be Serializable.</param>
        public static void Serialize<T>(string fileName, T obj)
        {
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(fileName, FileMode.Create);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, obj);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }
        }

        /// <summary>
        /// A generic method that can be used to deserialize binary files.
        /// </summary>
        /// <typeparam name="T">Type of the object.</typeparam>
        /// <param name="fileName">Name of the binary file you wish to deserialize</param>
        public static T DeSerialize<T>(string fileName)
        {
            FileStream fileStream = null;
            // Represents the object with the deserialized data to be returned
            object obj = null;

            try
            {
                if (File.Exists(fileName))
                {
                    fileStream = new FileStream(fileName, FileMode.Open);
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    obj = (T)binaryFormatter.Deserialize(fileStream);
                }
            }
            catch (SerializationException)
            {
                throw new SerializationException("This program can only handle deserialization of animal objects created by this program. No other binary files are supported at this time.");
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }
            return (T)obj;
        }
    }
}
