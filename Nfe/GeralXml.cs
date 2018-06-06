using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

public static class GerarXml<T>
{
    public static string Serialize(object objeto)
    {
        string xml;
        using (var stream = new MemoryStream())
        {
            var settings = new XmlWriterSettings
            {
                Encoding = new UTF8Encoding(false),
                Indent = true,
                IndentChars = "\t",
                NewLineChars = Environment.NewLine,
                ConformanceLevel = ConformanceLevel.Document
            };

            using (var writer = XmlWriter.Create(stream, settings))
            {
                var namespaces = new XmlSerializerNamespaces();
                namespaces.Add(string.Empty, "http://www.portalfiscal.inf.br/nfe");

                new XmlSerializer(typeof(T)).Serialize(writer, objeto, namespaces);

                xml = Encoding.ASCII.GetString(stream.GetBuffer());
            }
        }

        return xml;
    }
}