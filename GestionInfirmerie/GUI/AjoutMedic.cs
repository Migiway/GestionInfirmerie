using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using BLL;
using BO;

namespace GUI
{
    public partial class AjoutMedic : Form
    {
        public AjoutMedic()
        {
            InitializeComponent();
        }



        private void btnValidationAjoutMedic_Click(object sender, EventArgs e)
        {
            
            string nomMedicament = textBoxNomMedicAjout.Text;
            if(nomMedicament == string.Empty)
            { 
                textBoxNomMedicAjout.Focus();
                errorProviderNomMedicament.SetError(textBoxNomMedicAjout, "Veuillez saisir le nom du médicament à ajouter"); ;
            }
            else
            {
                GestionMedicamentBLL.AjoutMedic(nomMedicament);
                MessageBox.Show("Le médicament a bien été ajouté");
                GestionMedicament GestionMedicament = new GestionMedicament();
                GestionMedicament.Show();
                this.Hide();
            }
        }

        private void btnRetourAjout_Click(object sender, EventArgs e)
        {
            GestionMedicament GestionMedicament = new GestionMedicament();
            GestionMedicament.Show();
            this.Hide();
        }

    }
    
}
