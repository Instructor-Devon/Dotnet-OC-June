using System;
using System.ComponentModel.DataAnnotations;

namespace MySQLFun.Models
{
    public class Quote
    {
        [Key]
        public int QuoteId {get;set;}
        public int UserId {get;set;}
        public string Content {get;set;}
        public string Byline {get;set;}
        public DateTime CreatedAt {get;set;}
        // Navigation Property
        public User Creator {get;set;}
    }
}