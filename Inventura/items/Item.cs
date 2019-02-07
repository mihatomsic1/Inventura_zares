using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace items
{
    public class Item
    {
        

        public string itemID { get; set; }
        public string itemName { get; set; }
        public double price { get; set; }
        

        public Item(string itemid, string itemname, double itemprice)
        {
            itemID = itemid;
            itemName = itemname;
            price = itemprice;
            
               
        }

        

        public override string ToString()
        {
            string stringToReturn;
            stringToReturn = itemID + " " + itemName + " " + price;
            return stringToReturn;
        }

    }

    public class HardwareItem : Item
    {
        public double Weight { get; set; }

        public HardwareItem(string itemid, string itemname, double itemprice, double weight) : base(itemid,itemname,itemprice)   
        {
            Weight = weight;
        }


        public override string ToString()
        {
            string ToReturn =  base.ToString();
            ToReturn = ToReturn + " " + Weight.ToString();
            return ToReturn;
        }
    }

    public class SoftwareItem : Item
    {
        public string Licensekey { get; set; }
        public int SizeInMB { get; set; }

        public SoftwareItem(string itemid, string itemname, double itemprice, string licensekey, int sizeinmb) : base(itemid,itemname,itemprice)   
        {
            Licensekey = licensekey;
            SizeInMB = sizeinmb;
        }
        public override string ToString()
        {
            string ToReturn = base.ToString();
            ToReturn = ToReturn + " " + Licensekey.ToString() + " " + SizeInMB.ToString();
            return ToReturn;
        }
    }

    public class Computer : HardwareItem
    {
        public int NoOfCores { get; set; }
        public double AmountOfRAM { get; set; }
        public double HDDSize { get; set; }


        public Computer(string itemid, string itemname, double itemprice, double weight, int noofcores, double amountofram, double hddsize) : base(itemid,itemname,itemprice, weight)
        {
            NoOfCores = noofcores;
            AmountOfRAM = amountofram;
            HDDSize = hddsize;

        }
         
        public override string ToString()
        {
            string ToReturn = base.ToString();
            ToReturn = ToReturn + " " + NoOfCores.ToString() + " " + AmountOfRAM.ToString() + " " + HDDSize.ToString();
            return ToReturn;
        }
    }

    public class Monitor : HardwareItem
    {
        public string Resolution { get; set; }
        public string MonitorType { get; set; }


        public Monitor(string itemid, string itemname, double itemprice, double weight, string resolution, string monitortype) : base(itemid,itemname,itemprice,weight)
        {
            Resolution = resolution;
            MonitorType = monitortype;

        }

        public override string ToString()
        {
            string ToReturn = base.ToString();
            ToReturn = ToReturn + " " + Resolution.ToString() + " " + MonitorType.ToString();
            return ToReturn;
        }
    }
}
