using MySql.Data.MySqlClient;
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
    public partial class AddElementForm : Form
    {
        private QDProvider QDProvider;
        public AddElementForm()
        {
            InitializeComponent();
            QDProvider = new QDProvider();
        }

        private void AddElementForm_Load(object sender, EventArgs e)
        {
            // Ici je dois charger les données depuis la base...
            QDProvider qDProvider = new QDProvider();
            List<Dossier> dossiers = qDProvider.getPlanningPatient();

            dossiersMedicauxGridView.DataSource = dossiers;
        }

        private void dossiersMedicauxGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ici récupérer la ligne sur laquelle l'user & cliqué....
            if (dossiersMedicauxGridView.Columns[e.ColumnIndex].Name == "add")
            {
                // Ouvre une boîte de dialogue pour sélectionner un fichier à uploader
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // L'id du dossier
                        int idDossier = int.Parse(dossiersMedicauxGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
                        string dest = @"D:\Mohamed2\NorthHealthFormApp\data\dossier_"+idDossier+"\\";
                        if (! Directory.Exists(dest))
                        {
                            Directory.CreateDirectory(dest);
                        }
                        
                        // Upload le fichier sélectionné
                        string filePath = openFileDialog1.FileName;
                        string fileName = Path.GetFileName(filePath);
                        File.Copy(filePath,  dest + fileName, true);

                        // J'insére le chemin du document chargé en base pour le dossier en question...
                        QDProvider.addDocumentPath(idDossier, dest+fileName);

                        MessageBox.Show("Le fichier a été uploadé avec succès !");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur s'est produite : " + ex.Message);
                    }
                }
            }
        }
    }
}
