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

namespace naloga2
{
    public partial class dodajanjeSoftware : Form
    {
        public dodajanjeSoftware()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string itemID = textBox1.Text;
            string itemName = textBox2.Text;
            double price;
            int sizeinmb = Convert.ToInt32(textBox5.Text);
            string licensekey = textBox4.Text;
            Double.TryParse(textBox3.Text, out price);
            


            SoftwareItem newItem = new SoftwareItem(itemID, itemName, price, licensekey, sizeinmb);

            itemsBaza db = new itemsBaza();
            db.SaveSofwareItem(newItem);

            MessageBox.Show("Izdelek dodan");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            this.Hide();
            Form2.Show();
        }
    }
}
