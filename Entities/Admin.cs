using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace NorthHealthFormApp.Entities
{
    internal class Admin
    {
        public int IdAdmin { get; set;  }
        public string NomAdmin { get; set;  }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
