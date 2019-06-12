using System.ComponentModel.DataAnnotations;

namespace EFFunzies.Models
{
    public class Message
    {
        [Key]
        public int MessageId {get;set;}
        public string Content {get;set;}
        public int UserId {get;set;}
        // Navigation Property
        public User Creator {get;set;}
    }
}