using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using BO;
using DAL;

namespace BLL
{
    public class GestionEleveBLL
    {
        //[Formulaire GetionEleve_Frm] Méthode qui renvoie la liste pour la BoxClassGestionEleve
        public static List<string> GetBoxClasGestionEleve()
        {
           return GestionEleveDAL.GetBoxClasGestionEleve();
         
        }

        //[Formulaire GetionEleve_Frm] Méthode qui renvoie la liste pour la DataViewClassGestionEleve
        public static List<OBGestionEleve> GetDataViewClassGestionEleve(string LaClasse)
        {
            return GestionEleveDAL.GetDataViewClassGestionEleve(LaClasse);
        }

        //[Formulaire GetionEleve_Frm] Méthode qui renvoie la liste pour la DataViewEleveGestionEleve
        public static List<OBGestionEleve> GetDataViewEleveGestionEleve(int IdEleve, string NomEleve, string PrenomEleve)
        {
            OBGestionEleve UnEleve = new OBGestionEleve(IdEleve, NomEleve, PrenomEleve);
            return GestionEleveDAL.GetDataViewEleveGestionEleve(UnEleve);
        }

        //[Formulaire AjoutEleve_Frm] Méthode qui ajout un eleve
        public static int AjoutElev(string NomEleve, string PrenomEleve, DateTime DateNaissanceEle, string TelephoneEle, string TelephonePar, int TierT_Ele, string CommEle, int EtatEle, int IdCla)
        {
            OBGestionEleve Eleve = new OBGestionEleve(NomEleve, PrenomEleve, DateNaissanceEle, TelephoneEle, TelephonePar, TierT_Ele, CommEle, EtatEle, IdCla);
            return GestionEleveDAL.AjoutEleve(Eleve);
        }

        public static string SuppressionEleve(int idEleve)
        {

            int verif;
            string MessageAlert;
            verif = GestionEleveDAL.VerifEleveVisite(idEleve);

            if (verif == 1)
            {
                MessageAlert = "L'élève ne peut pas être supprimé.";
            }
            else
            {
                GestionEleveDAL.SuppresEleve(idEleve);
                MessageAlert = "L'élève a bien été supprimé.";
            }
            return MessageAlert;
        }
        public static OBGestionEleve GetValeursEleve(int idEleve)
        {
            return GestionEleveDAL.RecupEleve(idEleve);
        }

        public static void ModifEleve(int idEleve, OBGestionEleve MonEleve)
        {
            GestionEleveDAL.UpdateEleve(idEleve, MonEleve);
            
        }


    }
}
