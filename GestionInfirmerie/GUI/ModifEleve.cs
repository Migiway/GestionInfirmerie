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
    public partial class ModifEleve : Form
    {
        private int idEleve;
        public ModifEleve(int idEleve, string Classe)
        {
            this.idEleve = idEleve;
            InitializeComponent();
            OBGestionEleve MonEleve;
            MonEleve = GestionEleveBLL.GetValeursEleve(idEleve);
            LabelNomEleveModif.Text = MonEleve.Nom;
            LabelPrenomEleveModif.Text = MonEleve.Prenom;
            LabelClasseEleveModif.Text = Classe;
            LabelDateNEleveModif.Text = MonEleve.DateNaissance;
            TextBoxCommentaireModifEleve.Text = MonEleve.LeCommentaire;
            TextBoxTelephoneEleveModifEleve.Text = MonEleve.TeleEleve;
            TextBoxelephoneParentModifEleve.Text = MonEleve.TeleParent;
            if (MonEleve.Tier == "False")
            {
                TierTNonModifEleve.Checked = true;
            }
            else
            {
                TierTOuiModifEleve.Checked = true;
            }
            if (MonEleve.EtatModif == "False")
            {
                ArchiveNonModifEleve.Checked = true;
            }
            else
            {
                ArchiveOuiModifEleve.Checked = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ModifEleve_Load(object sender, EventArgs e)
        {

        }


        private void ModifEleveValidation_Click(object sender, EventArgs e)
        {
            int TierTemps;
            int Etat;

            if (TierTNonModifEleve.Checked == true)
            {
                TierTemps = 0;
            }
            else
            {
                TierTemps = 1;
            }
            if (ArchiveNonModifEleve.Checked == true)
            {
                Etat = 0;
            }
            else
            {
                Etat = 1;
            }
            OBGestionEleve MonEleve = new OBGestionEleve(TextBoxTelephoneEleveModifEleve.Text, TextBoxelephoneParentModifEleve.Text, TierTemps, TextBoxCommentaireModifEleve.Text, Etat);
            GestionEleveBLL.ModifEleve(this.idEleve ,MonEleve);
            MessageBox.Show("Eleve a bien été modifier.");
            GestionEleve gestionEleve = new GestionEleve();
            gestionEleve.Show();
            this.Hide();
        }
    }
}
