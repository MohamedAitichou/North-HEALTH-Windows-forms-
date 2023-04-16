using NorthHealthFormApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthHealthFormApp.Helper
{
    internal class SessionManager
    {
        private static SessionManager instance;
        public Admin CurrentAdmin { get; set; }

        private SessionManager(Admin admin)
        {
            // Initialisation de la session
            CurrentAdmin = admin;
        }

        public static SessionManager openSession(Admin admin)
        {
            if (instance == null)
            {
                instance = new SessionManager(admin);
            }
            return instance;
        }

        public Admin getAdmin()
        {
            return CurrentAdmin;
        }

        public static SessionManager getSession()
        {
            return instance;
        }
        public static void closeSession()
        {
            instance = null;
        }
    }
}
