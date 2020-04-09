using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserAPI
{
    public class dbcontext
    {
        public string ConnectionString { get; set; }

        public dbcontext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public User GetUser()
        {
            var user = new User();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("Select * from nagp.user;", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        user = new User
                        {
                            email = reader["email"].ToString(),
                            name = reader["name"].ToString(),
                            age = Convert.ToInt32(reader["age"])
                        };
                    }
                }
            }
            return user;
        }
    }
}
