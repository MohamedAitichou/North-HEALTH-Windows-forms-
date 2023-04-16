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
                // Je r�cup�re les informations de connexion...
                string emailOLogin = loginBox.Text.Trim().ToString();
                string pwd = pwdBox.Text.Trim().ToString();

                // Il faut que je requete ma base de donn�es pour savoir si l'user existe bien...
                QDProvider qDProvieder = new QDProvider();
                Admin admin = qDProvieder.LoginAdmin(emailOLogin, pwd);

                if (admin.IdAdmin != 0)
                {
                    // TODO: Une fois l'admin est connect� il faut lui donner la possiblit� de pouvoir consulter les dossiers m�dicaux...
                    // J'ouvre ma session...
                    SessionManager.openSession(admin);
                    AccueilForm accueilForm = new AccueilForm();
                    this.Hide();
                    accueilForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Erreur de connexion ! Veuillez v�rifier vos infos.", "Echec de connexion");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "error");
            }
        }

    
    }
}