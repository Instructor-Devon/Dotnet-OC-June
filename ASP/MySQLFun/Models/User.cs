using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MySQLFun.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}
        public string Name {get;set;}
        public IEnumerable<Quote> CreatedQuotes {get;set;}
    }
}