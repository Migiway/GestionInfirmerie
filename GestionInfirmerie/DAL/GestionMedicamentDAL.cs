using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BO;
using System.Data.SqlClient;

namespace DAL
{
    public class GestionMedicamentDAL
    {
        public static int AjoutMedicament(MedicamentBO medicament)
        {
            //Attribue du construteur MarRequete
            int Entier;

            //Connection a la Base de Donnée
            SqlConnection MaConnexion = Connexion.GetConnexion().GetSqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = MaConnexion;

            //Requete pour la Base de Donnée
            cmd.CommandText = "INSERT INTO Medicament values('" +medicament.Nom + "', 0)";
            Entier = cmd.ExecuteNonQuery();

            //Retourne la liste
            MaConnexion.Close();
            return Entier;
        }
    }
}
