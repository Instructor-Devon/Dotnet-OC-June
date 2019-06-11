using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using MySql.Data.MySqlClient;
using MySQLFun.Models;

namespace MySQLFun.Factories
{
    public class UserFactory
    {
        static string server = "localhost";
        static string db = "mydb"; //Change to your schema name
        static string port = "3306"; //Potentially 8889
        static string user = "root";
        static string pass = "root";
        internal static IDbConnection Connection {
            get {
                return new MySqlConnection($"Server={server};Port={port};Database={db};UserID={user};Password={pass};SslMode=None");
            }
        }

        public List<User> GetAll()
        {
            using(IDbConnection dbConnection = Connection)
            {
                return dbConnection.Query<User>("SELECT * FROM quote_user").ToList();
            }
        }
        public User GetOneById(int id)
        {
            using(IDbConnection dbConnection = Connection)
            {
                var param = new {ID = id};
                var query =
                @"
                SELECT * FROM quote_user WHERE UserId = @Id;
                SELECT * FROM quotes WHERE UserId = @Id;
                ";
        
                using (var multi = dbConnection.QueryMultiple(query, new {Id = id}))
                {
                    User user = multi.Read<User>().Single();
                    user.CreatedQuotes = multi.Read<Quote>();
                    return user;
                }
            }
        }
    }
}