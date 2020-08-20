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
namespace WindowsFormsApp3
{
    public partial class Menu : Form
    {
        public class pass
        {
            public string name;
            public string quant;
            public string price;
            public pass(string Name,string Quant,string Price)
            {
                name = Name;
               quant= Quant;
                price=Price;
            }
        }
        public Menu(string ph)
        {          
            InitializeComponent();
            passPhone.Text = ph;
        }
       
       public static List<string> item_name = new List<string>();
       public static List<int> item_quant = new List<int>();
       public static List<float> item_price = new List<float>();
       public static float totCost = 0;
       public static int totQuant = 0;
       public string area2="";

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void appetizers_Click(object sender, EventArgs e)
        {
           //button colors
            appetizers.BackColor = Color.Red;
            meals.BackColor = DefaultBackColor;
            desserts.BackColor = DefaultBackColor;
            drinks.BackColor = DefaultBackColor;
            view_chart.BackColor = DefaultBackColor;

            //labels change
            label21.Text = "French Fries";
            item1price.Text = "10.00";
            label19.Text = "Chicken Wings";
            item2price.Text = "12.00";
            label18.Text = "Potato Wedges";
            item3price.Text = "10.00";
            //images change
            pictureBox20.Image = Image.FromFile("C:\\Users\\Doaa\\Desktop\\FCIS\\2nd year\\Second term\\File\\project\\images\\French-Fries.jpg");
            pictureBox19.Image = Image.FromFile("C:\\Users\\Doaa\\Desktop\\FCIS\\2nd year\\Second term\\File\\project\\images\\chicken-wings.jpg");
            pictureBox18.Image = Image.FromFile("C:\\Users\\Doaa\\Desktop\\FCIS\\2nd year\\Second term\\File\\project\\images\\potato-wedges.jpg");

            pictureBox20.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox19.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox18.SizeMode = PictureBoxSizeMode.StretchImage;


            //set quantity value
            if (item_name.Contains(label21.Text))
                textBox20.Text = (item_quant[item_name.IndexOf(label21.Text)]).ToString();
            else if (!item_name.Contains(label21.Text))
                textBox20.Text = "0";

            if (item_name.Contains(label19.Text))
            textBox19.Text = (item_quant[item_name.IndexOf(label19.Text)]).ToString();
            else if (!item_name.Contains(label19.Text))
                textBox19.Text = "0";

            if (item_name.Contains(label18.Text))
            textBox18.Text = (item_quant[item_name.IndexOf(label18.Text)]).ToString();
            else if (!item_name.Contains(label18.Text))
                textBox18.Text = "0";

        }

        private void meals_Click(object sender, EventArgs e)
        {
            
            //button colors
            appetizers.BackColor = DefaultBackColor;
            meals.BackColor = Color.Red;
            desserts.BackColor = DefaultBackColor;
            drinks.BackColor = DefaultBackColor;
            view_chart.BackColor = DefaultBackColor;

            //labels text change
            label21.Text = "Pizza";
            item1price.Text = "95.00";
            label19.Text = "Sandwich";
            item2price.Text = "20.00";
            label18.Text = "Pasta";
            item3price.Text = "35.00";

            //images change
            pictureBox20.Image = Image.FromFile("C:\\Users\\Doaa\\Desktop\\FCIS\\2nd year\\Second term\\File\\project\\images\\pizza.jpg");
            pictureBox19.Image = Image.FromFile("C:\\Users\\Doaa\\Desktop\\FCIS\\2nd year\\Second term\\File\\project\\images\\sandwich.jpg");
            pictureBox18.Image = Image.FromFile("C:\\Users\\Doaa\\Desktop\\FCIS\\2nd year\\Second term\\File\\project\\images\\pasta.jpeg");

            pictureBox20.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox19.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox18.SizeMode = PictureBoxSizeMode.StretchImage;


            //set quantity value
            if (item_name.Contains(label21.Text))
                textBox20.Text = (item_quant[item_name.IndexOf(label21.Text)]).ToString();
            else if (!item_name.Contains(label21.Text))
                textBox20.Text = "0";

            if (item_name.Contains(label19.Text))
                textBox19.Text = (item_quant[item_name.IndexOf(label19.Text)]).ToString();
            else if (!item_name.Contains(label19.Text))
                textBox19.Text = "0";

            if (item_name.Contains(label18.Text))
                textBox18.Text = (item_quant[item_name.IndexOf(label18.Text)]).ToString();
            else if (!item_name.Contains(label18.Text))
                textBox18.Text = "0";

        }

        private void desserts_Click(object sender, EventArgs e)
        {
           

            appetizers.BackColor = DefaultBackColor;
            meals.BackColor = DefaultBackColor;
            desserts.BackColor = Color.Red;
            drinks.BackColor = DefaultBackColor;
            view_chart.BackColor = DefaultBackColor;

            label21.Text = "Cheese cake";
            item1price.Text = "25.00";
            label19.Text = "Sundae";
            item2price.Text = "13.00";
            label18.Text = "ice cream";
            item3price.Text = "10.00";

            pictureBox20.Image = Image.FromFile("C:\\Users\\Doaa\\Desktop\\FCIS\\2nd year\\Second term\\File\\project\\images\\cheesecake.jpg");
            pictureBox19.Image = Image.FromFile("C:\\Users\\Doaa\\Desktop\\FCIS\\2nd year\\Second term\\File\\project\\images\\Sundae.png");
            pictureBox18.Image = Image.FromFile("C:\\Users\\Doaa\\Desktop\\FCIS\\2nd year\\Second term\\File\\project\\images\\icecream.jpg");

            pictureBox20.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox19.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox18.SizeMode = PictureBoxSizeMode.StretchImage;

            if (item_name.Contains(label21.Text))
                textBox20.Text = (item_quant[item_name.IndexOf(label21.Text)]).ToString();
            else if (!item_name.Contains(label21.Text))
                textBox20.Text = "0";

            if (item_name.Contains(label19.Text))
                textBox19.Text = (item_quant[item_name.IndexOf(label19.Text)]).ToString();
            else if (!item_name.Contains(label19.Text))
                textBox19.Text = "0";

            if (item_name.Contains(label18.Text))
                textBox18.Text = (item_quant[item_name.IndexOf(label18.Text)]).ToString();
            else if (!item_name.Contains(label18.Text))
                textBox18.Text = "0";

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        { 
            textBox20.Text = "0";
            textBox19.Text = "0";
            textBox18.Text = "0";
            Chart.Visible = false;

            //button colors
            appetizers.BackColor = Color.Red;
            meals.BackColor = DefaultBackColor;
            desserts.BackColor = DefaultBackColor;
            drinks.BackColor = DefaultBackColor;
            view_chart.BackColor = DefaultBackColor;

            //labels change
            label21.Text = "French Fries";
            item1price.Text = "10.00";
            label19.Text = "Chicken Wings";
            item2price.Text = "12.00";
            label18.Text = "Potato Wedges";
            item3price.Text = "10.00";
            //images change
           // pictureBox20.Image = Image.FromFile("C:\\Users\\Doaa\\Desktop\\FCIS\\2nd year\\Second term\\File\\project\\images\\French-Fries.jpg");
            //pictureBox19.Image = Image.FromFile("C:\\Users\\Doaa\\Desktop\\FCIS\\2nd year\\Second term\\File\\project\\images\\chicken-wings.jpg");
            //pictureBox18.Image = Image.FromFile("C:\\Users\\Doaa\\Desktop\\FCIS\\2nd year\\Second term\\File\\project\\images\\potato-wedges.jpg");

            pictureBox20.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox19.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox18.SizeMode = PictureBoxSizeMode.StretchImage;


            //set quantity value
            if (item_name.Contains(label21.Text))
                textBox20.Text = (item_quant[item_name.IndexOf(label21.Text)]).ToString();
            else if (!item_name.Contains(label21.Text))
                textBox20.Text = "0";

            if (item_name.Contains(label19.Text))
                textBox19.Text = (item_quant[item_name.IndexOf(label19.Text)]).ToString();
            else if (!item_name.Contains(label19.Text))
                textBox19.Text = "0";

            if (item_name.Contains(label18.Text))
                textBox18.Text = (item_quant[item_name.IndexOf(label18.Text)]).ToString();
            else if (!item_name.Contains(label18.Text))
                textBox18.Text = "0";

            
        }

        private void drinks_Click(object sender, EventArgs e)
        {
         
            appetizers.BackColor = DefaultBackColor;
            meals.BackColor = DefaultBackColor;
            desserts.BackColor = DefaultBackColor;
            drinks.BackColor = Color.Red;
            view_chart.BackColor = DefaultBackColor;

            label21.Text = "Soft Drinks";
            item1price.Text = "5.00";
            label19.Text = "Water";
            item2price.Text = "3.00";
            label18.Text = "Smoothie";
            item3price.Text = "15.00";

            pictureBox20.Image = Image.FromFile("C:\\Users\\Doaa\\Desktop\\FCIS\\2nd year\\Second term\\File\\project\\images\\soft-drinks.jpg");
            pictureBox19.Image = Image.FromFile("C:\\Users\\Doaa\\Desktop\\FCIS\\2nd year\\Second term\\File\\project\\images\\water.jpg");
            pictureBox18.Image = Image.FromFile("C:\\Users\\Doaa\\Desktop\\FCIS\\2nd year\\Second term\\File\\project\\images\\smoothie.jpg");

            pictureBox20.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox19.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox18.SizeMode = PictureBoxSizeMode.StretchImage;


            if (item_name.Contains(label21.Text))
                textBox20.Text = (item_quant[item_name.IndexOf(label21.Text)]).ToString();
            else if (!item_name.Contains(label21.Text))
                textBox20.Text = "0";

            if (item_name.Contains(label19.Text))
                textBox19.Text = (item_quant[item_name.IndexOf(label19.Text)]).ToString();
            else if (!item_name.Contains(label19.Text))
                textBox19.Text = "0";

            if (item_name.Contains(label18.Text))
                textBox18.Text = (item_quant[item_name.IndexOf(label18.Text)]).ToString();
            else if (!item_name.Contains(label18.Text))
                textBox18.Text = "0";

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            //string s = string.Format("{0}", Cart);

            /*var res = quant.Concat(price).GroupBy(d => k.key).ToDictionary(d => d.Key, d => d.First().Value);

            var lines = quant.Select(kv => kv.Key + ": " + kv.Value.ToString());
            var lines2 = price.Select(k => k.Value.ToString());
            var s = lines+" "+lines2;
            bill.Text = string.Join(Environment.NewLine, s);*/

            foreach (var k in item_name)
            {
                /*item.Text += string.Format("{0}", item_name);
                quant.Text += string.Format("{0}", item_quant);
                price.Text += string.Format("{0}", item_price);*/
                item.Text = string.Join(Environment.NewLine, item_name);
                quant.Text = string.Join(Environment.NewLine, item_quant);
                price.Text = string.Join(Environment.NewLine, item_price);

            }


        }

        private void button40_Click(object sender, EventArgs e)
        {

            if (item_name.Contains(label21.Text))
            {
                int indI = item_name.IndexOf(label21.Text);
                item_quant[indI]++;
                textBox20.Text = item_quant[indI].ToString();
             //   MessageBox.Show(item_quant[indI] + " " + item1price.Text);
                item_price[indI] = item_quant[indI] * float.Parse(item1price.Text);
                

            }
            else
            {
                item_name.Add(label21.Text);
                item_quant.Add(1);
                item_price.Add(float.Parse(item1price.Text));
                textBox20.Text = "1";
                //price.Add(label21.Text,float.Parse(item1price.Text));
            }
            totCost += float.Parse(item1price.Text);
            totQuant++;
        }

        private void button41_Click(object sender, EventArgs e)
        {
           int indI = item_name.IndexOf(label21.Text);
            item_quant[indI]--;
            if(item_quant[indI]<1)
            {
                item_quant.RemoveAt(indI);
                item_price.RemoveAt(indI);
                item_name.Remove(label21.Text);
            }
            textBox20.Text = item_quant[indI].ToString();
            if (item_quant[indI] > -1)
            {
                totCost -= float.Parse(item1price.Text);
                totQuant--;
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {

            if (item_name.Contains(label19.Text))
            {
                int indI = item_name.IndexOf(label19.Text);
                item_quant[indI]++;
                textBox19.Text = item_quant[indI].ToString();
                item_price[indI] = item_quant[indI] * float.Parse(item2price.Text);
               // MessageBox.Show(item_quant[indI] + " " + item1price.Text);


            }
            else
            {
                item_name.Add(label19.Text);
                item_quant.Add(1);
                item_price.Add(float.Parse(item2price.Text));
                textBox19.Text = "1";
            }
            totCost += float.Parse(item2price.Text);
            totQuant++;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            int indI = item_name.IndexOf(label19.Text);
            item_quant[indI]--;
            if (item_quant[indI] < 1)
            {
                item_quant.RemoveAt(indI);
                item_price.RemoveAt(indI);
                item_name.Remove(label19.Text);
            }
            textBox19.Text = item_quant[indI].ToString();
            if (item_quant[indI] > -1)
            {
                totCost -= float.Parse(item2price.Text);
                totQuant--;
            }

        }

        private void button36_Click(object sender, EventArgs e)
        {

            if (item_name.Contains(label18.Text))
            {
                int indI = item_name.IndexOf(label18.Text);
                item_quant[indI]++;
                textBox18.Text = item_quant[indI].ToString();
                item_price[indI] = item_quant[indI] * float.Parse(item3price.Text);

            }
            else
            {
                item_name.Add(label18.Text);
                item_quant.Add(1);
                item_price.Add(float.Parse(item3price.Text));
                textBox18.Text = "1";
            }
            totCost += float.Parse(item3price.Text);
            totQuant++;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            int indI = item_name.IndexOf(label18.Text);
            item_quant[indI]--;
            if (item_quant[indI] < 1)
            {
                item_quant.RemoveAt(indI);
                item_price.RemoveAt(indI);
                item_name.Remove(label18.Text);
            }
            textBox18.Text = item_quant[indI].ToString();
            if (item_quant[indI] > -1)
            {
                totCost -= float.Parse(item3price.Text);
                totQuant--;
            }
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
          /*  var lines = quant.Select(kv => kv.Key + ": " + kv.Value.ToString());
            bill.Text = string.Join(Environment.NewLine, lines);
            */
          
            /*foreach(var k in item_name)
           item.Text = string.Format("{0}{1}{2}", item_name , item_quant , item_price);*/

            foreach (var k in item_name)
            {
                /*item.Text += string.Format("{0}", item_name);
                quant.Text += string.Format("{0}", item_quant);
                price.Text += string.Format("{0}", item_price);*/
                item.Text = string.Join(Environment.NewLine, item_name);
                quant.Text = string.Join(Environment.NewLine, item_quant);
                price.Text = string.Join(Environment.NewLine, item_price);

            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            /*var lines = quant.Select(kv => kv.Key + ": " + kv.Value.ToString());
            bill.Text = string.Join(Environment.NewLine, lines);
            */
           
             
           /*foreach(var k in item_name )
            item.Text+=string.Format("{0}{1}{2}", item_name , item_quant , item_price );*/
            foreach (var k in item_name)
            {
                /*item.Text += string.Format("{0}", item_name);
                quant.Text += string.Format("{0}", item_quant);
                price.Text += string.Format("{0}", item_price);*/
                item.Text = string.Join(Environment.NewLine, item_name);
                quant.Text = string.Join(Environment.NewLine, item_quant);
                price.Text = string.Join(Environment.NewLine, item_price);

            }
        }

        private void quant_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (item_name.Count() == 0)
            {
                MessageBox.Show("Your Cart is empty , Add items to it");

            }
            else
            {
                CheckOut ch = new CheckOut(item.Text, quant.Text, price.Text, totCost, totQuant, passPhone.Text);
                this.Hide();
                ch.Show();
            }
        }
        public void F()
        {
            string area = ChosenArea.Text;
            string d1 = beginDate.Value.ToShortDateString();
            string d2 = endDate.Value.ToShortDateString();
           
            Dictionary<DateTime, int> c = new Dictionary<DateTime, int>();
            XmlDocument doc = new XmlDocument();
            doc.Load("Delieveries.xml");
            XmlNodeList l = doc.GetElementsByTagName("Delievery");


            for (int i = 0; i < l.Count; ++i)
            {
                XmlNodeList ch = l[i].ChildNodes;
                string a = ch[0].InnerText;
                string dt = ch[1].InnerText;
                DateTime d = Convert.ToDateTime(ch[1].InnerText);
                int o = Int32.Parse(ch[2].InnerText);
                if (a == area)
                {
                    if (dt == d1 || dt == d2 || (d.Ticks > Convert.ToDateTime(d1).Ticks && d.Ticks < Convert.ToDateTime(d2).Ticks))
                    {
                        c.Add(d, o);
                    }
                }
            }
            for (DateTime i = Convert.ToDateTime(d1); i.Ticks < Convert.ToDateTime(d2).Ticks; i = i.AddDays(1))
            {
                if (!c.ContainsKey(i))
                    c.Add(i, 0);
            }
            var lis = c.Keys.ToList();
            lis.Sort();

            if (ChosenArea.Text != "")
            {

                if (area2 == "")
                {
                    for (int i = 0; i < lis.Count; ++i)
                    {
                        this.AreaChart.Series["Number of Orders"].Points.AddXY(lis[i].ToShortDateString(), c[lis[i]]);
                    }
                }
                else if (area2 != area)
                {
                    // AreaChart.Series.Clear();
                    AreaChart.Series.Clear();
                    AreaChart.Series.Add("Number of Orders");
                    for (int i = 0; i < lis.Count; ++i)
                    {
                        this.AreaChart.Series["Number of Orders"].Points.AddXY(lis[i].ToShortDateString(), c[lis[i]]);
                    }
                }
                area2 = area;

            }
            ChosenArea.ResetText();  

        }
        private void item_TextChanged(object sender, EventArgs e)
        {

        }

        private void view_chart_Click(object sender, EventArgs e)
        {
            Chart.Show();
            appetizers.BackColor = DefaultBackColor;
            meals.BackColor = DefaultBackColor;
            desserts.BackColor = DefaultBackColor;
            drinks.BackColor = DefaultBackColor;
            view_chart.BackColor = Color.Red;
        }

        private void ShowChart_Click(object sender, EventArgs e)
        {
           // AreaChart.Series.Clear();
            string area = ChosenArea.Text;
            string d1 = beginDate.Value.ToShortDateString();
            string d2 = endDate.Value.ToShortDateString();
         //   bool f = true;
            Dictionary<DateTime , int> c = new Dictionary<DateTime,int>();
            XmlDocument doc = new XmlDocument();
            doc.Load("Delieveries.xml");
            XmlNodeList l = doc.GetElementsByTagName("Delievery");


            for (int i = 0; i < l.Count; ++i )
            {
                XmlNodeList ch = l[i].ChildNodes;
                string a = ch[0].InnerText;
                string dt = ch[1].InnerText;
                DateTime d = Convert.ToDateTime(ch[1].InnerText);
                int o = Int32.Parse(ch[2].InnerText);
                if (a == area)
                {
                    if (dt == d1 || dt == d2 || (d.Ticks > Convert.ToDateTime(d1).Ticks && d.Ticks < Convert.ToDateTime(d2).Ticks))
                    {
                        c.Add(d, o);
                    }
                }
            }
            for(DateTime i = Convert.ToDateTime(d1) ; i.Ticks<Convert.ToDateTime(d2).Ticks ; i=i.AddDays(1))
            {
                if(!c.ContainsKey(i))
                    c.Add(i,0);
            }
            var lis = c.Keys.ToList();
            lis.Sort();

            if (ChosenArea.Text != "")
            {

                if (area2 =="")
                {
                    for (int i = 0; i < lis.Count; ++i)
                    {
                        this.AreaChart.Series["Number of Orders"].Points.AddXY(lis[i].ToShortDateString(), c[lis[i]]);
                    }
                }
                else if (area2 != area)
                {
                   // AreaChart.Series.Clear();
                   AreaChart.Series.Clear();
                    AreaChart.Series.Add("Number of Orders");
                    for (int i = 0; i < lis.Count; ++i)
                    {
                        this.AreaChart.Series["Number of Orders"].Points.AddXY(lis[i].ToShortDateString(), c[lis[i]]);
                    }
                }
                area2 = area;
                
            }
            ChosenArea.ResetText();  
        }

        private void back_Click(object sender, EventArgs e)
        {
            
            Chart.Visible = false;
            AreaChart.Series.Clear();
            //AreaChart.Series.Clear();
           // AreaChart.Series.Add("Number of Orders");
           // AreaChart.Visible = false;
           
            //Chart.ResetText();
        

        }

        private void ChosenArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            AreaChart.ResetText();
        }

        private void beginDate_ValueChanged(object sender, EventArgs e)
        {
         //   AreaChart.Series.Clear(); ;

        }

        private void endDate_ValueChanged(object sender, EventArgs e)
        {
           // AreaChart.Series.Clear(); ;
        }

        private void AreaChart_Click(object sender, EventArgs e)
        {

        }
    }
}
