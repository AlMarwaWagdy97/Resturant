using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
namespace WindowsFormsApp3
{
   
   public class Costomer
    {
      

     
        public string Name { get; set; }
        
        public string Phone { get; set; }
     
        public string Password { get; set; }
    
        public string Region { get; set; }
    
        public string Address { get; set; }

        public int num_of_order { get; set; }

       /*
       public Costomer (string name,string phonee,string pass,string region,string address)
        {
            Name = name;
            Phone = phonee;
            Password = pass;
            Region = region;
            Address = address;
        }
        */ 
    }
}
