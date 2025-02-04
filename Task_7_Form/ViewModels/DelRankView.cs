using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpForm.ViewModels
{
    public class DelRankView
    {
        public void DelRankMethod()
        {
            HttpClient httpClient = new HttpClient();
            Task.Run(() => HttpRequest.HttpRank.DelRankAsync(httpClient, "http://localhost:5009/deleteRank", 8));
        }

    }
}
