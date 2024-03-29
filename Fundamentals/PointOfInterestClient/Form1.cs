﻿using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfInterestClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            using (var proxy = new PointOfInterestClient())
            {
                listBox1.DataSource = proxy.GetPointsOfInterestForState(textBox1.Text).Select(p => p.Name).ToList();
            }
        }
    }
}
