using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

/// <summary>
/// This class handles all operations regarding XML serialization and deserialization.
/// </summary>
namespace Apu_Animal_Motel
{
    public class XMLSerializerUtility
    {
        /// <summary>
        /// A generic method that can be used to serialize any Type to XML file.
        /// </summary>
        /// <typeparam name="T">Type of the object.</typeparam>
        /// <param name="fileName">Name of the file with the serialized data</param>
        /// <param name="obj">Object containing the data to be serialized. This object 
        /// must be Serializable.</param>
        public static void XMLSerialize<T>(string fileName, T obj)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            TextWriter writer = new StreamWriter(fileName);
            try
            {
                serializer.Serialize(writer, obj);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                if(writer != null)
                {
                    writer.Close();
                }
            }
        }

        /// <summary>
        /// A generic method that can be used to deserialize XML files.
        /// </summary>
        /// <typeparam name="T">Type of the object.</typeparam>
        /// <param name="fileName">Name of the XML file you wish to deserialize</param>
        public static T XMLDeSerialize<T>(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            // Represents the object with the deserialized data to be returned
            object obj = null;
            TextReader textReader = null;
            try
            {
                textReader = new StreamReader(fileName);
                obj = (T)serializer.Deserialize(textReader);
            }
            catch(NullReferenceException)
            {
                throw new NullReferenceException("It seems that the structure of the XML file might be damaged or corrupt.");
            }
            catch(InvalidOperationException)
            {
                throw new InvalidOperationException("It seems that the structure of the XML file might be damaged or corrupt.");
            }
            finally
            {
                if(textReader != null)
                {
                    textReader.Close();
                }
            }
            return (T)obj;
        }
    }
}
