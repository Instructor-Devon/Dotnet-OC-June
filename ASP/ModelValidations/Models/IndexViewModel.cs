using System;
using System.Collections.Generic;

namespace ModelValidations.Models
{
    public class IndexViewModel
    {
       public List<string> Users {get;set;}
       public DateTime PresentTime {get;set;}
       public UserForm NewUser {get;set;}
    }
}