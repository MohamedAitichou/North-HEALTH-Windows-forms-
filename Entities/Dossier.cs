using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthHealthFormApp.Entities
{
    internal class Dossier
    {
        public int IdDossier { get; set; }
        public string Adresse { get; set; }
        public string LibelleIntervention { get; set; }
        public string Etablissement { get; set; }
        public string Medecin { get; set;}

        public DateTime Horraire { get; set; }
        public string Patient { get; set; }

    }
}
