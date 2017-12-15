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
    public partial class AjoutEleve : Form
    {
        public AjoutEleve()
        {
            InitializeComponent();
            GestionUtilisateur.SetChaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);

            //Création de la liste de string
            List<string> MaBoxClassGestionEleve = new List<string>();

            //Récupération de la liste string
            MaBoxClassGestionEleve = GestionEleveBLL.GetBoxClasGestionEleve();

            BoxClassGestionEleve_Frm.DataSource = MaBoxClassGestionEleve;
        }

        private void BtValidationAjout_Click(object sender, EventArgs e)
        {
             string NomEleve;
             string PrenomEleve;
             DateTime DateNaissanceEle;
             string TelephoneEle;
             string TelephonePar;
             int TierT_Ele = 0;
             string CommEle;
             int EtatEle = 0;
             int IdCla;

            NomEleve = TextBoxNomAjout.Text;
            PrenomEleve = TextBoxPrenomAjout.Text;
            DateNaissanceEle = DateNaissanceAjout.Value;
            TelephoneEle = TextBoxTelephoneEleveAjout.Text;
            TelephonePar = TextBoxTelephoneParentAjout.Text;
            CommEle = TextBoxCommentaireAjout.Text;
            IdCla = BoxClassGestionEleve_Frm.SelectedIndex + 1;
            if (ComboBoxTierTemps.Text == "NON")
            {
                TierT_Ele = 1;
            }
            else
            {
                TierT_Ele = 0;
            }
            if (ComboBoxEtat.Text == "NON")
            {
                EtatEle = 1;
            }
            else
            {
                EtatEle = 0;
            }
            GestionEleveBLL.AjoutElev(NomEleve, PrenomEleve, DateNaissanceEle, TelephoneEle, TelephonePar, TierT_Ele, CommEle, EtatEle, IdCla);
    }

        private void BoxClassGestionEleve_Frm_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabelTitreAjout.Text = BoxClassGestionEleve_Frm.SelectedValue.ToString();
        }

        private void BtDeconnectionAjout_Click(object sender, EventArgs e)
        {
            Login_frm Login = new Login_frm();
            Login.Show();
            this.Hide();
        }

        private void BtRetourAjout_Click(object sender, EventArgs e)
        {
            GestionEleve GesionEleve = new GestionEleve();
            GesionEleve.Show();
            this.Hide();
        }
    }
}
