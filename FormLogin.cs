using NorthHealthFormApp.Entities;
using NorthHealthFormApp.QueryDesigner;
using NorthHealthFormApp.Helper;


namespace NorthHealthFormApp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void seConnecterButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Je récupére les informations de connexion...
                string emailOLogin = loginBox.Text.Trim().ToString();
                string pwd = pwdBox.Text.Trim().ToString();

                // Il faut que je requete ma base de données pour savoir si l'user existe bien...
                QDProvider qDProvieder = new QDProvider();
                Admin admin = qDProvieder.LoginAdmin(emailOLogin, pwd);

                if (admin.IdAdmin != 0)
                {
                    // TODO: Une fois l'admin est connecté il faut lui donner la possiblité de pouvoir consulter les dossiers médicaux...
                    // J'ouvre ma session...
                    SessionManager.openSession(admin);
                    AccueilForm accueilForm = new AccueilForm();
                    this.Hide();
                    accueilForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Erreur de connexion ! Veuillez vérifier vos infos.", "Echec de connexion");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "error");
            }
        }

    
    }
}