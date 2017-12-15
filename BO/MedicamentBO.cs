using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BO
{
    public class MedicamentBO
    {
        private string nomMedicament;
        private int IdMedic;
        public MedicamentBO(string nomMedicament)
        {
            this.nomMedicament = nomMedicament;
        }
        public int Id { get => IdMedic; set => IdMedic= value; }
        public string Nom { get => nomMedicament; set => nomMedicament = value; }
    }
}
