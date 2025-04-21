using System;
using Microsoft.Data.SqlClient;

namespace ProjetGroupe10
{
    internal class DbManager
    {
        public string user;
        public string password;
        private string server = "DESKTOP-2O9D8F6";
        // Singleton
        private static readonly Lazy<DbManager> instance = new Lazy<DbManager>(() => new DbManager());

        // Connexion SQL
        
        private SqlConnection connection;

        // Chaine de connexion à personnaliser
        private string connectionString(string user,string password) => string.Format("Server={0};Database=TA_BASE;User Id={1};Password={2};", [server,user, password]);

        // Constructeur privé
        private DbManager()
        {
            if (user != null && password != null)
            {
                connection = new SqlConnection(connectionString(user, password);
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
        public void Connect()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connexion à la base de données réussie.");
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"Erreur lors de la connexion : {ex.Message}");
                }
            }
        }

        // Déconnexion
        public void Disconnect()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                Console.WriteLine("Connexion fermée.");
            }
        }

        // Vérifie si la connexion est ouverte
        public bool IsConnected()
        {
            return connection.State == System.Data.ConnectionState.Open;
        }
    }
}

