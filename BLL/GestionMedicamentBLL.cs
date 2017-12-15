using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BO;
using DAL;

namespace BLL
{
    public class GestionMedicamentBLL
    {
        public static int AjoutMedic(string nomMedicament)
        {
            MedicamentBO medicament = new MedicamentBO (nomMedicament);
            return GestionMedicamentDAL.AjoutMedicament(medicament);
        }
    }
}
