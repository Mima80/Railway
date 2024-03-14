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
    public class ClientRepository
    {
        private const string ConnectionString = "Data Source=DESKTOP-25TDOM3\\SQLEXPRESS;Initial Catalog=Railway;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        public IEnumerable<Client> GetAllClients()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM Clients";
                return connection.Query<Client>(sql);
            }
        }
        public void InsertClient(Client client)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string sql = "INSERT INTO Clients (Name, Address, Contact_Phone) VALUES (@Name, @Address, @Contact_Phone)";
                connection.Execute(sql, client);
            }
        }
    }
}
