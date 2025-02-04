using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpForm.ViewModels
{
    public class PostRankView
    {
        public void PostRankMethod()
        {
            HttpClient httpClient = new HttpClient();
            var rankDict =

            new Dictionary<string, string>
            {
              {"Rank","Senior"},
              {"Id","10"},
            };
            Task.Run(() => HttpRequest.HttpRank.PostRankAsync(httpClient, "http://localhost:5009/addRank", rankDict));

        }

    }
}
