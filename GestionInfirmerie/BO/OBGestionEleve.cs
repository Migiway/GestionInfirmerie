using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BO
{
    public class OBGestionEleve
    {




        // [Formulaire GestionEleve_Frm] Constructeur pour la BoxClassGestionEleve_Frm et leurs propriété
        private string NomClasse;
        public OBGestionEleve(string NomClasse)
        {
            this.NomClasse = NomClasse;
        }
        public string Classe { get => NomClasse; set => NomClasse = value; }


        //[Formulaire GestionEleve_Frm] Constructeur pour la DataViewClassGestionEleve et leurs propriété
        private string NomEleve;
        private string PrenomEleve;
        private int IdEleve;
        public OBGestionEleve(int IdEleve, string NomEleve, string PrenomEleve)
        {
            this.IdEleve = IdEleve;
            this.NomEleve = NomEleve;
            this.PrenomEleve = PrenomEleve;
        }
        public int Id { get => IdEleve; set => IdEleve = value; }
        public string Nom { get => NomEleve; set => NomEleve = value; }
        public string Prenom { get => PrenomEleve; set => PrenomEleve = value; }

        // [Formulaire GestionEleve_Frm] Constructeur pour la DataViewEleveGestionEleve et leurs propriété
        private string Date;
        private string Motif;
        private int Dure;
        private string Commentaire;
        public OBGestionEleve(string Date, string Motif, int Dure, string Commentaire)
        {
            this.Date = Date;
            this.Motif = Motif;
            this.Dure = Dure;
            this.Commentaire = Commentaire;
        }
        public string LaDate { get => Date; set => Date = value; }
        public string LeMotif { get => Motif; set => Motif = value; }
        public string LeCommentaire { get => Commentaire; set => Commentaire = value; }
        public int LaDure { get => Dure; set => Dure = value; }

        //[Formulaire GestionEleve_Frm] Constructeur pour l'AjoutGestionEleve
        ///////////////////////Valeur déjà nommée///////////////////////
        //private string NomEleve;
        //private string PrenomEleve;
        //private string Commentaire;
        ///////////////////////////////////////////////////////////////
        private DateTime DateNaissanceEle;
        private string TelephoneEle;
        private string TelephonePar;
        private int TierT_Ele;
        private int EtatEle;
        private int IdCla;
        public OBGestionEleve(string NomEleve, string PrenomEleve, DateTime DateNaissanceEle, string TelephoneEle, string TelephonePar, int TierT_Ele, string Commentaire, int EtatEle, int IdCla)
        {
            
            this.NomEleve = NomEleve;
            this.PrenomEleve = PrenomEleve;
            this.DateNaissanceEle = DateNaissanceEle;
            this.TelephoneEle = TelephoneEle;
            this.TelephonePar = TelephonePar;
            this.TierT_Ele = TierT_Ele;
            this.Commentaire = Commentaire;
            this.EtatEle = EtatEle;
            this.IdCla = IdCla;
        }
        ///////////////////////Propriété déjà nommée///////////////////////
        //public string Nom { get => NomEleve; set => NomEleve = value; }
        //public string Prenom { get => PrenomEleve; set => PrenomEleve = value; }
        //public string LeCommentaire { get => Commentaire; set => Commentaire = value; }
        //public string Classe { get => NomClasse; set => NomClasse = value; }
        ///////////////////////////////////////////////////////////////
        public DateTime Naissance { get => DateNaissanceEle; set => DateNaissanceEle = value; }
        public string TeleEleve { get => TelephoneEle; set => TelephoneEle = value; }
        public string TeleParent { get => TelephonePar; set => TelephonePar = value; }
        public int TierEleve { get => TierT_Ele; set => TierT_Ele = value; }
        public int Etat { get => EtatEle; set => EtatEle = value; }

        public int IdClasse { get => IdCla; set => IdCla = value; }

        private string TierT;
        private string DateN;
        private string EtatEleModif;
        public OBGestionEleve(string NomEleve, string PrenomEleve, string DateN, string TelephoneEle, string TelephonePar, string TierT, string Commentaire, string EtatEleModif)
        {

            this.NomEleve = NomEleve;
            this.PrenomEleve = PrenomEleve;
            this.DateN = DateN;
            this.TelephoneEle = TelephoneEle;
            this.TelephonePar = TelephonePar;
            this.TierT = TierT;
            this.Commentaire = Commentaire;
            this.EtatEleModif = EtatEleModif;
        }
        public string DateNaissance { get => DateN; set => DateN = value; }
        public string Tier { get => TierT; set => TierT = value; }
        public string EtatModif { get => EtatEleModif; set => EtatEleModif = value; }

        public OBGestionEleve( string TelephoneEle, string TelephonePar, int TierT_Ele, string Commentaire, int EtatEle)
        {

            
            this.TelephoneEle = TelephoneEle;
            this.TelephonePar = TelephonePar;
            this.TierT_Ele = TierT_Ele;
            this.Commentaire = Commentaire;
            this.EtatEle = EtatEle;
        }

    }

}
