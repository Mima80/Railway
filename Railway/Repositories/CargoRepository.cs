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
    public class CargoRepository
    {
        private const string ConnectionString = "Data Source=DESKTOP-25TDOM3\\SQLEXPRESS;Initial Catalog=Railway;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        public IEnumerable<Cargo> GetAllCargo()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM Cargo";
                return connection.Query<Cargo>(sql);
            }
        }
        public void InsertCargo(Cargo cargo)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string sql = "INSERT INTO Cargo (Name, Weight, Dimensions, Description, Client_ID) VALUES (@Name, @Weight, @Dimensions, @Description, @Client_ID)";
                connection.Execute(sql, cargo);
            }
        }

    }
}
