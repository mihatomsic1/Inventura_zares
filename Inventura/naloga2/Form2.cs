using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace naloga2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void hardwareButton_Click(object sender, EventArgs e)
        {
            dodajanjeHardware dodajanjeHardware = new dodajanjeHardware();
            dodajanjeHardware.Show();
            this.Close();
        }

        private void softwareButton_Click(object sender, EventArgs e)
        {
            dodajanjeSoftware dodajanjeSoftware = new dodajanjeSoftware();
            dodajanjeSoftware.Show();
            this.Close();
        }

        private void monitorButton_Click(object sender, EventArgs e)
        {
            dodajanjeMonitor dodajanjeMonitor = new dodajanjeMonitor();
            dodajanjeMonitor.Show();
            this.Close();
        }

        private void computerButton_Click(object sender, EventArgs e)
        {
            dodajanjeComputer dodajanjeComputer = new dodajanjeComputer();
            dodajanjeComputer.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main Main = new Main();
            this.Hide();
            Main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            izpis izpis = new izpis();
            this.Hide();
            izpis.Show();
        }
    }
}
