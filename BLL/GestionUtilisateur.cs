using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using BO;
using DAL;

namespace BLL
{
    public class GestionUtilisateur
    {

        //Méthode qui renvoie la chaine de connection
        public static void SetChaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            Connexion.GetConnexion().SetChaineConnexion(chaine);
        }


        //[Formulaire Login_Frm] Méthode qui renvoie si l'utilisateur existe ou pas
        public static int VerifUtilisateur(string Login, string Mdp)
        {
            Utilisateurs UnUtilisateur;
            UnUtilisateur = new Utilisateurs(Login, Mdp);
            return LoginDAL.AccesConnexion(UnUtilisateur);
        }

        //[Formulaire Acceuil] Méthode qui renvoie la liste sans filtre de la DataViewAcc
        public static List<OBAcceuil> GetDataViewAcc()
        {

            return LoginDAL.GetDataViewwAcc();

        }

        //[Formulaire Acceuill]Méthode qui renvoie la liste avec filtre de la DataViewAcc
        public static List<OBAcceuil> GetFiltreDataViewAcc(DateTime DateDebut, DateTime DateFin)
        {
            return LoginDAL.FiltreDataViewwAcc(DateDebut, DateFin);
        }


    }
}
