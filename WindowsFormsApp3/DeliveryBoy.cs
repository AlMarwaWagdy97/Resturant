using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace WindowsFormsApp3
{
   public class DeliveryBoy
    {
        string name;
        string area;
        string zip_code;
        int order_counter = 0;
        string id;
        string ORDER_TIME="00:00:00";
        public void f()
        {
            if(!File.Exists("DeliveryBoy.xml"))
            { 
                using (XmlWriter writer = XmlWriter.Create("DeliveryBoy.xml"))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Table");
                    writer.WriteAttributeString("name", "DeliveryBoy");

                    writer.WriteStartElement("Boy");


                  
               

                    writer.WriteStartElement("Name");
                    writer.WriteString("Ahmed");
                    writer.WriteEndElement();

                    writer.WriteStartElement("ID");
                    writer.WriteString("1");
                    writer.WriteEndElement();



                    writer.WriteStartElement("area");
                    writer.WriteString("Abassia");
                    writer.WriteEndElement();

                    writer.WriteStartElement("zib_code");
                    writer.WriteString("1");
                    writer.WriteEndElement();

                    writer.WriteStartElement("count_order");
                    writer.WriteString(Convert.ToString( order_counter));
                    writer.WriteEndElement();

                    writer.WriteStartElement("order_time");
                    writer.WriteString(ORDER_TIME);
                    writer.WriteEndElement();

                    writer.WriteStartElement("Date");
                    writer.WriteString("0/0/0");
                    writer.WriteEndElement();

                    writer.WriteStartElement("Day");
                    writer.WriteString("0");
                    writer.WriteEndElement();

                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Close();
                }
            }
            else
            {
               

                XmlDocument doc = new XmlDocument();
 
                XmlElement p = doc.CreateElement("Boy");
                XmlElement node = doc.CreateElement("Name");

                node.InnerText = "Donia";
                p.AppendChild(node);

                node = doc.CreateElement("ID");
                node.InnerText = "2";
                p.AppendChild(node);

                node = doc.CreateElement("area");
                node.InnerText = "Ain-Shams";
                p.AppendChild(node);

                node = doc.CreateElement("zib_code");
                node.InnerText = "2";
                p.AppendChild(node);

                node = doc.CreateElement("count_order");
                node.InnerText = Convert.ToString(order_counter);
                p.AppendChild(node);


                node = doc.CreateElement("order_time");
                node.InnerText = ORDER_TIME;
                p.AppendChild(node);

                node = doc.CreateElement("Date");
                node.InnerText = "0/0/0";
                p.AppendChild(node);

                node = doc.CreateElement("Day");
                node.InnerText = "0";
                p.AppendChild(node);

                doc.Load("DeliveryBoy.xml");
                XmlElement root = doc.DocumentElement;
                root.AppendChild(p);
                doc.Save("DeliveryBoy.xml");
                /////////////////////////////////////////////////////////////////////////////////////////
                p = doc.CreateElement("Boy");
                node = doc.CreateElement("Name");

                node.InnerText = "Doaa";
                p.AppendChild(node);

                node = doc.CreateElement("ID");
                node.InnerText = "3";
                p.AppendChild(node);

                node = doc.CreateElement("area");
                node.InnerText = "Helwan";
                p.AppendChild(node);

                node = doc.CreateElement("zib_code");
                node.InnerText = "3";
                p.AppendChild(node);


                node = doc.CreateElement("count_order");
                node.InnerText = Convert.ToString(order_counter);
                p.AppendChild(node);

                node = doc.CreateElement("order_time");
                node.InnerText = ORDER_TIME;
                p.AppendChild(node);

                node = doc.CreateElement("Date");
                node.InnerText = "0/0/0";
                p.AppendChild(node);

                node = doc.CreateElement("Day");
                node.InnerText = "0";
                p.AppendChild(node);


                doc.Load("DeliveryBoy.xml");
                root = doc.DocumentElement;
                root.AppendChild(p);
                doc.Save("DeliveryBoy.xml");
                ////////////////////////////////////////////////////////////////////////////////////

                p = doc.CreateElement("Boy");
                node = doc.CreateElement("Name");

                node.InnerText = "Dina";
                p.AppendChild(node);

                node = doc.CreateElement("ID");
                node.InnerText = "4";
                p.AppendChild(node);


                node = doc.CreateElement("area");
                node.InnerText = "Heliopolis";
                p.AppendChild(node);

                node = doc.CreateElement("zib_code");
                node.InnerText = "4";
                p.AppendChild(node);

                node = doc.CreateElement("count_order");
                node.InnerText = Convert.ToString(order_counter);
                p.AppendChild(node);

                node = doc.CreateElement("order_time");
                node.InnerText = ORDER_TIME;
                p.AppendChild(node);


                node = doc.CreateElement("Date");
                node.InnerText = "0/0/0";
                p.AppendChild(node);

                node = doc.CreateElement("Day");
                node.InnerText = "0";
                p.AppendChild(node);

                doc.Load("DeliveryBoy.xml");
                root = doc.DocumentElement;
                root.AppendChild(p);
                doc.Save("DeliveryBoy.xml");
                ////////////////////////////////////////////////////////////////////////////////////

                p = doc.CreateElement("Boy");
                node = doc.CreateElement("Name");

                node.InnerText = "Kholoud";
                p.AppendChild(node);

                node = doc.CreateElement("ID");
                node.InnerText = "5";
                p.AppendChild(node);

                node = doc.CreateElement("area");
                node.InnerText = "Abassia";
                p.AppendChild(node);

                node = doc.CreateElement("zib_code");
                node.InnerText = "1";
                p.AppendChild(node);

                node = doc.CreateElement("count_order");
                node.InnerText = Convert.ToString(order_counter);
                p.AppendChild(node);

                node = doc.CreateElement("order_time");
                node.InnerText = ORDER_TIME;
                p.AppendChild(node);


                node = doc.CreateElement("Date");
                node.InnerText = "0/0/0";
                p.AppendChild(node);

                node = doc.CreateElement("Day");
                node.InnerText = "0";
                p.AppendChild(node);

                doc.Load("DeliveryBoy.xml");
                root = doc.DocumentElement;
                root.AppendChild(p);
                doc.Save("DeliveryBoy.xml");
                ////////////////////////////////////////////////////////////////////////////////////

                p = doc.CreateElement("Boy");
                node = doc.CreateElement("Name");

                node.InnerText = "AlMarwa";
                p.AppendChild(node);

                node = doc.CreateElement("ID");
                node.InnerText = "6";
                p.AppendChild(node);

                node = doc.CreateElement("area");
                node.InnerText = "New Cairo";
                p.AppendChild(node);

                node = doc.CreateElement("zib_code");
                node.InnerText = "5";
                p.AppendChild(node);


                node = doc.CreateElement("count_order");
                node.InnerText = Convert.ToString(order_counter);
                p.AppendChild(node);

                node = doc.CreateElement("order_time");
                node.InnerText = ORDER_TIME;
                p.AppendChild(node);


                node = doc.CreateElement("Date");
                node.InnerText = "0/0/0";
                p.AppendChild(node);

                node = doc.CreateElement("Day");
                node.InnerText = "0";
                p.AppendChild(node);

                doc.Load("DeliveryBoy.xml");
                root = doc.DocumentElement;
                root.AppendChild(p);
                doc.Save("DeliveryBoy.xml");
                ////////////////////////////////////////////////////////////////////////////////////

                p = doc.CreateElement("Boy");
                node = doc.CreateElement("Name");

                node.InnerText = "alaa";
                p.AppendChild(node);

                node = doc.CreateElement("ID");
                node.InnerText = "7";
                p.AppendChild(node);

                node = doc.CreateElement("area");
                node.InnerText = "Shoubra";
                p.AppendChild(node);

                node = doc.CreateElement("zib_code");
                node.InnerText = "6";
                p.AppendChild(node);


                node = doc.CreateElement("count_order");
                node.InnerText = Convert.ToString(order_counter);
                p.AppendChild(node);

                node = doc.CreateElement("order_time");
                node.InnerText = ORDER_TIME;
                p.AppendChild(node);


                node = doc.CreateElement("Date");
                node.InnerText = "0/0/0";
                p.AppendChild(node);

                node = doc.CreateElement("Day");
                node.InnerText = "0";
                p.AppendChild(node);

                doc.Load("DeliveryBoy.xml");
                root = doc.DocumentElement;
                root.AppendChild(p);
                doc.Save("DeliveryBoy.xml");
                ////////////////////////////////////////////////////////////////////////////////////

                p = doc.CreateElement("Boy");
                node = doc.CreateElement("Name");

                node.InnerText = "morgan";
                p.AppendChild(node);

                node = doc.CreateElement("ID");
                node.InnerText = "8";
                p.AppendChild(node);

                node = doc.CreateElement("area");
                node.InnerText = "sharm";
                p.AppendChild(node);

                node = doc.CreateElement("zib_code");
                node.InnerText = "7";
                p.AppendChild(node);

                node = doc.CreateElement("count_order");
                node.InnerText = Convert.ToString(order_counter);
                p.AppendChild(node);

                node = doc.CreateElement("order_time");
                node.InnerText = ORDER_TIME;
                p.AppendChild(node);


                node = doc.CreateElement("Date");
                node.InnerText = "0/0/0";
                p.AppendChild(node);

                node = doc.CreateElement("Day");
                node.InnerText = "0";
                p.AppendChild(node);

                doc.Load("DeliveryBoy.xml");
                root = doc.DocumentElement;
                root.AppendChild(p);
                doc.Save("DeliveryBoy.xml");
                ////////////////////////////////////////////////////////////////////////////////////

                p = doc.CreateElement("Boy");
                node = doc.CreateElement("Name");

                node.InnerText = "mohaned";
                p.AppendChild(node);

                node = doc.CreateElement("ID");
                node.InnerText = "9";
                p.AppendChild(node);

                node = doc.CreateElement("area");
                node.InnerText = "Down Town";
                p.AppendChild(node);

                node = doc.CreateElement("zib_code");
                node.InnerText = "8";
                p.AppendChild(node);

                node = doc.CreateElement("count_order");
                node.InnerText = Convert.ToString(order_counter);
                p.AppendChild(node);

                node = doc.CreateElement("order_time");
                node.InnerText = ORDER_TIME;
                p.AppendChild(node);


                node = doc.CreateElement("Date");
                node.InnerText = "0/0/0";
                p.AppendChild(node);

                node = doc.CreateElement("Day");
                node.InnerText = "0";
                p.AppendChild(node);

                doc.Load("DeliveryBoy.xml");
                root = doc.DocumentElement;
                root.AppendChild(p);
                doc.Save("DeliveryBoy.xml");
                ////////////////////////////////////////////////////////////////////////////////////

                p = doc.CreateElement("Boy");
                node = doc.CreateElement("Name");

                node.InnerText = "mahmoud";
                p.AppendChild(node);

                node = doc.CreateElement("ID");
                node.InnerText = "10";
                p.AppendChild(node);

                node = doc.CreateElement("area");
                node.InnerText = "Alf-Maskan";
                p.AppendChild(node);

                node = doc.CreateElement("zib_code");
                node.InnerText = "9";
                p.AppendChild(node);

                node = doc.CreateElement("count_order");
                node.InnerText = Convert.ToString(order_counter);
                p.AppendChild(node);

                node = doc.CreateElement("order_time");
                node.InnerText = ORDER_TIME;
                p.AppendChild(node);


                node = doc.CreateElement("Date");
                node.InnerText = "0/0/0";
                p.AppendChild(node);

                node = doc.CreateElement("Day");
                node.InnerText = "0";
                p.AppendChild(node);

                doc.Load("DeliveryBoy.xml");
                root = doc.DocumentElement;
                root.AppendChild(p);
                doc.Save("DeliveryBoy.xml");
                ////////////////////////////////////////////////////////////////////////////////////

                p = doc.CreateElement("Boy");
                node = doc.CreateElement("Name");

                node.InnerText = "amr";
                p.AppendChild(node);

                node = doc.CreateElement("ID");
                node.InnerText = "11";
                p.AppendChild(node);

                node = doc.CreateElement("area");
                node.InnerText = "Doki";
                p.AppendChild(node);

                node = doc.CreateElement("zib_code");
                node.InnerText = "10";
                p.AppendChild(node);

                node = doc.CreateElement("count_order");
                node.InnerText = Convert.ToString(order_counter);
                p.AppendChild(node);


                node = doc.CreateElement("Date");
                node.InnerText = "0/0/0";
                p.AppendChild(node);

                node = doc.CreateElement("Day");
                node.InnerText = "0";
                p.AppendChild(node);

                node = doc.CreateElement("order_time");
                node.InnerText = ORDER_TIME;
                p.AppendChild(node);

                doc.Load("DeliveryBoy.xml");
                root = doc.DocumentElement;
                root.AppendChild(p);
                doc.Save("DeliveryBoy.xml");
                ////////////////////////////////////////////////////////////////////////////////////

                p = doc.CreateElement("Boy");
                node = doc.CreateElement("Name");

                node.InnerText = "karim";
                p.AppendChild(node);

                node = doc.CreateElement("ID");
                node.InnerText = "12";
                p.AppendChild(node);

                node = doc.CreateElement("area");
                node.InnerText = "Elharm";
                p.AppendChild(node);

                node = doc.CreateElement("zib_code");
                node.InnerText = "11";
                p.AppendChild(node);

                node = doc.CreateElement("count_order");
                node.InnerText = Convert.ToString(order_counter);
                p.AppendChild(node);

                node = doc.CreateElement("order_time");
                node.InnerText = ORDER_TIME;
                p.AppendChild(node);


                node = doc.CreateElement("Date");
                node.InnerText = "0/0/0";
                p.AppendChild(node);

                node = doc.CreateElement("Day");
                node.InnerText = "0";
                p.AppendChild(node);

                doc.Load("DeliveryBoy.xml");
                root = doc.DocumentElement;
                root.AppendChild(p);
                doc.Save("DeliveryBoy.xml");
                ////////////////////////////////////////////////////////////////////////////////////

                p = doc.CreateElement("Boy");
                node = doc.CreateElement("Name");

                node.InnerText = "karam";
                p.AppendChild(node);

                node = doc.CreateElement("ID");
                node.InnerText = "13";
                p.AppendChild(node);

                node = doc.CreateElement("area");
                node.InnerText = "Matarya";
                p.AppendChild(node);

                node = doc.CreateElement("zib_code");
                node.InnerText = "12";
                p.AppendChild(node);

                node = doc.CreateElement("count_order");
                node.InnerText = Convert.ToString(order_counter);
                p.AppendChild(node);

                node = doc.CreateElement("order_time");
                node.InnerText = ORDER_TIME;
                p.AppendChild(node);


                node = doc.CreateElement("Date");
                node.InnerText = "0/0/0";
                p.AppendChild(node);

                node = doc.CreateElement("Day");
                node.InnerText = "0";
                p.AppendChild(node);

                doc.Load("DeliveryBoy.xml");
                root = doc.DocumentElement;
                root.AppendChild(p);
                doc.Save("DeliveryBoy.xml");
                ////////////////////////////////////////////////////////////////////////////////////

                p = doc.CreateElement("Boy");
                node = doc.CreateElement("Name");

                node.InnerText = "hassan";
                p.AppendChild(node);

                node = doc.CreateElement("ID");
                node.InnerText = "14";
                p.AppendChild(node);

                node = doc.CreateElement("area");
                node.InnerText = "Moqattam";
                p.AppendChild(node);

                node = doc.CreateElement("zib_code");
                node.InnerText = "13";
                p.AppendChild(node);

                node = doc.CreateElement("count_order");
                node.InnerText = Convert.ToString(order_counter);
                p.AppendChild(node);

                node = doc.CreateElement("order_time");
                node.InnerText = ORDER_TIME;
                p.AppendChild(node);


                node = doc.CreateElement("Date");
                node.InnerText = "0/0/0";
                p.AppendChild(node);

                node = doc.CreateElement("Day");
                node.InnerText = "0";
                p.AppendChild(node);

                doc.Load("DeliveryBoy.xml");
                root = doc.DocumentElement;
                root.AppendChild(p);
                doc.Save("DeliveryBoy.xml");
                ////////////////////////////////////////////////////////////////////////////////////

                p = doc.CreateElement("Boy");
                node = doc.CreateElement("Name");

                node.InnerText = "hessan";
                p.AppendChild(node);

                node = doc.CreateElement("ID");
                node.InnerText = "15";
                p.AppendChild(node);

                node = doc.CreateElement("area");
                node.InnerText = "Naser City";
                p.AppendChild(node);

                node = doc.CreateElement("zib_code");
                node.InnerText = "14";
                p.AppendChild(node);

                node = doc.CreateElement("count_order");
                node.InnerText = Convert.ToString(order_counter);
                p.AppendChild(node);

                node = doc.CreateElement("order_time");
                node.InnerText = ORDER_TIME;
                p.AppendChild(node);


                node = doc.CreateElement("Date");
                node.InnerText = "0/0/0";
                p.AppendChild(node);

                node = doc.CreateElement("Day");
                node.InnerText = "0";
                p.AppendChild(node);

                doc.Load("DeliveryBoy.xml");
                root = doc.DocumentElement;
                root.AppendChild(p);
                doc.Save("DeliveryBoy.xml");
                ////////////////////////////////////////////////////////////////////////////////////

                p = doc.CreateElement("Boy");
                node = doc.CreateElement("Name");

                node.InnerText = "fosh";
                p.AppendChild(node);

                node = doc.CreateElement("ID");
                node.InnerText = "16";
                p.AppendChild(node);

                node = doc.CreateElement("area");
                node.InnerText = "Ramses";
                p.AppendChild(node);

                node = doc.CreateElement("zib_code");
                node.InnerText = "15";
                p.AppendChild(node);

                node = doc.CreateElement("count_order");
                node.InnerText = Convert.ToString(order_counter);
                p.AppendChild(node);

                node = doc.CreateElement("order_time");
                node.InnerText = ORDER_TIME;
                p.AppendChild(node);


                node = doc.CreateElement("Date");
                node.InnerText = "0/0/0";
                p.AppendChild(node);

                node = doc.CreateElement("Day");
                node.InnerText = "0";
                p.AppendChild(node);

                doc.Load("DeliveryBoy.xml");
                root = doc.DocumentElement;
                root.AppendChild(p);
                doc.Save("DeliveryBoy.xml");
                ////////////////////////////////////////////////////////////////////////////////////

                p = doc.CreateElement("Boy");
                node = doc.CreateElement("Name");

                node.InnerText = "lplp";
                p.AppendChild(node);

                node = doc.CreateElement("ID");
                node.InnerText = "17";
                p.AppendChild(node);

                node = doc.CreateElement("area");
                node.InnerText = "Tahrir";
                p.AppendChild(node);

                node = doc.CreateElement("zib_code");
                node.InnerText = "16";
                p.AppendChild(node);

                node = doc.CreateElement("count_order");
                node.InnerText = Convert.ToString(order_counter);
                p.AppendChild(node);

                node = doc.CreateElement("order_time");
                node.InnerText = ORDER_TIME;
                p.AppendChild(node);


                node = doc.CreateElement("Date");
                node.InnerText = "0/0/0";
                p.AppendChild(node);

                node = doc.CreateElement("Day");
                node.InnerText = "0";
                p.AppendChild(node);

                doc.Load("DeliveryBoy.xml");
                root = doc.DocumentElement;
                root.AppendChild(p);
                doc.Save("DeliveryBoy.xml");
                ////////////////////////////////////////////////////////////////////////////////////

                p = doc.CreateElement("Boy");
                node = doc.CreateElement("Name");

                node.InnerText = "Okal";
                p.AppendChild(node);

                node = doc.CreateElement("ID");
                node.InnerText = "18";
                p.AppendChild(node);

                node = doc.CreateElement("area");
                node.InnerText = "Zamalek";
                p.AppendChild(node);

                node = doc.CreateElement("zib_code");
                node.InnerText = "17";
                p.AppendChild(node);

                node = doc.CreateElement("count_order");
                node.InnerText = Convert.ToString(order_counter);
                p.AppendChild(node);

                node = doc.CreateElement("order_time");
                node.InnerText = ORDER_TIME;
                p.AppendChild(node);


                node = doc.CreateElement("Date");
                node.InnerText = "0/0/0";
                p.AppendChild(node);

                node = doc.CreateElement("Day");
                node.InnerText = "0";
                p.AppendChild(node);

                doc.Load("DeliveryBoy.xml");
                root = doc.DocumentElement;
                root.AppendChild(p);
                doc.Save("DeliveryBoy.xml");
            }

        }

    }
}
