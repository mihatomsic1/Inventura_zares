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
    public partial class dodajanjeHardware : Form
    {
        public dodajanjeHardware()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string itemID = textBox1.Text;
            string itemName = textBox2.Text;
            double price;
            double Weight;
            Double.TryParse(textBox3.Text, out price);
            Double.TryParse(textBox4.Text, out Weight);


            HardwareItem newItem = new HardwareItem(itemID, itemName, price, Weight);

            itemsBaza db = new itemsBaza();
            db.SaveHardwareItem(newItem);

            MessageBox.Show("Izdelek dodan");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            this.Hide();
            Form2.Show();
        }
    }
}
