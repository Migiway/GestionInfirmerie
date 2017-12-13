using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BO
{
    public class OBAcceuil
    {

        //[Formulaire Acceuil] Contructeur sans le filtre pour la DataViewAcc et leurs propriété
        private int NbVisite;
        private int NbMedic;
        private float MoyVisite;
        private float MoyMedic;
        public OBAcceuil(int NbVisite, float MoyVisite, int NbMedic, float MoyMedic)
        {
            this.NbVisite = NbVisite;
            this.NbMedic = NbMedic;
            this.MoyMedic = MoyMedic;
            this.MoyVisite = MoyVisite;
        }
        public int VisiteNb { get => NbVisite; set => NbVisite = value; }
        public float VisiteMoy { get => MoyVisite; set => MoyVisite = value; }
        public int MedicNb { get => NbMedic; set => NbMedic = value; }
        public float MedicMoy { get => MoyMedic; set => MoyMedic = value; }

        //[Formulaire Acceuil] Constructeur avec le filtre pour la DataViewAcc et leurs propriété
        private string Date;
        public OBAcceuil(string Date, int NbVisite, float MoyVisite, int NbMedic, float MoyMedic)
        {
            this.Date = Date;
            this.NbVisite = NbVisite;
            this.NbMedic = NbMedic;
            this.MoyMedic = MoyMedic;
            this.MoyVisite = MoyVisite;
        }
        public string DateVisie { get => Date; set => Date = value; }

    }
}
