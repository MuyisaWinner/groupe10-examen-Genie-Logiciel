using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGroupe10
{
    internal class TelephoneClasse
    {
        public string id { get; set; }
        public string code { get; set; }
        public string numero { get; set; }
        public string person { get; set; }
        SqlConnection con => DbManager.Instance.Connection;
        string tableName => "telephoneTable";
        public bool AddOrUpdate()
        {
            try
            {
                string query = @"
            IF EXISTS (SELECT 1 FROM " + tableName + @" WHERE id = @id)
                UPDATE " + tableName + @" 
                SET code = @code, numero = @numero, person = @person 
                WHERE id = @id
            ELSE
                INSERT INTO " + tableName + @" (id, code, numero, person) 
                VALUES (@id, @code, @numero, @person)";

                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id",id);
                    cmd.Parameters.AddWithValue("@code", code);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.Parameters.AddWithValue("@person", person);

                    int result = cmd.ExecuteNonQuery();
                    return result != 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public List<TelephoneClasse> getAll()
        {
            var telephones = new List<TelephoneClasse>();

           
                var query = "SELECT * FROM " + tableName;
                using (var cmd = new SqlCommand(query, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                    var telephone = new TelephoneClasse();
                    telephone.id = reader.GetString(0);
                    telephone.code = reader.GetString(1);
                    telephone.numero = reader.GetString(2);
                    telephone.person = reader.GetString(3);
                    
                    telephones.Add(telephone);
                    }
                }
            

            return telephones;
        }

   

        public bool delete()
        {
            try {
                var query = "DELETE FROM " + tableName + " WHERE id = @id";
                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            } catch (Exception e)
            {
                MessageBox.Show("Une erreur s'est produite : " + e.Message, "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            
        }

    }


}

