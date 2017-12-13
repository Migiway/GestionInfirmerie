using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BO;
using System.Data.SqlClient;

namespace DAL
{
    public class GestionEleveDAL
    {

        //[Formulaire GestionEleve_Frm] Requète pour la BoxClassGesionEleve
        public static List<string> GetBoxClasGestionEleve()
        {

            //Attribue du construteur MaRequete
            string NomClasse;

            //Objet du constructeur sans filtre de la DataViewAcc
            OBGestionEleve MaRequete;

            //Creation du tableau de la liste de MaRequete
            List<string> RequeteListe = new List<string>();

            //Connection a la Base de Donnée
            SqlConnection MaConnexion = Connexion.GetConnexion().GetSqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = MaConnexion;

            //Requete pour la Base de Donnée
            cmd.CommandText = "Select Libelle_Cla as NomClasse from Classe";

            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                //Assigne les attribus avec les valeurs récupérer dans la requete
                NomClasse = monReader["NomClasse"].ToString();

                //On construit notre objet grace aux attribues assigné juste avant
                MaRequete = new OBGestionEleve(NomClasse);

                //Remplie notre liste des objets
                RequeteListe.Add(MaRequete.Classe);
            }
            MaConnexion.Close();

            //Retourne la liste
            return RequeteListe;
        }

        //[Formulaire GestionEleve_Frm] Requète pour la DataViewClass
        public static List<OBGestionEleve> GetDataViewClassGestionEleve(string LaCLasse)
        {

            //Attribue du construteur MarRequete
            string NomEleve;
            string PrenomEleve;
            int IdEleve;

            //Objet du constructeur sans filtre de la DataViewAcc
            OBGestionEleve MaRequete;

            //Creation du tableau de la liste de MaRequete
            List<OBGestionEleve> RequeteListe = new List<OBGestionEleve>();

            //Connection a la Base de Donnée
            SqlConnection MaConnexion = Connexion.GetConnexion().GetSqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = MaConnexion;

            //Requete pour la Base de Donnée
            cmd.CommandText = "Select distinct Id_Ele as IdEleve, Nom_Ele as NomEleve, Prenom_Ele as PrenomEleve from Eleve, Classe where Eleve.Id_Cla = Classe.Id_Cla and Libelle_Cla ='" + LaCLasse + "'";

            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                //Assigne les attribus avec les valeurs récupérer dans la requete
                NomEleve = monReader["NomEleve"].ToString();
                PrenomEleve = monReader["PrenomEleve"].ToString();
                IdEleve = Int32.Parse(monReader["IdEleve"].ToString());

                //On construit notre objet grace aux attribues assigné juste avant
                MaRequete = new OBGestionEleve(IdEleve, NomEleve, PrenomEleve);

                //Remplie notre liste des objets
                RequeteListe.Add(MaRequete);
            }
            MaConnexion.Close();

            //Retourne la liste
            return RequeteListe;
        }

        public static List<OBGestionEleve> GetDataViewEleveGestionEleve(OBGestionEleve Eleve)
        {

            //Attribue du construteur MarRequete
            string DateVisite;
            string MotifVisite;
            int DureVisite;
            string ComentaireVisite;

            //Objet du constructeur sans filtre de la DataViewAcc
            OBGestionEleve MaRequete;

            //Creation du tableau de la liste de MaRequete
            List<OBGestionEleve> RequeteListe = new List<OBGestionEleve>();

            //Connection a la Base de Donnée
            SqlConnection MaConnexion = Connexion.GetConnexion().GetSqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = MaConnexion;

            //Requete pour la Base de Donnée
            cmd.CommandText = "Select distinct Date_Vis as DateVisite, Motif_Vis as MotifVisite, Duree_Vis as DureVisite, Comm_Vis as ComentaireVisite from Visite, Eleve where Eleve.Id_Ele = Visite.Id_Ele and Eleve.Id_Ele = '" + Eleve.Id + "'";

            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                //Assigne les attribus avec les valeurs récupérer dans la requete
                DateVisite = monReader["DateVisite"].ToString();
                MotifVisite = monReader["MotifVisite"].ToString();
                DureVisite = Int32.Parse(monReader["DureVisite"].ToString());
                ComentaireVisite = monReader["ComentaireVisite"].ToString();

                //On construit notre objet grace aux attribues assigné juste avant
                MaRequete = new OBGestionEleve(DateVisite, MotifVisite, DureVisite, ComentaireVisite);

                //Remplie notre liste des objets
                RequeteListe.Add(MaRequete);
            }
            MaConnexion.Close();

            //Retourne la liste
            return RequeteListe;
        }
        public static int AjoutEleve(OBGestionEleve Eleve)
        {
            //Attribue du construteur MarRequete
            int Entier;

            //Connection a la Base de Donnée
            SqlConnection MaConnexion = Connexion.GetConnexion().GetSqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = MaConnexion;

            //Requete pour la Base de Donnée
            cmd.CommandText = "INSERT INTO Eleve values('" + Eleve.Nom + "', '" + Eleve.Prenom + "', '" + Eleve.Naissance + "', '" + Eleve.TeleEleve + "', '" + Eleve.TeleParent + "', '" + Eleve.TierEleve + "', '" + Eleve.LeCommentaire + "', '" + Eleve.Etat + "', '" + Eleve.IdClasse + "')";
            Entier = cmd.ExecuteNonQuery();

            //Retourne la liste
            MaConnexion.Close();
            return Entier;
        }
        public static int VerifEleveVisite(int idEleve)
        {
            int resultatRequete = 0;
            int resultatSupress;
            SqlConnection maConnexion = Connexion.GetConnexion().GetSqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECt count(Id_Vis) as nbVisite from VISITE where Id_Ele = " + idEleve;
            SqlDataReader monReader = cmd.ExecuteReader();
            while (monReader.Read())
            {
                //Assigne les attribus avec les valeurs récupérer dans la requete
                resultatSupress = Int32.Parse(monReader["nbVisite"].ToString());
                if (resultatSupress > 0)
                {
                    resultatRequete = 1;
                    
                    
                }
                else
                {
                    resultatRequete = 0;
                    
                    
                }
                
            }
            maConnexion.Close();
            return resultatRequete;


        }
        // Cette méthode supprime un eleve passé en paramètre dans la BD
        public static void SuppresEleve(int idEleve)
        {

            // Connexion à la BD
            SqlConnection maConnexion = Connexion.GetConnexion().GetSqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE from ELEVE where Id_Ele = " + idEleve;
            int monReader = cmd.ExecuteNonQuery();
            maConnexion.Close();

        }

        public static OBGestionEleve RecupEleve(int idEleve)
        {
            //Attribue du construteur MarRequete
            string Nom;
            string Prenom;
            string DateN;
            string TelephoneEleve;
            string TelephoneParent;
            string TierTemps;
            string commentaire;
            string Etat;

            //Objet du constructeur sans filtre de la DataViewAcc
            OBGestionEleve MaRequete;


            //Connection a la Base de Donnée
            SqlConnection MaConnexion = Connexion.GetConnexion().GetSqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = MaConnexion;

            //Requete pour la Base de Donnée
            cmd.CommandText = "Select * from ELEVE where Id_Ele = "+idEleve;

            SqlDataReader monReader = cmd.ExecuteReader();

            monReader.Read();
    
                //Assigne les attribus avec les valeurs récupérer dans la requete
                Nom = monReader["Nom_Ele"].ToString();
                Prenom = monReader["Prenom_Ele"].ToString();
                DateN = monReader["DateN_Ele"].ToString();
                TelephoneEleve = monReader["Tel_Ele"].ToString();
                TelephoneParent = monReader["Tel_Parent_Ele"].ToString();
                TierTemps = monReader["TierT_Ele"].ToString();
                commentaire = monReader["Comm_Ele"].ToString();
                Etat = monReader["Etat_Ele"].ToString();

                //On construit notre objet grace aux attribues assigné juste avant
                
            MaConnexion.Close();
            MaRequete = new OBGestionEleve(Nom, Prenom, DateN, TelephoneEleve, TelephoneParent, TierTemps, commentaire, Etat);
            //Retourne la liste
            return MaRequete;
        }

        public static void UpdateEleve(int idEleve, OBGestionEleve UnEleve)
        {
            
            // Connexion à la BD
            SqlConnection maConnexion = Connexion.GetConnexion().GetSqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "Update ELEVE set Tel_Ele = '"+UnEleve.TeleEleve+ "', Tel_Parent_Ele = '" + UnEleve.TeleParent + "',TierT_Ele = '" + UnEleve.TierEleve + "',Comm_Ele = '" + UnEleve.LeCommentaire + "',Etat_Ele = '" + UnEleve.Etat + "' where Id_Ele =" +idEleve;
            int monReader = cmd.ExecuteNonQuery();
            maConnexion.Close();

        }
    }
    }
