using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DAL
{
    public class Connexion
    {
        private SqlConnection maConnexion;
        private static Connexion UneConnexionBD;
        private string ChaineConnexion;

        //Accesseur en lecture de la chaîne de connexion.
        public string GetChaineConnexion()
        {
            return ChaineConnexion;
        }

        //Accesseur en écriture de la chaîne de connexion
        public void SetChaineConnexion(string chaineConnexion)
        {
            this.ChaineConnexion = chaineConnexion;
        }

        //Permet de donnée la connexion.
        public static Connexion GetConnexion()
        {
            if (UneConnexionBD == null)
            {
                UneConnexionBD = new Connexion();
            }
            return UneConnexionBD;
        }

        //Constructeur privé
        private Connexion()
        {

        }

        public SqlConnection GetSqlConnection()
        {
            if (maConnexion == null)
            {
                maConnexion = new SqlConnection();
            }
            maConnexion.ConnectionString = ChaineConnexion;

            //Si la connexion est fermé, on l'ouvre.
            if (maConnexion.State == System.Data.ConnectionState.Closed)
            {
                maConnexion.Open();
            }
            return maConnexion;
        }
        public void CloseConnexion()
        {
            //Si la connexion est ouverte, on la ferme
            if (this.maConnexion != null && this.maConnexion.State != System.Data.ConnectionState.Closed)
            {
                this.maConnexion.Close();
            }
        }
    }
}
