using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
namespace WindowsFormsApp3
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }
        List<Costomer> list = new List<Costomer>();
        private void home_Load(object sender, EventArgs e)
        {
          //DeliveryBoy d = new DeliveryBoy();
         // d.f();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  Dictionary<string, Costomer> dic = new Dictionary<string, Costomer>();
            Costomer c = new Costomer();
            c.Name = txtname.Text;
            c.Phone = txtphone.Text;
            c.Region = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            c.Address = txtadd.Text;
            c.Password = txtpass.Text;

            if (c.Name != "" && c.Phone != "" && c.Region != "" && c.Address != "" && c.Password != "")
            {
                // dic.Add(txtphone.Text, c);

                list.Add(c);

                if (!File.Exists("costomer.xml"))
                {
                    XmlSerializer x = new XmlSerializer(list.GetType());
                    FileStream file = new FileStream("costomer.xml", FileMode.OpenOrCreate);
                    x.Serialize(file, list);
                    file.Close();
                    txtname.Text = " ";
                    txtphone.Text = " ";
                    txtadd.Text = " ";
                    comboBox1.ResetText();
                    txtpass.Clear();
                    MessageBox.Show("Welcome");

                }
                else
                {

                    XmlDocument doc = new XmlDocument();
                    //     MessageBox.Show("ggggygtfds");

                    XmlElement cu = doc.CreateElement("Costomer");
                    ///////////////////Name/////////////////////////////////////////////////////
                    XmlElement node = doc.CreateElement("Name");
                    node.InnerText = c.Name;
                    cu.AppendChild(node);
                    /////////////////////////////////////////////////////////Phone//////////////////////////
                    node = doc.CreateElement("Phone");

                    bool fg = true;
                    doc.Load("costomer.xml");
                    XmlNodeList l = doc.GetElementsByTagName("Costomer");

                    for (int i = 0; i < l.Count; i++)
                    {

                        XmlNodeList ch = l[i].ChildNodes;
                        //    MessageBox.Show(ch[1].InnerText);
                        string v = ch[1].InnerText;
                        //  MessageBox.Show(v+"  "+txtphone.Text);
                        if (v == txtphone.Text)
                        {
                            MessageBox.Show("the phone is already Exsit");

                            txtphone.Text = " ";
                            fg = false;


                            break;
                        }
                    }
                    if (fg == true)
                    {

                        node.InnerText = c.Phone;
                        cu.AppendChild(node);

                        node = doc.CreateElement("Password");
                        node.InnerText = c.Password;
                        cu.AppendChild(node);

                        node = doc.CreateElement("Region");
                        node.InnerText = c.Region;
                        cu.AppendChild(node);

                        node = doc.CreateElement("Address");
                        node.InnerText = c.Address;
                        cu.AppendChild(node);

                        node = doc.CreateElement("num_of_order");
                        node.InnerText = "0";
                        cu.AppendChild(node);

                        doc.Load("costomer.xml");
                        XmlElement root = doc.DocumentElement;
                        root.AppendChild(cu);
                        doc.Save("costomer.xml");
                       /* txtname.Text = " ";
                        txtphone.Text = " ";
                        txtadd.Text = " ";
                        comboBox1.ResetText();
                        txtpass.Clear();
                        MessageBox.Show("Welcome");*/
                        Menu mm = new Menu(txtphone.Text);
                        this.Hide();
                        mm.Show();
                    }

                }

                
            }
            else
            {
                if (c.Name == "" && c.Address == "" && c.Password == "" && c.Phone == "" && c.Region == "")
                    MessageBox.Show("You Should Fill All Fields ", "Error...!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                else if (c.Name == "")
                    MessageBox.Show("You Should Enter The Name ", "Error...!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                else if (c.Phone == "")
                    MessageBox.Show("You Should Enter The Phone ", "Error...!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                else if (c.Password == "")
                    MessageBox.Show("You Should Enter The Password ", "Error...!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                else if (c.Region == "")
                    MessageBox.Show("You Should Enter The Region ", "Error...!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                else if (c.Address == "")
                    MessageBox.Show("You Should Enter The Address ", "Error...!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
            //    c.num_of_order++;
        }

        private void login_Click(object sender, EventArgs e)
        {

            XmlDocument doc = new XmlDocument();
            doc.Load("costomer.xml");
            XmlNodeList l = doc.GetElementsByTagName("Costomer");
            for (int i = 0; i < l.Count; i++)
            {
                XmlNodeList ch = l[i].ChildNodes;
                string phone = ch[1].InnerText;
                string password = ch[2].InnerText;
                //////////// int ordersnum = ch[5].InnerText;
                if (Uphone.Text == phone && Upassword.Text == password)
                {
                    Menu m = new Menu(Uphone.Text);
                    m.Show();
                    this.Hide();
                    break;
                }
                else if (Uphone.Text != phone)
                {
                    MessageBox.Show("Eroor Phone");
                }
                else if (Upassword.Text != password)
                {
                    MessageBox.Show("Eroor password");
                }
                if (Uphone.Text != phone && (Upassword.Text != password))

                    MessageBox.Show("Eroor Phone and Eroor password");
            }
            //////////////  MessageBox.Show(Convert.ToString(ordersnum));

        }

        private void register_Click(object sender, EventArgs e)
        {
            registerPanel.Visible = true;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtname.Text = " ";
            txtphone.Text = " ";
            txtadd.Text = " ";
            comboBox1.ResetText();
            txtpass.Clear();
            registerPanel.Visible = false;
            Upassword.Text = "";
            Uphone.Text = "";
        }

        private void password_Click(object sender, EventArgs e)
        {

        }
    }

}

