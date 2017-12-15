using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BO
{
    //Consructeurs des objets de la classe Utilisateurs avec leurs propriété 
    public class Utilisateurs
    {
        private int id;
        private string Login_utilisateur;
        private string Mdp_utilisateur;

        public string Login_utilisateur1 { get => Login_utilisateur; set => Login_utilisateur = value; }
        public string Mdp_utilisateur1 { get => Mdp_utilisateur; set => Mdp_utilisateur = value; }
        public int Id { get => id; set => id = value; }

        public Utilisateurs(string monLogin, string monMdp)
        {
            this.Login_utilisateur = monLogin;
            this.Mdp_utilisateur = monMdp;
        }
    }
}
