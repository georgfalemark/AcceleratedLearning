using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CheckPoint05
{
    public class DataAccess
    {
        private const string conString = "Server = (localdb)\\mssqllocaldb; Database = GnomeDb;";
            
        internal List<Gnome> GetGnomesFromDatabase()
        {
            var sql = @"SELECT GNOME.GnomeID, GNOME.name, GNOME.Beard, GNOME.godorevil, GNOME.angerlevel, RAS.ras
                        FROM GNOME
                        JOIN RAS
                        ON Ras.rasid = GNOME.rasid";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                List<Gnome> gnomes = new List<Gnome>();

                while (reader.Read())
                {
                    var g = new Gnome
                    {
                        gnomeID = reader.GetSqlInt32(0).Value,
                        name = reader.GetSqlString(1).Value,
                        beard = reader.GetSqlBoolean(2).Value,
                        godOrEvil = reader.GetSqlBoolean(3).Value,
                        angerLevel = reader.GetSqlInt32(4).Value,
                        ras = reader.GetSqlString(5).Value,
                    };
                    gnomes.Add(g);
                }
                return gnomes;
            }
        }
    }
}
