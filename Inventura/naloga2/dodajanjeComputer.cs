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
    public partial class dodajanjeComputer : Form
    {
        public dodajanjeComputer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string itemID = textBox1.Text;
            string itemName = textBox2.Text;
            double price;
            int noofcores = Convert.ToInt32(textBox4.Text);
            double amountofram;
            double hddsize;
            double weight;
            Double.TryParse(textBox3.Text, out price);
            Double.TryParse(textBox5.Text, out amountofram);
            Double.TryParse(textBox6.Text, out hddsize);
            Double.TryParse(textBox7.Text, out weight);


            Computer newItem = new Computer(itemID, itemName, price, weight, noofcores, amountofram, hddsize);

            itemsBaza db = new itemsBaza();
            db.SaveComputer(newItem);

            MessageBox.Show("Izdelek dodan");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            this.Hide();
            Form2.Show();
        }
    }
}
