using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthHealthFormApp.Entities
{
    internal class InvoicePDF
    {
        public int IdDossier { get; set; }
        public string LibelleIntervention { get; set; }
        public DateTime Horraire { get; set; }
        public string TypeEtablissement { get; set; }
        public string AdresseEtablissement { get; set; }

        public string NomPrenomPatient { get; set; }
        public string EmailPatient { get; set; }

        public string AdressePatient { get; set; }
        public DateTime DateNaissancePatient { get; set; }

        public string NumeroSecu { get; set; }

        public string MedecinTraitant { get; set; }

        public string NomPrenomSpecialiste { get; set; }
        public string TelSpecialiste { get; set; }

    }
}
