﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace food_truck.Telas
{
    public partial class frmjrtrab : Form
    {
        public frmjrtrab()
        {
            InitializeComponent();
        }

        
        
             private void pictureBox1_Click(object sender, EventArgs e)
        {
            Telas.DesignPanelMenu telas = new Telas.DesignPanelMenu();
            telas.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }
