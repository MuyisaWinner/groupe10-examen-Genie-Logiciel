using System;
using System.Text;
using Microsoft.Data.SqlClient;

namespace ProjetGroupe10
{
    internal class DbManager
    {
        public string user;
        public string password;
        private string server = "DESKTOP-2O9D8F6";
        private string dbName = "groupe10";
        // Singleton
        private static readonly Lazy<DbManager> instance = new Lazy<DbManager>(() => new DbManager());

        // Connexion SQL
        
        private SqlConnection connection;

        // Chaine de connexion à personnaliser
        public string connectionString(string user,string password) => string.Format("Server={0};Database={1};User Id={2};Password={3};TrustServerCertificate=True", [server, dbName, user, password]);

        // Constructeur privé
        public DbManager() {
            
        }
        public static PersonneClasse selectedPerson = null;
        public SqlConnection initialise()
        {
           
                if (user != null && password != null)
                {
                    SqlConnection sqlConnection = new SqlConnection(connectionString(user, password));

                    connection = sqlConnection;
                    return connection;
                }
                else
                {
                    throw new Exception("Verifier vos identifiant");
                }
            
        }

        

        // Accès à l'instance
        public static DbManager Instance => instance.Value;

        // Accès à la connexion (si besoin)
        public SqlConnection Connection => connection;

        // Connexion à la base
        public bool Connect()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connexion à la base de données réussie.");
                    return true;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"Erreur lors de la connexion : {ex.Message}");
                    MessageBox.Show(ex.Message
                        , "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Clipboard.SetText(ex.Message);
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        // Déconnexion
        public bool Disconnect()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    connection.Close();
                    Console.WriteLine("Connexion fermée.");
                    return true;
                }
                catch (SqlException ex) {
                    connection.Close();
                    Console.WriteLine("Connexion fermée.");
                    return true;
                }
            }
            else
            {
                return true;
            }
        }

        // Vérifie si la connexion est ouverte
        public bool IsConnected()
        {
            try
            {
                try
                {
                    initialise();
                }
                catch (Exception ex)
                {
                    return false;
                }
                    
                return connection.State == System.Data.ConnectionState.Open;
            }
            catch (SqlException ex) {
                return false;
            }
        }

        public static string randomID(int taille = 14)
        {
            const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var sb = new StringBuilder(taille);

            for (int i = 0; i < taille; i++)
            {
                int index = random.Next(caracteres.Length);
                sb.Append(caracteres[index]);
            }

            return sb.ToString();
        }
    }
}

