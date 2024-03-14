using Railway.Model;
using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Railway.Repositories
{
    public class VehicleRepository
    {
        private const string ConnectionString = "Data Source=DESKTOP-25TDOM3\\SQLEXPRESS;Initial Catalog=Railway;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        public IEnumerable<Vehicle> GetAllVehicles()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var sql = "SELECT * FROM Vehicles";
                return connection.Query<Vehicle>(sql);
            }
        }

        public void InsertVehicle(Vehicle vehicle)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var sql = "INSERT INTO Vehicles (Type, Year_of_Manufacture, Registration_Number) VALUES (@Type, @Year_of_Manufacture, @Registration_Number)";
                connection.Execute(sql, vehicle);
            }
        }
    }
}
