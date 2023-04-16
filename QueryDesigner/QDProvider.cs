using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using Mysqlx.Expr;
using NorthHealthFormApp.Entities;

namespace NorthHealthFormApp.QueryDesigner
{
    internal class QDProvider
    {
        private string connectionString = "Server=localhost;Database=north_health;Uid=root;Pwd=";
        private MySqlConnection connection;

        private MySqlConnection OpenConnection()
        {
            if (connection == null)
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }
            return connection;
        }

        private void CloseConnection()
        {
            if (connection != null)
            {
                connection.Close();
            }
        }

        public Admin LoginAdmin(string login, string pwd)
        {
            string query = "SELECT * FROM admin WHERE login = @login AND pwd=@pwd";

            Admin loggedAdmin = new Admin();

            MySqlCommand mySqlCommand = new MySqlCommand(query, OpenConnection());
            mySqlCommand.Parameters.AddWithValue("@login", login);
            mySqlCommand.Parameters.AddWithValue("@pwd", pwd);

            using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    loggedAdmin.IdAdmin = (int)reader["idAdmin"];
                    loggedAdmin.NomAdmin = (string)reader["nomAdmin"];
                    loggedAdmin.Login = (string)reader["login"];
                    loggedAdmin.Password = (string)reader["pwd"];
                }
            }
            
            return loggedAdmin;
        }

        public List<Dossier> getPlanningPatient()
        {
            string query = "SELECT d.idDossier, CONCAT(te.adresseEtabilissement , " +
                "\", \", c.nomCommune ,\" \", te.codePostalEtabilissement) AS \"Adresse\"," +
                " d.libelleIntervention, te.typeEtabilissement, CONCAT(s.nomSpecialiste,\" \"," +
                " s.prenomSpecialiste) AS \"Medecin\", d.creneau, CONCAT(p.nomPatient, \" \", p.prenomPatient) AS \"Patient\"\r\n" +
                "FROM dossier d\r\nINNER JOIN typeetabilissement te\r\nON d.idTypeEtabilissement = te.idTypeEtabilissement\r\n" +
                "INNER JOIN specialiste s\r\nON d.idSpecialiste = s.idSpecialiste\r\nINNER JOIN patient p\r\nON p.idPatient = d.idPatient\r\n" +
                "INNER JOIN commune c\r\nON c.codePostal = d.codeCommune";

            MySqlCommand mySqlCommand = new MySqlCommand(query, OpenConnection());

            List<Dossier> dossiers = new List<Dossier>();
            using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    Dossier dossier = new Dossier();
                    dossier.IdDossier = (int) reader["idDossier"];
                    dossier.Adresse = (string)reader["Adresse"];
                    dossier.Etablissement = (string)reader["typeEtabilissement"];
                    dossier.Patient = (string)reader["Patient"];
                    dossier.Medecin = (string)reader["Medecin"];
                    dossier.LibelleIntervention = (string) reader["libelleIntervention"];
                    dossier.Horraire = (DateTime)reader["creneau"];

                    dossiers.Add(dossier);
                }
            }
            
            return dossiers;

        }

        public void addDocumentPath(int idDossier, string path)
        {
            string query = "UPDATE dossier SET documents = @path WHERE idDossier = @idDossier";
            MySqlCommand mySqlCommand = new MySqlCommand(query, OpenConnection());
            mySqlCommand.Parameters.AddWithValue("@path", path);
            mySqlCommand.Parameters.AddWithValue("@idDossier", idDossier);

            mySqlCommand.ExecuteNonQuery();
            
        }


        public List<Patient> GetPatients()
        {
            string query = "SELECT idPatient,nomPatient, prenomPatient, emailPatient, adressePatient, villePatient, cpPatient, dateNaissancePatient, numeroSecuPatient, photoPatient, medecinTraitant FROM patient";

            MySqlCommand mySqlCommand = new MySqlCommand(query, OpenConnection());

            List<Patient> patients = new List<Patient>();

            using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    Patient patient = new Patient();
                    patient.IdPatient = (int)reader["idPatient"];
                    patient.NomPatient = (string)reader["nomPatient"];
                    patient.PrenomPatient = (string)reader["prenomPatient"];
                    patient.EmailPatient = (string)reader["emailPatient"];
                    patient.AdressePatient = (string)reader["adressePatient"];
                    patient.VillePatient = (string)reader["villePatient"];
                    patient.CpPatient = (string)reader["cpPatient"];
                    patient.PhotoPatient = DBNull.Value.Equals(reader["photoPatient"]) ? "": (string)reader["photoPatient"];
                    patient.DateNaissancePatient = (DateTime)reader["dateNaissancePatient"];
                    patient.MedecinTraitant = (string)reader["medecinTraitant"];
                    patient.NumeroSecuPatient = (string)reader["numeroSecuPatient"];

                    patients.Add(patient);
                }
            }
            
            return patients;

        }

        public List<Dossier> getDossierParId(int idPatient)
        {
            string query = "SELECT d.idDossier, CONCAT(te.adresseEtabilissement , " +
                "\", \", c.nomCommune ,\" \", te.codePostalEtabilissement) AS \"Adresse\"," +
                " d.libelleIntervention, te.typeEtabilissement, CONCAT(s.nomSpecialiste,\" \"," +
                " s.prenomSpecialiste) AS \"Medecin\", d.creneau, CONCAT(p.nomPatient, \" \", p.prenomPatient) AS \"Patient\"\r\n" +
                "FROM dossier d\r\nINNER JOIN typeetabilissement te\r\nON d.idTypeEtabilissement = te.idTypeEtabilissement\r\n" +
                "INNER JOIN specialiste s\r\nON d.idSpecialiste = s.idSpecialiste\r\nINNER JOIN patient p\r\nON p.idPatient = d.idPatient\r\n" +
                "INNER JOIN commune c\r\nON c.codePostal = d.codeCommune WHERE d.idPatient = @idPatient";

      
            MySqlCommand mySqlCommand = new MySqlCommand(query, OpenConnection());

            List<Dossier> dossiers = new List<Dossier>();
            mySqlCommand.Parameters.AddWithValue("idPatient", idPatient);

            using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    Dossier dossier = new Dossier();
                    dossier.IdDossier = (int)reader["idDossier"];
                    dossier.Adresse = (string)reader["Adresse"];
                    dossier.Etablissement = (string)reader["typeEtabilissement"];
                    dossier.Patient = (string)reader["Patient"];
                    dossier.Medecin = (string)reader["Medecin"];
                    dossier.LibelleIntervention = (string)reader["libelleIntervention"];
                    dossier.Horraire = (DateTime)reader["creneau"];

                    dossiers.Add(dossier);
                }
            }
            
            return dossiers;

        }

        public InvoicePDF getInfoInvoice(int idPatient, int idDossier)
        {

            string query = "SELECT *\r\n" +
                "FROM dossier d\r\n" +
                "INNER JOIN typeetabilissement te" +
                "\r\nON te.idTypeEtabilissement = d.idTypeEtabilissement\r\n" +
                "INNER JOIN patient p\r\n" +
                "ON p.idPatient = d.idPatient\r\n" +
                "INNER JOIN specialiste s\r\n" +
                "ON s.idSpecialiste = d.idSpecialiste\r\n" +
                "WHERE d.idPatient = @idPatient\r\n" +
                "AND d.idDossier = @idDossier";

            MySqlCommand mySqlCommand = new MySqlCommand(query, OpenConnection());

            mySqlCommand.Parameters.AddWithValue("idPatient", idPatient);
            mySqlCommand.Parameters.AddWithValue("idDossier", idDossier);

            InvoicePDF invoicePDF = new InvoicePDF();

            using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    invoicePDF.IdDossier = (int)reader["idDossier"];
                    invoicePDF.LibelleIntervention = (string)reader["libelleIntervention"];
                    invoicePDF.Horraire = (DateTime)reader["creneau"];
                    invoicePDF.TypeEtablissement = (string)reader["typeEtabilissement"];
                    invoicePDF.AdresseEtablissement = (string)String.Format("{0}, {1}", reader["adresseEtabilissement"], reader["codePostalEtabilissement"]);
                    invoicePDF.NomPrenomPatient = (string)String.Format("{0}, {1}", reader["nomPatient"], reader["prenomPatient"]);
                    invoicePDF.EmailPatient = (string)reader["emailPatient"];
                    invoicePDF.AdressePatient = (string)String.Format("{0}, {1} {2}", reader["adressePatient"], reader["villePatient"], reader["cpPatient"]);
                    invoicePDF.DateNaissancePatient = (DateTime)reader["dateNaissancePatient"];
                    invoicePDF.NumeroSecu = (string)reader["numeroSecuPatient"];
                    invoicePDF.MedecinTraitant = (string)reader["medecinTraitant"];
                    invoicePDF.NomPrenomSpecialiste = (string)String.Format("{0}, {1}", reader["nomSpecialiste"], reader["prenomSpecialiste"]);
                    invoicePDF.TelSpecialiste = (string)reader["telSpecialiste"];
                }
            }
            
            return invoicePDF;

        }
    }
}
