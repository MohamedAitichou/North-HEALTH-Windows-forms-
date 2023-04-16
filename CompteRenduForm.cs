using NorthHealthFormApp.QueryDesigner;
using NorthHealthFormApp.Entities;
using NorthHealthFormApp.Helper;
using iTextSharp.text;

namespace NorthHealthFormApp
{
    public partial class CompteRenduForm : Form
    {
        private QDProvider qdProvider;
        public CompteRenduForm()
        {
            InitializeComponent();
            qdProvider = new QDProvider();
        }

        private void CompteRenduForm_Load(object sender, EventArgs e)
        {
            // TODO: Il faut récupérer tous les users...
            List<Patient> patients = qdProvider.GetPatients();
            foreach (Patient p in patients)
            {
                userComboBox.Items.Add(String.Format("{0} {1} {2}", p.IdPatient, p.NomPatient, p.PrenomPatient));
            }
        }

        private void userSleected(object sender, EventArgs e)
        {
            // Récupérer la valeur selectionnée...
            dossierComboBox.Items.Clear();

            int idPatient = int.Parse(userComboBox.SelectedItem.ToString().Split(' ')[0]);
            List<Dossier> dossiers = qdProvider.getDossierParId(idPatient);
            if (dossiers.Count > 0)
            {
                foreach (Dossier d in dossiers)
                {
                    dossierComboBox.Items.Add(String.Format("{0} {1} {2}", d.IdDossier, d.Horraire, d.LibelleIntervention));
                }
                dossierComboBox.Visible = true;
            }
            else
            {
                dossierComboBox.Visible = false;
                genererCompteRenduButton.Visible = false;

                string userName = userComboBox.SelectedItem.ToString().Split(' ')[1] + " " + userComboBox.SelectedItem.ToString().Split(' ')[2];
                MessageBox.Show("Aucun dossier n'a éé trouvé pour le patient " + userName);
            }

        }

        private void GenerateInvoiceButton(object sender, EventArgs e)
        {

            int idPatient = int.Parse(userComboBox.SelectedItem.ToString().Split(' ')[0]);
            int idDossier = int.Parse(dossierComboBox.SelectedItem.ToString().Split(' ')[0]);

            // J'appelle la fonction pour qu'elle me renvoie les données relatives au patient et au dossier selctionnées...
            InvoicePDF invoicePDF =  qdProvider.getInfoInvoice(idPatient, idDossier);
            Document pdf = PDFGenerator.GenerateInvoicePDF(invoicePDF);

            MessageBox.Show(@"Le compte rendu a bien été généré ! il se trouve ici: C:\north_health\compte_rendu\compte_rendu"+invoicePDF.IdDossier+".pdf", "Info");
        }

        private void ShowButton(object sender, EventArgs e)
        {
            genererCompteRenduButton.Visible = true;
        }

        
    }
}
