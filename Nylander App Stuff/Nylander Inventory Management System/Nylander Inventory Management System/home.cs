﻿using System;
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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            generalinventory generalinventory = new generalinventory();
            generalinventory.Closed += (s, args) => this.Close();
            generalinventory.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            archiveselector archiveselector = new archiveselector();
            archiveselector.Closed += (s, args) => this.Close();
            archiveselector.Show();
        }
    }
}
