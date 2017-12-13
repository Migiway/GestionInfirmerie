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
    public partial class GestionEleve : Form
    {

        public GestionEleve()
        {
            InitializeComponent();

            //Connection a la base de donnée
            GestionUtilisateur.SetChaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);

            //Création de la liste de string
            List<string> MaBoxClassGestionEleve = new List<string>();

            //Récupération de la liste string
            MaBoxClassGestionEleve = GestionEleveBLL.GetBoxClasGestionEleve();

            //Attribue les valeurs a la BoxClassGestionEleve_Frm
            BoxClassGestionEleve_Frm.DataSource = MaBoxClassGestionEleve;

            //Création de la liste d'objets
            List<OBGestionEleve> MaDataViewClassGesionEleve = new List<OBGestionEleve>();

            //Récupération de la liste d'objet pour la classe BTS 2
            MaDataViewClassGesionEleve = GestionEleveBLL.GetDataViewClassGestionEleve("BTS 2");

            //Attribue les valeurs a la DataViewClassGestionEleve_Frm
            DataViewClassGestionEleve_Frm.DataSource = MaDataViewClassGesionEleve;

            //On Ordonne
            DataViewClassGestionEleve_Frm.Columns[0].Visible = false;
            DataViewClassGestionEleve_Frm.Columns[1].Visible = false;
        }


        private void GestionEleve_Frm_Load(object sender, EventArgs e)
        {

        }

        private void BoxClassGestionEleve_Frm_SelectedValueChanged(object sender, EventArgs e)
        {

            //Création de la liste d'objets
            List<OBGestionEleve> MaDataViewClassGesionEleve = new List<OBGestionEleve>();

            //Récupération de la liste d'objet pour la classe selectionné dans la BoxClassGestionEleve_Frm
            MaDataViewClassGesionEleve = GestionEleveBLL.GetDataViewClassGestionEleve(BoxClassGestionEleve_Frm.Text);

            //Attribue les valeurs a la DataViewClassGestionEleve_Frm
            DataViewClassGestionEleve_Frm.DataSource = MaDataViewClassGesionEleve;

            //On ORdonne
            DataViewClassGestionEleve_Frm.Columns[0].Visible = false;
            DataViewClassGestionEleve_Frm.Columns[1].Visible = false;

            DataViewEleveGestionEleve_Frm.Visible = false;

        }

        private void DataViewClassGestionEleve_Frm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Attribue les valeurs néssaire pour notre méthode GetDataViewEleveGestionEleve
            int id = Int32.Parse(DataViewClassGestionEleve_Frm.CurrentRow.Cells[1].Value.ToString());
            string Nom = DataViewClassGestionEleve_Frm.CurrentRow.Cells[2].Value.ToString();
            string prenom = DataViewClassGestionEleve_Frm.CurrentRow.Cells[3].Value.ToString();

            //Création de la liste d'objets
            List<OBGestionEleve> MaDataViewClassGesionEleve = new List<OBGestionEleve>();

            //Récupération de la liste d'objet pour un id, un nom et un prenom selectionné dans la DataViewClassGestionEleve_Frm
            MaDataViewClassGesionEleve = GestionEleveBLL.GetDataViewEleveGestionEleve(id, Nom, prenom) ;

            //Attribue les valeurs a la DataViewEleveGestionEleve_Frm
            DataViewEleveGestionEleve_Frm.DataSource = MaDataViewClassGesionEleve;

            //Change le text du LabelTitre
            LabelNomEleve.Text = Nom+" "+prenom;

            //Style du formulaire
            DataViewEleveGestionEleve_Frm.Visible = true;
            BtAjoutEleve.Visible = true;
            BtModifEleve.Visible = true;
            BtSupprimerEleve.Visible = true;
            DataViewEleveGestionEleve_Frm.Columns[0].Visible = true;
            DataViewEleveGestionEleve_Frm.Columns[1].Visible = false;
            DataViewEleveGestionEleve_Frm.Columns[2].Visible = false;
            DataViewEleveGestionEleve_Frm.Columns[3].Visible = false;
            DataViewEleveGestionEleve_Frm.Columns[4].HeaderText = "Date visite";
            DataViewEleveGestionEleve_Frm.Columns[5].HeaderText = "Motif de la visite";
            DataViewEleveGestionEleve_Frm.Columns[6].HeaderText = "Commentaire";
            DataViewEleveGestionEleve_Frm.Columns[7].HeaderText = "Durée de la visite";



        }

        //Boutton ajouter élève du formulaire GestionEleve
        private void BtAjoutEleve_Click(object sender, EventArgs e)
        {
            AjoutEleve AjoutEleve = new AjoutEleve();
            AjoutEleve.Show();
            this.Hide();
        }

        //Boutton deconnecter du formulaire GestionEleve
        private void BtDeconnectionGestionEleve_Click(object sender, EventArgs e)
        {
            Login_frm Login = new Login_frm();
            Login.Show();
            this.Hide();
        }

        //Boutton retoure du formulaire GestionEleve
        private void BtRetourGesionEleve_Click(object sender, EventArgs e)
        {
            Acceuil acceuil = new Acceuil();
            acceuil.Show();
            this.Hide();
        }

        private void BtSupprimerEleve_Click(object sender, EventArgs e)
        {
            //Recuperer l'id de l'élève selctionné
            int id = Int32.Parse(DataViewClassGestionEleve_Frm.CurrentRow.Cells[1].Value.ToString());
            GestionEleveBLL.SuppressionEleve(id);
            MessageBox.Show(GestionEleveBLL.SuppressionEleve(id));
        }

        private void BtModifEleve_Click(object sender, EventArgs e)
        {
            int idEleve = Int32.Parse(DataViewClassGestionEleve_Frm.CurrentRow.Cells[1].Value.ToString());
            string classe = BoxClassGestionEleve_Frm.SelectedValue.ToString();
            ModifEleve ModifEleve = new ModifEleve(idEleve, classe);
            ModifEleve.Show();
            this.Hide();
        }
    }
}
