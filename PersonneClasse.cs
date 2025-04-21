using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetGroupe10
{
    internal class PersonneClasse
    {
        public string id { get; set; }
        public string nom { get; set; }
        public string post { get; set; }
        public string prenom { get; set; }
        public string sexe { get; set; }

        SqlConnection con => DbManager.Instance.Connection;
        string tableName => "personnesTable"; 

        public bool AddOrUpdate()
        {
            try
            {
                string query = @"
                IF EXISTS (SELECT 1 FROM " + tableName + @" WHERE id = @id)
                    UPDATE " + tableName + @" 
                    SET nom = @nom, post = @post, prenom = @prenom, sexe = @sexe 
                    WHERE id = @id
                ELSE
                    INSERT INTO " + tableName + @" (id, nom, post, prenom, sexe) 
                    VALUES (@id, @nom, @post, @prenom, @sexe)";

                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@post", post);
                    cmd.Parameters.AddWithValue("@prenom", prenom);
                    cmd.Parameters.AddWithValue("@sexe", sexe);

                    int result = cmd.ExecuteNonQuery();
                    return result != 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur d'ajout ou mise à jour : " + ex.Message + ex.StackTrace.ToString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<PersonneClasse> GetAll()
        {
            var personnes = new List<PersonneClasse>();
            try
            {
                var query = "SELECT * FROM " + tableName;
                using (var cmd = new SqlCommand(query, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var p = new PersonneClasse
                        {
                            id = reader.GetString(0),
                            nom = reader.GetString(1),
                            post = reader.GetString(2),
                            prenom = reader.GetString(3),
                            sexe = reader.GetString(4)
                        };

                        personnes.Add(p);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de récupération : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return personnes;
        }

        public bool Delete()
        {
            try
            {
                var query = "DELETE FROM " + tableName + " WHERE id = @id";
                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de suppression : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
    }
}

