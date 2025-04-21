using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetGroupe10
{
    internal class AdresseClasse
    {
        public string id { get; set; }
        public string numero { get; set; }
        public string avenue { get; set; }
        public string quartier { get; set; }
        public string commune { get; set; }
        public string ville { get; set; }
        public string person { get; set; }

        SqlConnection con => DbManager.Instance.Connection;
        string tableName => "adresseTable";

        public bool AddOrUpdate()
        {
            try
            {
                string query = @"
                IF EXISTS (SELECT 1 FROM " + tableName + @" WHERE id = @id)
                    UPDATE " + tableName + @" 
                    SET numero = @numero, avenue = @avenue, quartier = @quartier, 
                        commune = @commune, ville = @ville, person = @person 
                    WHERE id = @id
                ELSE
                    INSERT INTO " + tableName + @" 
                    (id, numero, avenue, quartier, commune, ville, person) 
                    VALUES (@id, @numero, @avenue, @quartier, @commune, @ville, @person)";

                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.Parameters.AddWithValue("@avenue", avenue);
                    cmd.Parameters.AddWithValue("@quartier", quartier);
                    cmd.Parameters.AddWithValue("@commune", commune);
                    cmd.Parameters.AddWithValue("@ville", ville);
                    cmd.Parameters.AddWithValue("@person", person);

                    int result = cmd.ExecuteNonQuery();
                    return result != 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur d'ajout ou modification : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<AdresseClasse> GetAll()
        {
            var adresses = new List<AdresseClasse>();

            try
            {
                var query = "SELECT * FROM " + tableName;
                using (var cmd = new SqlCommand(query, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var adresse = new AdresseClasse
                        {
                            id = reader.GetString(0),
                            numero = reader.GetString(1),
                            avenue = reader.GetString(2),
                            quartier = reader.GetString(3),
                            commune = reader.GetString(4),
                            ville = reader.GetString(5),
                            person = reader.GetString(6)
                        };

                        adresses.Add(adresse);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de lecture : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return adresses;
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

