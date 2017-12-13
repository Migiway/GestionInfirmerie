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
    public partial class Login_frm : Form
    {

        public Login_frm()
        {
            InitializeComponent();

            //Connecion a la base de donnée
            GestionUtilisateur.SetChaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);
        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            //Récupération de la valeur grace au identantifiant et mot de passe de l'utilisateur
            int test = GestionUtilisateur.VerifUtilisateur(txt_username.Text, txt_password.Text);


            //On test la valeur pour savoir si 1 = l'utilisateur existe donc connection, 0 = l'utilisateur n'exites pas
            if (test == 1)
            {
                MessageBox.Show("Connection réussie");
                Acceuil Acceuil = new Acceuil();
                Acceuil.Show();
                this.Hide();

            }
            else
            {
                if (txt_password.Text == "" || txt_username.Text == "")
                {
                    MessageBox.Show("Veuillez remplir tout les champs demandé");
                }
                else
                {
                    MessageBox.Show("Mot de passe ou nom d'utilisateur incorrect");
                }
            }
        }

        private void Login_frm_Load(object sender, EventArgs e)
        {

        }
    }
}