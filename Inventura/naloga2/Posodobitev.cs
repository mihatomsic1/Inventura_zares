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
    public partial class Posodobitev : Form
    {
        public Posodobitev()
        {
            InitializeComponent();
        }

        private void Posodobitev_Load(object sender, EventArgs e)
        {
           
        }

       

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                List<HardwareItem> seznam = new List<HardwareItem>();
                itemsBaza db = new itemsBaza();
                seznam = db.ReadItemsH();

                foreach (HardwareItem item in seznam)
                {
                    listBox1.Items.Add(item.ToString());

                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {

                {
                    List<SoftwareItem> seznam = new List<SoftwareItem>();
                    itemsBaza db = new itemsBaza();
                    seznam = db.ReadItemsS();

                    foreach (SoftwareItem item in seznam)
                    {
                        listBox1.Items.Add(item.ToString());

                    }
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {

                {
                    List<Computer> seznam = new List<Computer>();
                    itemsBaza db = new itemsBaza();
                    seznam = db.ReadItemsC();

                    foreach (Computer item in seznam)
                    {
                        listBox1.Items.Add(item.ToString());

                    }
                }
            }
            else if (comboBox1.SelectedIndex == 3)
            {

                {
                    List<Monitor> seznam = new List<Monitor>();
                    itemsBaza db = new itemsBaza();
                    seznam = db.ReadItemsM();

                    foreach (Monitor item in seznam)
                    {
                        listBox1.Items.Add(item.ToString());

                    }
                }
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           


            if (comboBox1.SelectedIndex == 0)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;

                string item = listBox1.SelectedItem.ToString();
                string[] besede = item.Split(null);

                textBox1.Text = besede[0];
                textBox2.Text = besede[1];
                textBox3.Text = besede[2];
                textBox4.Text = besede[3];

                listBox1.Items.Clear();


            }

            else if (comboBox1.SelectedIndex == 1)
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;

                string item = listBox1.SelectedItem.ToString();
                string[] besede = item.Split(null);

                textBox23.Text = besede[0];
                textBox8.Text = besede[1];
                textBox7.Text = besede[2];
                textBox6.Text = besede[3];
                textBox5.Text = besede[4];

                listBox1.Items.Clear();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = true;
                groupBox4.Enabled = false;

                string item = listBox1.SelectedItem.ToString();
                string[] besede = item.Split(null);

                textBox16.Text = besede[0];
                textBox15.Text = besede[1];
                textBox14.Text = besede[2];
                textBox13.Text = besede[4];
                textBox12.Text = besede[5];
                textBox11.Text = besede[6];
                textBox10.Text = besede[3];

                listBox1.Items.Clear();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                groupBox4.Enabled = true;

                string item = listBox1.SelectedItem.ToString();
                string[] besede = item.Split(null);

                textBox22.Text = besede[0];
                textBox21.Text = besede[1];
                textBox20.Text = besede[2];
                textBox17.Text = besede[3];
                textBox19.Text = besede[4];
                textBox18.Text = besede[5];

                listBox1.Items.Clear();

            }



        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string itemID = textBox1.Text;
            string itemName = textBox2.Text;
            double price;
            double Weight;
            Double.TryParse(textBox3.Text, out price);
            Double.TryParse(textBox4.Text, out Weight);

            HardwareItem hardwareItem = new HardwareItem(itemID, itemName, price, Weight);

            itemsBaza db = new itemsBaza();
            db.EditHardware(hardwareItem);

            MessageBox.Show("Izdelek urejen");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string itemID = textBox23.Text;
            string itemName = textBox8.Text;
            double price;        
            Double.TryParse(textBox7.Text, out price);
            string licensekey = textBox6.Text;
            int sizeinMB = Convert.ToInt32(textBox5.Text);


            SoftwareItem softwareItem = new SoftwareItem(itemID, itemName, price, licensekey, sizeinMB);

            itemsBaza db = new itemsBaza();
            db.EditSoftware(softwareItem);

            MessageBox.Show("Izdelek urejen");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string itemID = textBox16.Text;
            string itemName = textBox15.Text;
            double price;
            double weight;
            Double.TryParse(textBox14.Text, out price);
            Double.TryParse(textBox10.Text, out weight);
            int noofcores = Convert.ToInt32(textBox13.Text);
            double amountofram; 
            double hddsize;
            Double.TryParse(textBox12.Text, out amountofram);
            Double.TryParse(textBox11.Text, out hddsize);


            Computer computer = new Computer(itemID, itemName, price, weight, noofcores, amountofram, hddsize);

            itemsBaza db = new itemsBaza();
            db.EditComputer(computer);

            MessageBox.Show("Izdelek urejen");

            textBox16.Text = "";
            textBox15.Text = "";
            textBox14.Text = "";
            textBox13.Text = "";
            textBox12.Text = "";
            textBox11.Text = "";
            textBox10.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string itemID = textBox22.Text;
            string itemName = textBox21.Text;
            double price;
            double weight;
            Double.TryParse(textBox20.Text, out price);
            Double.TryParse(textBox17.Text, out weight);
            string resolution = textBox19.Text;
            string monitortype = textBox18.Text;

            Monitor monitor = new Monitor(itemID, itemName, price, weight, resolution, monitortype);

            itemsBaza db = new itemsBaza();
            db.EditMonitor(monitor);

            MessageBox.Show("Izdelek urejen");

            textBox22.Text = "";
            textBox21.Text = "";
            textBox20.Text = "";
            textBox19.Text = "";
            textBox18.Text = "";
            textBox17.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Main Main = new Main();
            this.Close();
            Main.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            izpis izpis = new izpis();
            this.Hide();
            izpis.Show();
        }
    }
}
