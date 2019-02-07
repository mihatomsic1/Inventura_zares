using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using items;



namespace items
{
    public class itemsBaza
    {

        private SQLiteConnection con;


        public itemsBaza()
        {

            con = new SQLiteConnection(@"data source=itemsBaza.db");
            con.Open();
        }

        public void SaveItem(Item itemToSave)
        {

            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "INSERT INTO items (itemID, itemName, price, type) VALUES ('" + itemToSave.itemID + "','" + itemToSave.itemName + "', '" + itemToSave.price + "';)";

                com.ExecuteNonQuery();
                com.Dispose();


            }

        }
        
        public void SaveHardwareItem(HardwareItem hardwareItemToSave)
        {

            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "INSERT INTO hardware_items (itemID, itemName, price, weight) VALUES ('" + hardwareItemToSave.itemID + "','" + hardwareItemToSave.itemName + "', '" + hardwareItemToSave.price + "', '" + hardwareItemToSave.Weight + "')";

                com.ExecuteNonQuery();
                com.Dispose();


            }
        }

        public void SaveComputer(Computer computerToSave)
        {

            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "INSERT INTO computer_items (itemID, itemName, price, NoOfCores, AmountOfRam, HDDSize, weight) VALUES ('" + computerToSave.itemID + "','" + computerToSave.itemName + "', '" + computerToSave.price + "', '" + computerToSave.NoOfCores + "', '" + computerToSave.AmountOfRAM + "', '" + computerToSave.HDDSize + "', '" + computerToSave.Weight + "')";

                com.ExecuteNonQuery();
                com.Dispose();


            }
        }

        public void SaveSofwareItem(SoftwareItem softwareitemToSave)
        {
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "INSERT INTO software_items (itemID, itemName, price, licensekey, sizeinMB) VALUES ('" + softwareitemToSave.itemID + "','" + softwareitemToSave.itemName + "', '" + softwareitemToSave.price + "', '" + softwareitemToSave.Licensekey + "', '" + softwareitemToSave.SizeInMB + "')";

                com.ExecuteNonQuery();
                com.Dispose();


            }
        }

        public void SaveMonitor(Monitor MonitorToSave)
        {
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "INSERT INTO monitor_items (itemID, itemName, price, resolution, monitortype, weight) VALUES ('" + MonitorToSave.itemID + "','" + MonitorToSave.itemName + "', '" + MonitorToSave.price + "', '" + MonitorToSave.Resolution + "', '" + MonitorToSave.MonitorType + "', '" + MonitorToSave.Weight + "')";

                com.ExecuteNonQuery();
                com.Dispose();


            }
        }

        public void DeleteItem(Item itemToDelete)
        {
            
            itemsBaza db1 = new itemsBaza();
            db1.ReadItems();
     
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "DELETE FROM items WHERE (itemID ='"+itemToDelete.itemID+"');";

                com.ExecuteNonQuery();
                com.Dispose();


            }

          

        }

        public void DeleteHardwareItem(HardwareItem hardwareitemToDelete)
        {

            itemsBaza db1 = new itemsBaza();
            db1.ReadItems();

            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "DELETE FROM hardware_items WHERE (itemID ='" + hardwareitemToDelete.itemID + "');";

                com.ExecuteNonQuery();
                com.Dispose();


            }
        }

        public void DeleteSoftwareItem(SoftwareItem softwareItemToDelete)
        {

            itemsBaza db1 = new itemsBaza();
            db1.ReadItems();

            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "DELETE FROM software_items WHERE (itemID ='" + softwareItemToDelete.itemID + "');";

                com.ExecuteNonQuery();
                com.Dispose();


            }
        }

        public void DeleteComputer(Computer computerToDelete)
        {

            itemsBaza db1 = new itemsBaza();
            db1.ReadItems();

            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "DELETE FROM computer_items WHERE (itemID ='" + computerToDelete.itemID + "');";

                com.ExecuteNonQuery();
                com.Dispose();


            }
        }

        public void DeleteMonitor(Monitor monitorToDelete)
        {

            itemsBaza db1 = new itemsBaza();
            db1.ReadItems();

            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "DELETE FROM monitor_items WHERE (itemID ='" + monitorToDelete.itemID + "');";

                com.ExecuteNonQuery();
                com.Dispose();


            }
        }

        public List<Item> ReadItems()
        {
            List<Item> seznam = new List<Item>();
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "SELECT * FROM items";
                SQLiteDataReader reader = com.ExecuteReader();
                while(reader.Read())
                {
                    Item Item = new Item(Convert.ToString(reader.GetInt32(1)), reader.GetString(2), reader.GetDouble(3));
                    seznam.Add(Item);
                }
            }
            return seznam;
        }

        public void EditItem(Item itemToEdit)
        {
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "UPDATE items SET itemID = '" + itemToEdit.itemID + "', itemName = '"+itemToEdit.itemName+ "', price = '" + itemToEdit.price+ "' WHERE itemID = '"+itemToEdit.itemID+"' ;";
                com.ExecuteNonQuery();
            }
        }

        public void EditHardware(HardwareItem hardwareItem)
        {
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "UPDATE hardware_items SET itemID = '" + hardwareItem.itemID + "', itemName = '" + hardwareItem.itemName + "', price = '" + hardwareItem.price + "', weight = '" + hardwareItem.Weight + "' WHERE itemID = '" + hardwareItem.itemID + "' ;";
                com.ExecuteNonQuery();
            }
        }

        public void EditSoftware(SoftwareItem softwareItem)
        {
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "UPDATE software_items SET itemID = '" + softwareItem.itemID + "', itemName = '" + softwareItem.itemName + "', price = '" + softwareItem.price + "', licensekey = '" + softwareItem.Licensekey + "', sizeinMB = '" + softwareItem.SizeInMB + "' WHERE itemID = '" + softwareItem.itemID + "' ;";
                com.ExecuteNonQuery();
            }
        }

        public void EditComputer(Computer computer)
        {
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "UPDATE computer_items SET itemID = '" + computer.itemID + "', itemName = '" + computer.itemName + "', price = '" + computer.price + "', weight = '"+computer.Weight+ "', NoOfCores = '" + computer.NoOfCores + "', AmountOfRam = '" + computer.AmountOfRAM + "', HDDSize = '" + computer.HDDSize + "' WHERE itemID = '" + computer.itemID + "' ;";
                com.ExecuteNonQuery();
            }
        }

        public void EditMonitor(Monitor monitor)
        {
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "UPDATE monitor_items SET itemID = '" + monitor.itemID + "', itemName = '" + monitor.itemName + "', price = '" + monitor.price + "', weight = '" + monitor.Weight + "', resolution = '" + monitor.Resolution + "', monitortype = '" + monitor.MonitorType + "' WHERE itemID = '" + monitor.itemID + "' ;";
                com.ExecuteNonQuery();
            }
        }

        public List<HardwareItem> ReadItemsH()
        {
            List<HardwareItem> seznam = new List<HardwareItem>();
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "SELECT * FROM hardware_items";
                SQLiteDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    HardwareItem Item = new HardwareItem(Convert.ToString(reader.GetInt32(1)), reader.GetString(2), reader.GetDouble(3), reader.GetDouble(4));
                    seznam.Add(Item);
                }
            }
            return seznam;
        }

        public List<SoftwareItem> ReadItemsS()
        {
            List<SoftwareItem> seznam = new List<SoftwareItem>();
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "SELECT * FROM software_items";
                SQLiteDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    SoftwareItem Item = new SoftwareItem(Convert.ToString(reader.GetInt32(1)), reader.GetString(2), reader.GetDouble(3), reader.GetString(4), reader.GetInt32(5));
                    seznam.Add(Item);
                }
            }
            return seznam;
        }

        public List<Computer> ReadItemsC()
        {
            List<Computer> seznam = new List<Computer>();
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "SELECT * FROM computer_items";
                SQLiteDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Computer Item = new Computer(Convert.ToString(reader.GetInt32(1)), reader.GetString(2), reader.GetDouble(3), reader.GetDouble(4), reader.GetInt32(5), reader.GetDouble(6), reader.GetDouble(7));
                    seznam.Add(Item);
                }
            }
            return seznam;
        }

        public List<Monitor> ReadItemsM()
        {
            List<Monitor> seznam = new List<Monitor>();
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "SELECT * FROM monitor_items";
                SQLiteDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Monitor Item = new Monitor(Convert.ToString(reader.GetInt32(1)), reader.GetString(2), reader.GetDouble(3), reader.GetDouble(4), reader.GetString(5), reader.GetString(6));
                    seznam.Add(Item);
                }
            }
            return seznam;
        }

        


    }
}
