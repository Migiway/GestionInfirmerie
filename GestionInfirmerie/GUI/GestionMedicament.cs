﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class GestionMedicament : Form
    {
        public GestionMedicament()
        {
            InitializeComponent();
        }

        private void btnAjouterMedicament_Click(object sender, EventArgs e)
        {
            AjoutMedic AjoutMedic = new AjoutMedic();
            AjoutMedic.Show();
            this.Hide();
        }
    }
}
