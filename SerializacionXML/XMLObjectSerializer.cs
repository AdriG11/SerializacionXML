﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializacionXML
{
    //Implementar la serializacion XMl
    public class XMLObjectSerializer : ISerializer
    {
        public T Deserialize<T>(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                var serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(reader);
            }
        }

        public void Serialize<T>(T obj, string fileName)
        {
          using (var writer = new StreamWriter(fileName))
            {
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer, obj);
            }
        }
    }
}
