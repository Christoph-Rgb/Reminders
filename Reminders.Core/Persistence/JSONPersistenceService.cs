using System;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Reminders.Core
{
    public class JSONPersistenceService<T> : IPersistenceService<T>
    {
        public JSONPersistenceService()
        {
        }

        public void SaveObject(string path, T @object)
        {
            if (string.IsNullOrEmpty(path)) throw new ArgumentNullException("path");
            if (@object == null) throw new ArgumentNullException("object");

            using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
            {
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(T));
                jsonSerializer.WriteObject(fileStream, @object);
            }
        }

        public T LoadObject(string path)
        {
            if (string.IsNullOrEmpty(path)) throw new ArgumentNullException("path");

            using (FileStream fileStream = new FileStream(path, FileMode.Open))
            {
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(T));

                var loadedObject = jsonSerializer.ReadObject(fileStream);
                return (T)loadedObject;
            }
        }
    }
}