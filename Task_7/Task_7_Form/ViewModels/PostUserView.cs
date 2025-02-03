using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HttpForm.Models;
namespace HttpForm.ViewModels
{
    public class PostUserView
    {
        public void PostUserMethod()
        {
            HttpClient httpClient = new HttpClient();
            var userDict =

            new Dictionary<string, string>
            {
              {"Name","Данил"},
              {"Surname","Назмутдинов"},
              {"Age","19"},
              {"Email","awda@mail.ru"}

            };        
            Task.Run(() => HttpRequest.HttpUser.PostUserAsync(httpClient, "http://localhost:5009/addUser", userDict));
        
        }

    }
}
