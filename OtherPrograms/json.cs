using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using NUnit.Framework;
using System.Collections;
using System.Threading;
using SpecFlow.Internal.Json;

namespace TestProject1.OtherPrograms
{
    
    public class json
    { 
        [Test]
        public static void jsonProg()
        {
            //WriteFile();
            //LoadFile();
            //Console.WriteLine("********************************");
            //update();
            //LoadFile();
            read();

        }

        public class sampleFile
        {
            public string fName { get; set; }
            public string lName { get; set; }
            public string Age { get; set; }
            public string Place { get; set; }
        }

        public static void LoadFile()
        {
            
            {
                var r = "C:\\Users\\nikhil.mn\\vs-workspace\\TestProject1\\json\\sample.json";
                r.Insert(3, "new_Delhi");
                sampleFile sf = JsonConvert.DeserializeObject<sampleFile>(File.ReadAllText(r));
                Console.WriteLine(sf.fName);
                Console.WriteLine(sf.lName);
                Console.WriteLine(sf.Age);
                Console.WriteLine(sf.Place);
            }
        }

        public static void WriteFile()
        {
            var sample = getProfile();
            var myFile = JsonConvert.SerializeObject(sample, Formatting.Indented);
            myFile.Insert(3, "new_Delhi");
            string file = "C:\\Users\\nikhil.mn\\vs-workspace\\TestProject1\\json\\sample.json";
            File.WriteAllText(file, myFile);

        }

        public static sampleFile getProfile()
        {
            var sample = new sampleFile
            {
                fName = "Nikhil",
                lName = "M N",
                Age = "24",
                Place = "Bangalore"
            };
            return sample;
        }

        public static void update()
        {

            string json = File.ReadAllText("C:\\Users\\nikhil.mn\\vs-workspace\\TestProject1\\json\\sample.json");
            dynamic jsonObj = JsonConvert.DeserializeObject(json);
            jsonObj["Place"] = "New_Delhi";
            string output = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
            File.WriteAllText("C:\\Users\\nikhil.mn\\vs-workspace\\TestProject1\\json\\sample.json", output);

        }


        public static void read()
        {
            var r = "C:\\Users\\nikhil.mn\\vs-workspace\\TestProject1\\json\\sample.json";
            var e2ePath = @"C:\Users\nikhil.mn\vs-workspace\TestProject1\json\e2e_validate.json";
            dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadAllText(e2ePath));
            var list = jsonFile["resources"];
            string dummy = "abcsgvg"; 
            
            foreach (var item in list)
            {
                string abc = item.ToString();
                Assert.IsFalse(dummy == abc);
                Console.WriteLine(item);
            }
            //Console.WriteLine(jsonFile["email"]);
        }
    }
}



