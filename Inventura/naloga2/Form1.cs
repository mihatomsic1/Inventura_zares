using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using items;
using System.Data.SQLite;

namespace naloga2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Item newItem = new Item("jala", "corelli", 5);

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string itemID = nameID.Text;
            string itemName = nameItem.Text;
            double price;
            Double.TryParse(priceText.Text, out price);
            

            Item newItem = new Item(itemID, itemName, price);
            
            itemsBaza db = new itemsBaza();
            db.SaveItem(newItem);

            MessageBox.Show("Izdelek dodan");

            izdelkiCombo.Items.Clear();

            List<Item> seznam = new List<Item>();
            itemsBaza db1 = new itemsBaza();
            seznam = db1.ReadItems();

            foreach (Item item in seznam)
            {
                izdelkiCombo.Items.Add(item.ToString());

            }

            nameID.Text = "";
            nameItem.Text = "";
            priceText.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Item> seznam = new List<Item>();
            itemsBaza db = new itemsBaza();
            seznam = db.ReadItems();

            foreach (Item item  in  seznam)
            {
                izdelkiCombo.Items.Add(item.ToString());
               
            }


          
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string item = izdelkiCombo.SelectedItem.ToString();
            string[] split = item.Split(null);
            string itemID = split[0];

            Item delete = new Item(itemID, "", 0.0);
            itemsBaza db = new itemsBaza();
            db.DeleteItem(delete);
            izdelkiCombo.Text = "";
            MessageBox.Show("Izdelek uspešno odstranjen.");

            izdelkiCombo.Items.Clear();

            List<Item> seznam = new List<Item>();
            itemsBaza db1 = new itemsBaza();
            seznam = db1.ReadItems();

            foreach (Item item1 in seznam)
            {
                izdelkiCombo.Items.Add(item1.ToString());
           
            }

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Posodobitev Posodobitev = new Posodobitev();
            this.Hide();
            Posodobitev.Show();
        }
    }
}
