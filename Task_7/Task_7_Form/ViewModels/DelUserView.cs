using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HttpForm.Models;

namespace HttpForm.ViewModels
{
    public class DelUserView : ObservableCollection<User>
    {
        public DelUserView()
        {
            HttpClient httpClient = new HttpClient();
            Task.Run(() => HttpRequest.HttpUser.DelUserAsync(httpClient, "http://localhost:5009/deleteUser", 3));
        }
        
    }
}
