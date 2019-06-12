using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFFunzies.Models
{
    public class LogRegModel
    {
        public User NewUzser {get;set;}
        public LoginUser LogUser {get;set;}
    }
    public class User
    {
        [Key]
        public int UserId {get;set;}
        public string FirstName {get;set;}
        public string LastName {get;set;}
        [NotMapped]
        [Compare("FirstName")]
        public string ComparePassword {get;set;}
        // Navigation Property
        public List<Message> MessagesCreated {get;set;}
    }
    public class LoginUser
    {

    }
}