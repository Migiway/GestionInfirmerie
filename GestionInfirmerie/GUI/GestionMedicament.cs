using System;
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

        private void btn_ModifierMedic_Click(object sender, EventArgs e)
        {
            //ModifMedic ModifMedic = new ModifMedic();
            //ModifMedic.Show();
            //this.Hide();
        }

        private void btn_SupprimerMedic_Click(object sender, EventArgs e)
        {
            //SuppresMedic SuppresMedic = new SuppresMedic();
            //SuppresMedic.Show();
            //this.Hide();
        }

        private void GestionMedicament_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestion_infirmerieDataSet.Medicament' table. You can move, or remove it, as needed.
            this.medicamentTableAdapter.Fill(this.gestion_infirmerieDataSet.Medicament);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_RetourGestMedic_Click(object sender, EventArgs e)
        {
            Acceuil acceuil = new Acceuil();
            acceuil.Show();
            this.Hide();
        }
    }
}
