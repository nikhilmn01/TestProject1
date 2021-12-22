using NUnit.Framework;
using System;
using System.Text;
using System.Xml;
using System.Xml.Serialization;


namespace TestProject1.OtherPrograms
{
    internal class xml
    {

        string path = @"C:\Users\nikhil.mn\vs-workspace\TestProject1\xml\sampleXml.xml";
        
        [Test]
        
        public void xmlProg()
        {
            writeXml();
            readXml();
            update();
        }

        public void readXml()
        {

            // Start with XmlReader object  
            //here, we try to setup Stream between the XML file nad xmlReader  
            using (XmlReader reader = XmlReader.Create(path))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        //return only when you have START tag  
                        switch (reader.Name.ToString())
                        {
                            case "fName":
                                Console.WriteLine("First Name of the Person is : " + reader.ReadString());
                                break;
                            case "lName":
                                Console.WriteLine("Last Name of the Person is : " + reader.ReadString());
                                break;
                            case "Age":
                                Console.WriteLine("Age of the Person is : " + reader.ReadString());
                                break;
                            case "Place":
                                Console.WriteLine("Place of the Person is : " + reader.ReadString());
                                break;
                        }
                    }
                    Console.WriteLine("");
                }
            }

        }

        public void writeXml()
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("users");
            xmlDoc.AppendChild(rootNode);

            XmlNode userNode = xmlDoc.CreateElement("user");
            rootNode.AppendChild(userNode);

            XmlNode fName = xmlDoc.CreateElement("fName");
            fName.InnerText = "Nikhil";
            userNode.AppendChild(fName);

            XmlNode lName = xmlDoc.CreateElement("lName");
            lName.InnerText = "M N";
            userNode.AppendChild(lName);

            XmlNode Age = xmlDoc.CreateElement("Age");
            Age.InnerText = "24";
            userNode.AppendChild(Age);

            XmlNode Place = xmlDoc.CreateElement("Place");
            Place.InnerText = "Sahakarnagar";
            userNode.AppendChild(Place);

            userNode = xmlDoc.CreateElement("user");
            rootNode.AppendChild(userNode);

            fName = xmlDoc.CreateElement("fName");
            fName.InnerText = "Manoj";
            userNode.AppendChild(fName);

            lName = xmlDoc.CreateElement("lName");
            lName.InnerText = "G";
            userNode.AppendChild(lName);

            Age = xmlDoc.CreateElement("Age");
            Age.InnerText = "24";
            userNode.AppendChild(Age);

            Place = xmlDoc.CreateElement("Place");
            Place.InnerText = "Yelahanka";
            userNode.AppendChild(Place);


            xmlDoc.Save(path);





        }

        public void update()
        {

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);
            xmlDoc.SelectSingleNode("users/user/fName").InnerText = "Nikhil_New";
            //xmlDoc.SelectSingleNode("users/user").NextSibling.SelectSingleNode("fName").InnerText = "MN_New";     //it works
            xmlDoc.Save(path);

        }

    }
}
