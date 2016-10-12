using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace OutputNum
{
    class Program
    {
        static void Main(string[] args)
        {
            //string fileName = "C:\\Users\\Ting\\Source\\Repos\\Week3_Day3_TIY\\PlacetoOutput.txt";


            //StreamWriter sw = new StreamWriter(fileName, false);

            //{
            //    sw.WriteLine("The number is: ");
            //    for (int i = 1; i < 101; i++)
            //    {
            //        int a = i;

            //        sw.WriteLine(a);
            //    }

            //}
            //sw.Close();


            //List<Numbers> numbers = new List<Numbers>();

            //StreamReader sr = new StreamReader(fileName);
            //if (File.Exists(fileName))
            //{
            //    while (!sr.EndOfStream)
            //    {

            //        string temp = sr.ReadLine();
            //        string[] values = temp.Split('\n');
            //        Numbers n = new Numbers();
            //        n.Num = values[0];

            //        numbers.Add(n);
            //        Console.WriteLine(n.Num);

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("File not found");
            //}

            //sw.Close();


            //PART 2 PLANT

            List<Plant> plantInfo = new List<Plant>();

            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\Ting\\Source\\Repos\\Week3_Day3_TIY\\plant_catalog.xml");
            XmlNode plantCat = doc.DocumentElement.SelectSingleNode("/CATALOG");

            foreach (XmlNode child in plantCat.ChildNodes)
            {
                Plant plantdetail = new Plant();

                foreach (XmlNode grandChild in child.ChildNodes)
                {

                    switch (grandChild.Name)
                    {
                        case "COMMON":
                            {
                                plantdetail.Common = grandChild.InnerText;
                                Console.WriteLine(plantdetail.Common);

                                break;
                            }
                        case "BOTANICAL":
                            {
                                plantdetail.Botanical = grandChild.InnerText;
                                Console.WriteLine(plantdetail.Botanical);

                                break;
                            }
                        case "ZONE":
                            {
                                plantdetail.Zone = grandChild.InnerText;
                                Console.WriteLine(plantdetail.Zone);

                                break;
                            }
                        case "LIGHT":
                            {
                                plantdetail.Light = grandChild.InnerText;
                                Console.WriteLine(plantdetail.Light);

                                break;
                            }
                        case "PRICE":
                            {
                                plantdetail.Price = grandChild.InnerText;
                                Console.WriteLine(plantdetail.Price);

                                break;
                            }
                        case "AVAILABILITY":
                            {
                                plantdetail.Availability = Convert.ToInt32(grandChild.InnerText);
                                Console.WriteLine(plantdetail.Availability);
                                break;
                            }
                        default:
                            {
                                break;
                            }
  
                           
                    }
                }
                plantInfo.Add(plantdetail);

               
            }
            Console.ReadLine();
        }
    }
}
