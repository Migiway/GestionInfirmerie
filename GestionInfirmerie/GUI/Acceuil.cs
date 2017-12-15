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
    public partial class Acceuil : Form
    {
        public Acceuil()
        {
            InitializeComponent();

            //Connection a la base de donnée
            GestionUtilisateur.SetChaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);

            //Création de la liste d'objets
            List<OBAcceuil> MaDataViewAcc = new List<OBAcceuil>();

            //Récupéraion de la liste d'objets
            MaDataViewAcc = GestionUtilisateur.GetDataViewAcc();

            //Attribue les valeurs de la liste d'objet dans la DataViewAcc 
            DataViewAcc.DataSource = MaDataViewAcc;

            //Ordonne le tout
            DataViewAcc.Columns[0].HeaderText = "Nombre de visite";
            DataViewAcc.Columns[1].HeaderText = "Moyenne des visites";
            DataViewAcc.Columns[2].HeaderText = "Nombre de médicament";
            DataViewAcc.Columns[3].HeaderText = "Moyenne des médicaments";
            DataViewAcc.Columns[4].Visible = false;
            LabelAnnee.Text = "Synthese de l'année: 2017";



        }

        private void Acceuil_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestion_infirmerie.Medicament'. Vous pouvez la déplacer ou la supprimer selon les besoins.

        }

        private void BtDeconnexion_Click(object sender, EventArgs e)
        {

            Login_frm login_Frm = new Login_frm();
            login_Frm.Show();
            this.Close();
        }

        private void BtQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtFiltreAcc_Click(object sender, EventArgs e)
        {
            //Création de la liste d'objets
            List<OBAcceuil> MaFiltreDataViewAcc = new List<OBAcceuil>();

            //Récupération de la liste d'objets avec le filtre
            MaFiltreDataViewAcc = GestionUtilisateur.GetFiltreDataViewAcc(CalendrierDebut.Value, CalendrierFin.Value);

            //Attribue les valeurs de la liste d'objet dans la DataViewAcc 
            DataViewAcc.DataSource = MaFiltreDataViewAcc;

            //Ordonne le tout
            DataViewAcc.Columns[0].HeaderText = "Nombre de visite";
            DataViewAcc.Columns[1].HeaderText = "Moyenne des visites";
            DataViewAcc.Columns[2].HeaderText = "Nombre de médicament";
            DataViewAcc.Columns[3].HeaderText = "Moyenne des médicaments";
            DataViewAcc.Columns[4].Visible = true;

            //echange de colonne
            DataViewAcc.Columns[4].DisplayIndex = 0;

            LabelAnnee.Text = "Synthese du: " + CalendrierDebut.Value.Month + "/" + CalendrierDebut.Value.Year + " au " + CalendrierFin.Value.Month + "/" + CalendrierFin.Value.Year;

        }

        private void BtGestionEleve_Click(object sender, EventArgs e)
        {
            GestionEleve gestionEleve_Frm = new GestionEleve();
            gestionEleve_Frm.Show();
            this.Hide();
        }

        private void BtGestionMedicament_Click(object sender, EventArgs e)
        {
            GestionMedicament gestionMedicament_Frm = new GestionMedicament();
            gestionMedicament_Frm.Show();
            this.Hide();
        }
    }
}