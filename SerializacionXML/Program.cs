// Crear una persona para serializar

using SerializacionXML;

Persona persona = new Persona
{
    PrimerNombre = "Juan",
    SegundoNombre = "Carlos",
    PrimerApellido = "Cardoza",
    SegundoApellido = "Solis",
    Edad = 18
};

//Usar factory de serealizacion XML
ISerializerFactory xmlSerializerFactory = new XmlSerializerFactory();
ObjectSerializer xmlobjectSerializer = new ObjectSerializer(xmlSerializerFactory);
xmlobjectSerializer.Serializer(persona, "persona.xml");


//Desearilizar persona desde XML

Persona personaFromXML = xmlobjectSerializer.Deserialize<Persona>("persona.xml");

Console.WriteLine("persona desde XML :" +
    "Nombre = {0} {1}, " +
    "Apellido = {2} {3}, " +
    "Edad = {4}",
    persona.PrimerNombre, 
    persona.SegundoNombre, 
    persona.PrimerApellido, 
    persona.SegundoApellido,
    persona.Edad);