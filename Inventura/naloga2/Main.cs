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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Posodobitev Posodobitev = new Posodobitev();
            Posodobitev.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
            this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            izpis izpis = new izpis();
            this.Hide();
            izpis.Show();
        }
    }
}
