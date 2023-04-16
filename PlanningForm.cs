using NorthHealthFormApp.Entities;
using NorthHealthFormApp.QueryDesigner;
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
    public partial class PlanningForm : Form
    {
        public PlanningForm()
        {
            InitializeComponent();
        }

        private void PlanningForm_Load(object sender, EventArgs e)
        {
            // Ici je dois charger les données depuis la base...
            QDProvider qDProvider = new QDProvider();
            List<Dossier> dossiers = qDProvider.getPlanningPatient();

            dossiersGridView.DataSource = dossiers;

        }
    }
}
