using NorthHealthFormApp.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthHealthFormApp
{
    public partial class AccueilForm : Form
    {
        public AccueilForm()
        {
            InitializeComponent();
            adminName.Text = "Bonjour " + SessionManager.getSession().getAdmin().NomAdmin;
        }

        private void planningInterventionMenu_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Je dois affichier les dossiers médicaux des patients... ");
            // Je dois ouvrir la fenêtre des dossiers médicaux...
            PlanningForm planning = new PlanningForm();
            planning.ShowDialog();
        }

        private void addElements(object sender, EventArgs e)
        {
            AddElementForm addElementForm = new AddElementForm();
            addElementForm.ShowDialog();
        }

        private void generateInvoiceButton_Click(object sender, EventArgs e)
        {
            // TODO: Ouvrir la fenêtre pour choisir pour quel dossier nous devons générer le compte rendu...
            CompteRenduForm compteRenduForm = new CompteRenduForm();
            compteRenduForm.ShowDialog();
        }
    }
}
