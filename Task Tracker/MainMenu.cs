﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Tracker
{
    public partial class MainMenu : Form
    {
        DeveloperForm developerForm;

        public MainMenu()
        {
            InitializeComponent();
            developerForm = new DeveloperForm();
        }

        private void DevelopersButton_Click(object sender, EventArgs e)
        {
            // Load the Developer Form
            developerForm.Show();
        }

        private void graphtest_Click(object sender, EventArgs e)
        {
            //testing graph
            IterationGraph ig = new IterationGraph();
            ig.iterationID = 1;
            ig.Show();
        }
    }
}
