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
    public partial class izpis : Form
    {
        public izpis()
        {
            InitializeComponent();
        }

        private void izpis_Load(object sender, EventArgs e)
        {
            itemsBaza db = new itemsBaza();

            List<HardwareItem> seznamH = new List<HardwareItem>();

            seznamH = db.ReadItemsH();

            dataGridView1.DataSource = seznamH;

            List<SoftwareItem> seznamS = new List<SoftwareItem>();

            seznamS = db.ReadItemsS();

            dataGridView2.DataSource = seznamS;

            List<Computer> seznamC = new List<Computer>();

            seznamC = db.ReadItemsC();

            dataGridView3.DataSource = seznamC;

            List<Monitor> seznamM = new List<Monitor>();

            seznamM = db.ReadItemsM();

            dataGridView4.DataSource = seznamM;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            var row = dataGridView1.CurrentCell.RowIndex;
            string itemID = dataGridView1.Rows[row].Cells[1].Value.ToString();


            itemsBaza db = new itemsBaza();
            HardwareItem hardwareItemToDelete = new HardwareItem(itemID, " " , 0.0, 0.0);
            db.DeleteHardwareItem(hardwareItemToDelete);
            MessageBox.Show("Izdelek izbrisan");
           

            List<HardwareItem> seznamH = new List<HardwareItem>();

            seznamH = db.ReadItemsH();

            dataGridView1.DataSource = seznamH;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var row = dataGridView2.CurrentCell.RowIndex;
            string itemID = dataGridView2.Rows[row].Cells[2].Value.ToString();


            itemsBaza db = new itemsBaza();
            SoftwareItem softwareItemToDelete = new SoftwareItem(itemID, " ", 0.0, " ", 0);
            db.DeleteSoftwareItem(softwareItemToDelete);
            MessageBox.Show("Izdelek izbrisan");


            List<SoftwareItem> seznamS = new List<SoftwareItem>();

            seznamS = db.ReadItemsS();

            dataGridView2.DataSource = seznamS;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var row = dataGridView3.CurrentCell.RowIndex;
            string itemID = dataGridView3.Rows[row].Cells[4].Value.ToString();


            itemsBaza db = new itemsBaza();
            Computer computerToDelete = new Computer(itemID, " ", 0.0, 0.0, 0, 0.0, 0.0);
            db.DeleteComputer(computerToDelete);
            MessageBox.Show("Izdelek izbrisan");


            List<Computer> seznamC = new List<Computer>();

            seznamC = db.ReadItemsC();

            dataGridView3.DataSource = seznamC;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var row = dataGridView4.CurrentCell.RowIndex;
            string itemID = dataGridView4.Rows[row].Cells[3].Value.ToString();


            itemsBaza db = new itemsBaza();
            Monitor monitorToDelete = new Monitor(itemID, " ", 0.0, 0.0, " ", " ");
            db.DeleteMonitor(monitorToDelete);
            MessageBox.Show("Izdelek izbrisan");


            List<Monitor> seznamM = new List<Monitor>();

            seznamM = db.ReadItemsM();

            dataGridView4.DataSource = seznamM;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Main Main = new Main();
            this.Hide();
            Main.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            this.Hide();
            Form2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Posodobitev Posodobitev = new Posodobitev();
            this.Hide();
            Posodobitev.Show();
        }
    }
}
