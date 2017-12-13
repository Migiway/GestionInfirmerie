using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BO;
using System.Data.SqlClient;

namespace DAL
{
    public class LoginDAL
    {
        //[Formulaire Login_frm]-Requète qui renvoie si l'utilisateur qui essaye de se connecter existe.
        public static int AccesConnexion(Utilisateurs UnUtilisateur)
        {
            int ResultatRequete;
            //Connexion à la base de donnée
            SqlConnection maConnexion = Connexion.GetConnexion().GetSqlConnection();

            //Réation de le requete SQL
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            //On selecion l'utilisateur qui veux se connecter
            cmd.CommandText = "Select * from Utilisateur where Login_Uti = '" + UnUtilisateur.Login_utilisateur1 + "' AND Mdp_Uti = '" + UnUtilisateur.Mdp_utilisateur1 + "'";

            //Réponse de la requete
            SqlDataReader monReader = cmd.ExecuteReader();

            //On vérifie qui l'utilisaeur a éé trouvé
            if (monReader.Read() != false)
            {
                //L'utilisateur existe
                ResultatRequete = 1;
            }
            else
            {
                //l'utilisateur n'existe pas
                ResultatRequete = 0;
            }

            maConnexion.Close();

            //Retour de la réponse
            return ResultatRequete;
        }

        //[Formulaire Acceuil] Requète qui renvoie une lise des information de synthése 
        public static List<OBAcceuil> GetDataViewwAcc()
        {

            //Attribue du construteur MarRequete
            int NbVisite;
            int NbMedic;
            float MoyVisite;
            float MoyMedic;

            //Objet du constructeur sans filtre de la DataViewAcc
            OBAcceuil MaRequete;

            //Creation du tableau de la liste de MaRequete
            List<OBAcceuil> RequeteListe = new List<OBAcceuil>();

            //Connection a la Base de Donnée
            SqlConnection MaConnexion = Connexion.GetConnexion().GetSqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = MaConnexion;

            //Requete pour la Base de Donnée
            cmd.CommandText = "select AVG(Quantite) as MoyMedic, SUM(Quantite) as NbMedic,  COUNT(Id_Vis) as NbVisite, AVG( distinct administrer.Id_Vis) as MoyVisite from administrer";

            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                //Assigne les attribus avec les valeurs récupérer dans la requete
                MoyMedic = Int32.Parse(monReader["MoyMedic"].ToString());
                NbMedic = Int32.Parse(monReader["NbMedic"].ToString());
                NbVisite = Int32.Parse(monReader["NbVisite"].ToString());
                MoyVisite = Int32.Parse(monReader["MoyVisite"].ToString());

                //On construit notre objet grace aux attribues assigné juste avant
                MaRequete = new OBAcceuil(NbVisite, MoyVisite, NbMedic, MoyMedic);

                //Remplie notre liste des objets
                RequeteListe.Add(MaRequete);
            }
            MaConnexion.Close();

            //Retourne la liste
            return RequeteListe;
        }

        //[Formulaire Acceuil] Requète qui renvoie une lise des information de synthése avec le filtre
        public static List<OBAcceuil> FiltreDataViewwAcc(DateTime DateDebut, DateTime DateFin)
        {

            //Attribue du construteur MarRequete
            int NbVisite;
            int NbMedic;
            float MoyVisite;
            float MoyMedic;
            string Date;

            //Objet du constructeur sans filtre de la DataViewAcc
            OBAcceuil MaRequete;

            //Creation du tableau de la liste de MaRequete
            List<OBAcceuil> RequeteListe = new List<OBAcceuil>();

            //Connection a la Base de Donnée
            SqlConnection MaConnexion = Connexion.GetConnexion().GetSqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = MaConnexion;

            //Requete pour la Base de Donnée
            cmd.CommandText = "select Date_Vis as DateVisite, AVG(distinct Quantite) as MoyMedic, SUM(distinct Quantite) as NbMedic,  COUNT(distinct administrer.Id_Vis) as NbVisite, AVG( distinct administrer.Id_Vis) as MoyVisite from Visite, administrer where Visite.Id_Vis = administrer.Id_Vis and Date_Vis BETWEEN  '" + DateDebut + "' and '" + DateFin + "' group by Date_Vis";

            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {

                //Assigne les attribus avec les valeurs récupérer dans la requete
                Date = monReader["DateVisite"].ToString();
                MoyMedic = Int32.Parse(monReader["MoyMedic"].ToString());
                NbMedic = Int32.Parse(monReader["NbMedic"].ToString());
                NbVisite = Int32.Parse(monReader["NbVisite"].ToString());
                MoyVisite = Int32.Parse(monReader["MoyVisite"].ToString());

                //On construit notre objet grace aux attribues assigné juste avant
                MaRequete = new OBAcceuil(Date, NbVisite, MoyVisite, NbMedic, MoyMedic);

                //Remplie notre liste des objets
                RequeteListe.Add(MaRequete);
            }
            MaConnexion.Close();

            //Retourne la liste
            return RequeteListe;
        }
    }
}
