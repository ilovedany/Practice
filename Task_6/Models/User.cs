using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Microsoft.AspNetCore.SignalR;

using System.Text.Json.Serialization;

namespace Test1
{
    public class User
    {
        [JsonPropertyName("IdUser")]
        public int Id{get; set;}
        [JsonPropertyName("NameUser")]
        public string Name{get; set;}


        [JsonIgnore]
        public string Surname{get; set;}
        [JsonIgnore]
        public int Age{get; set;}
        [JsonIgnore]
        public string Email{get; set;}
    }
}