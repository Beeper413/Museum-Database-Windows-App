using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nylander_Inventory_Management_System
{
    public partial class archiveselector : Form
    {
        public archiveselector()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            archivebluebins archivebluebins = new archivebluebins();
            archivebluebins.Closed += (s, args) => this.Close();
            archivebluebins.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            archivedrawers archivedrawers = new archivedrawers();
            archivedrawers.Closed += (s, args) => this.Close();
            archivedrawers.Show();
        }
    }
}
