using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthHealthFormApp.Entities
{
    internal class Patient
    {
        public int IdPatient { get; set; }
        public string NomPatient { get; set; }
        public string PrenomPatient { get; set; }
        public string EmailPatient { get; set; }
        public string AdressePatient { get; set; }
        public string VillePatient { get; set; }
        public string CpPatient { get; set; }
        public DateTime DateNaissancePatient { get; set; }
        public string NumeroSecuPatient { get; set; }
        public string PhotoPatient { get; set; } = null;
        public string MedecinTraitant { get; set; }
    }
}
