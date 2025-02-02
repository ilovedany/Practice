using System.Net.Http.Json;
using HttpForm.Models;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using System;
using HttpForm.HttpRequest;
using System.Collections.Generic;
namespace HttpForm.ViewModels
{
    public class GetUserView : ObservableCollection<User>
    {
        public GetUserView()
        {
            HttpClient httpClient = new HttpClient();
            var users = Task.Run(() => HttpRequest.HttpUser.GetUserAsync<User>(httpClient, "http://localhost:5009/getUsers")).Result;
            foreach (var user in users) {
                Add(user);
            }
        }     
    }
}
