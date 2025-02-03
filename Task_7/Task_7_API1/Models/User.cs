using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

using System.Text.Json.Serialization;

namespace Task_7
{
    public class User
    {
        
        public int Id{get; set;}

        public string Name{get; set;}
 
        public string Surname{get; set;}
        public int Age{get; set;}

        public string Email{get; set;}
        
    }
}