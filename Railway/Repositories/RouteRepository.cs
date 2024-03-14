using Railway.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Railway.Repositories
{
    public class RouteRepository
    {
        private const string ConnectionString = "Data Source=DESKTOP-25TDOM3\\SQLEXPRESS;Initial Catalog=Railway;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        public IEnumerable<Route> GetAllRoutes()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM Routes";
                return connection.Query<Route>(sql);
            }
        }

        public void InsertRoute(Route route)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string sql = "INSERT INTO Routes (Start_Location, End_Location, Distance, Duration, Cargo_ID, Vehicle_ID) VALUES (@Start_Location, @End_Location, @Distance, @Duration, @Cargo_ID, @Vehicle_ID)";
                connection.Execute(sql, route);
            }
        }

    }
}
