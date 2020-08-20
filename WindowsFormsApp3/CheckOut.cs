using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

namespace WindowsFormsApp3
{
    
    public partial class CheckOut : Form
    {
        public string day1, day2;
        public string ID;
        public CheckOut(string name,string quante,string pricee,float tC , int tQ , string ph)
        {
            InitializeComponent();
            item.Text = name;
            quant.Text = quante;
            price.Text = pricee;
            firstTotal.Text = tC.ToString();
            totQuant.Text = tQ.ToString();
            Phone.Text = ph;
        }
        
        List<string> ns = new List<string>();
        List<float> prices = new List<float>();
        List<int> quantities = new List<int>();
       /* public void setlists (List<string> n , List<float> p , List<int>q)
        {
            ns = n;
            prices = p;
            quantities = q;
        }*/

       /* List<string> names = new List<string>();
        List<float> prices = new List<float>();
        List<int> quantities = new List<int>();*/
       
        
        private void button2_Click(object sender, EventArgs e)
        {
            Menu m = new Menu(Phone.Text);
            this.Hide();
            m.Show();
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            
            Dtdate.Format = DateTimePickerFormat.Short;
            Dtdate.ShowUpDown = true;
            Dtime.Format = DateTimePickerFormat.Time;
            Dtime.ShowUpDown = true;
            //Discount for number of orders
            FinalCost.Text = firstTotal.Text;
            XmlDocument doc = new XmlDocument();
            doc.Load("costomer.xml");
            XmlNodeList l = doc.GetElementsByTagName("Costomer.xml");

            for (int i = 0; i < l.Count; i++)
            {
                XmlNodeList ch = l[i].ChildNodes;
                string ph = ch[1].InnerText;
                int nO = Int32.Parse(ch[5].InnerText);
                if (nO > 5)
                {
                    FinalCost.Text = (0.9 * Int32.Parse(FinalCost.Text)).ToString();
                    finalDisc.Text = (Int32.Parse(finalDisc.Text)+0.1).ToString();
                }
            }

            
            
            
        }
        
        private void quant_TextChanged(object sender, EventArgs e)
        {

        }

        private void item_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

  
            //Discount for days
            List<string> discountDays = new List<string>();
            discountDays.Add("4/25/2018");
            discountDays.Add("5/17/2018");
            discountDays.Add("6/15/2018");
            discountDays.Add("7/23/2018");
            discountDays.Add("8/22/2018");
           string x= Dtdate.Value.ToShortDateString();
            if (discountDays.Contains(x))
            {
                finalDisc.Text = "0.1";
                FinalCost.Text = (0.9 * Int32.Parse(firstTotal.Text)).ToString();
            }
            else
                FinalCost.Text = firstTotal.Text;
        }

        private void firstTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string test = Dtime.Value.ToShortTimeString();
            DateTime teime = Dtime.Value;
            if (teime.ToString("tt") == "AM")
            {
                MessageBox.Show("Resturant closed");
                return;
            }
            string date = Dtdate.Value.ToShortDateString();
            string area = check_addres.Text;
            int count_order = 1;

            if (!File.Exists("Delieveries.xml"))
            {
                XmlWriter writer = XmlWriter.Create("Delieveries.xml");
                writer.WriteStartDocument();
                writer.WriteStartElement("Table");
                writer.WriteAttributeString("Name", "Deliveries");

                writer.WriteStartElement("Delievery");

                writer.WriteStartElement("Area");
                writer.WriteString(area);
                writer.WriteEndElement();

                writer.WriteStartElement("Date");
                writer.WriteString(date);
                writer.WriteEndElement();

                writer.WriteStartElement("no_orders");
                writer.WriteString(count_order.ToString());
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
            }

            else
            {
                XmlDocument doc = new XmlDocument();
                XmlElement r = doc.CreateElement("Delievery");
                XmlElement node = doc.CreateElement("Area");
                node.InnerText = area;

                node = doc.CreateElement("Date");
                node.InnerText = date;

                doc.Load("Delieveries.xml");

                XmlNodeList list = doc.GetElementsByTagName("Delievery");
                bool found = false;
                for (int i = 0; i < list.Count; ++i)
                {
                    XmlNodeList ch = list[i].ChildNodes;
                    string ar = ch[0].InnerText;
                    string dt = ch[1].InnerText;

                    int c = 1;
                    int cnt = Int32.Parse(ch[2].InnerText);
                    if (ar == area && dt == date)
                    {
                        cnt = cnt + c;
                        ch[2].InnerText = cnt.ToString();
                        MessageBox.Show(cnt.ToString());
                        doc.Save("Delieveries.xml");
                        found = true;
                        break;
                    }

                }
                if (!found)
                {
                    node = doc.CreateElement("Area");
                    node.InnerText = area;
                    r.AppendChild(node);

                    node = doc.CreateElement("Date");
                    node.InnerText = date;
                    r.AppendChild(node);

                    node = doc.CreateElement("no_orders");
                    node.InnerText = "1";
                    r.AppendChild(node);

                    doc.Load("Delieveries.xml");
                    XmlElement root = doc.DocumentElement;
                    root.AppendChild(r);
                    doc.Save("Delieveries.xml");
                }


            }
            XmlDocument docc = new XmlDocument();

            XmlNodeList ll = docc.GetElementsByTagName("Costomer");
            docc.Load("costomer.xml");
            for (int i = 0; i < ll.Count; i++)
            {
                XmlNodeList ch = ll[i].ChildNodes;
                string phone = ch[1].InnerText;

                int order = int.Parse(ch[5].InnerText);
                if (phone == Phone.Text)
                {
                    order++;
                    ch[5].InnerText = order.ToString();
                    docc.Save("costomer.xml");
                }

            }


            string gettime = Convert.ToString(Dtime.Value.ToShortTimeString());
            string Region = this.check_addres.GetItemText(this.check_addres.SelectedItem);
            Dictionary<string, string> dec = new Dictionary<string, string>();
            XmlDocument docu = new XmlDocument();
            docu.Load("DeliveryBoy.xml");
            XmlNodeList l = docu.GetElementsByTagName("Boy");
            Dictionary<string, int> D = new Dictionary<string, int>();
            Dictionary<string, string> de = new Dictionary<string, string>();

            for (int i = 0; i < l.Count; i++)
            {
                XmlNodeList ch = l[i].ChildNodes;
                string areaa = ch[2].InnerText;
                string zip_code = ch[3].InnerText;
                string get_order = ch[5].InnerText;
                int counter_order = int.Parse(ch[4].InnerText);
                string id = ch[1].InnerText;
                if (!dec.ContainsKey(zip_code))
                    dec.Add(zip_code, area);
                if (Region == areaa)
                {
                    D.Add(id, counter_order);
                    de.Add(id, get_order);
                }
            }
            int counter = 0;
            for (int j = 0; j < de.Count; j++)
            {

                string s = Dtime.Value.ToShortTimeString();
                if (de.ElementAt(j).Value != s)
                    counter++;
            }

            if (counter > 1)
            {
                int min = D.ElementAt(0).Value;
                for (int i = 0; i < D.Count; i++)
                {
                    if (D.ElementAt(i).Value <= min)
                    {
                        min = Convert.ToInt16(D.ElementAt(i).Value);
                        ID = D.ElementAt(i).Key;
                    }
                }

                XmlNodeList h = docu.GetElementsByTagName("Boy");
                for (int i = 0; i < h.Count; i++)
                {

                    XmlNodeList ch = h[i].ChildNodes;
                 /*   if (ch[7].InnerText != Dtdate.Value.Day.ToString())
                    {
                        XmlNodeList em = docu.GetElementsByTagName("Date");
                        for (int j = 0; j < em.Count; j++)
                        {
                            em[j].InnerText = "0";
                        }
                        em = docu.GetElementsByTagName("order_time");
                        for (int j = 0; j < em.Count; j++)
                        {
                            em[j].InnerText = "00:00:00";
                        }
                        em = docu.GetElementsByTagName("Day");
                        for (int j = 0; j < em.Count; j++)
                        {
                            em[j].InnerText = "0";
                        }
                    }*/

                    string id = ch[1].InnerText;
                    string ordertime = ch[5].InnerText;
                    DateTime d2 = DateTime.Parse(ordertime);
                    int counter_order = int.Parse(ch[4].InnerText);
                    DateTime d = Dtime.Value;
                    if (id == ID)
                    {
                        day1 = Dtdate.Value.Day.ToString();
                        counter_order++;
                        if (TimeSpan.Compare(d.TimeOfDay, d2.TimeOfDay) != -1)
                        {
                            ch[4].InnerText = Convert.ToString(counter_order);
                            ch[5].InnerText = Dtime.Value.ToShortTimeString();
                            ch[6].InnerText = Dtdate.Value.ToShortDateString();
                            ch[7].InnerText = Dtdate.Value.Day.ToString();
                            //   MessageBox.Show(Convert.ToString(ch[4].InnerText));
                            check_addres.ResetText();
                            docu.Save("DeliveryBoy.xml");
                            D.Clear();
                            break;
                        }
                        else
                            MessageBox.Show("Erorrrrrrrrrrr");
                    }
                }
            
                day2 = day1;

            }
            else
            {
                bool fount = false;
                XmlNodeList lll = docu.GetElementsByTagName("Boy");
                for (int i = 0; i < lll.Count; i++)
                {
                    XmlNodeList ch = lll[i].ChildNodes;
                   /* if (ch[7].InnerText != Dtdate.Value.Day.ToString())
                    {
                        XmlNodeList em = docu.GetElementsByTagName("Date");
                        for (int j = 0; j < em.Count; j++)
                        {
                            em[j].InnerText = "0";
                        }
                        em = docu.GetElementsByTagName("order_time");
                        for (int j = 0; j < em.Count; j++)
                        {
                            em[j].InnerText = "00:00:00";
                        }
                        em = docu.GetElementsByTagName("Day");
                        for (int j = 0; j < em.Count; j++)
                        {
                            em[j].InnerText = "0";
                        }
                    }*/

                    string id = ch[1].InnerText;
                    string ordertime = ch[5].InnerText;
                    int counter_order = int.Parse(ch[4].InnerText);


                    if (ordertime != Dtime.Value.ToShortTimeString() && de.ContainsKey(id))
                    {
                        ch[6].InnerText = Dtdate.Value.ToShortDateString();
                        counter_order++;
                        ch[4].InnerText = Convert.ToString(counter_order);
                        ch[5].InnerText = Dtime.Value.ToShortTimeString();

                        //  ch[6].InnerText = Dtdate.Value.ToShortDateString();
                        ch[7].InnerText = Dtdate.Value.Day.ToString();
                        //   MessageBox.Show(Convert.ToString(ch[4].InnerText));
                        check_addres.ResetText();
                        docu.Save("DeliveryBoy.xml");
                        D.Clear();
                        fount = true;
                        break;

                    }
                    //ACSESS MINEMUM OREDER COUNT


                }
                    if(fount==false)
                    {
                        MessageBox.Show("Errrror");
                        
                    }
            }
            MessageBox.Show("ggggggggggg");

        }
                  

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
