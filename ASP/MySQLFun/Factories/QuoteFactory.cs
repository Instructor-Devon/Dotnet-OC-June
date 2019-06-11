using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using MySql.Data.MySqlClient;
using MySQLFun.Models;

namespace MySQLFun.Factories
{
    public class QuoteFactory
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

        public List<Quote> GetAll()
        {
            using(IDbConnection dbConnection = Connection)
            {
                return dbConnection.Query<Quote>("SELECT * FROM quotes").ToList();
            }
        }
        public Quote GetOneById(int id)
        {
            using(IDbConnection dbConnection = Connection)
            {
                var param = new {ID = id};
                return dbConnection.Query<Quote>("SELECT * FROM quotes WHERE QuoteId = @ID", param).FirstOrDefault();
            }
        }
        public void Create(Quote newQuote)
        {
            using(IDbConnection dbConnection = Connection)
            {
                string insert = "INSERT INTO quotes (Content, Byline, CreatedAt, UserId) VALUES (@Content, @Byline, NOW(), @UserId)";
                dbConnection.Execute(insert, newQuote);
            }
        }
    }
}