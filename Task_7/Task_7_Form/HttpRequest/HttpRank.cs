using HttpForm.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace HttpForm.HttpRequest
{
    public class HttpRank
    {
        public static async Task<IEnumerable<SpecialistRank>> GetRankAsync<User>(HttpClient httpClient, string url)
        {
            return await httpClient.GetFromJsonAsync<List<SpecialistRank>>(url);
        }

        public static async Task<SpecialistRank> PostRankAsync(HttpClient httpClient, string url, Dictionary<string, string> dict)
        {

            var response = await httpClient.PostAsync(url, new FormUrlEncodedContent(dict));


            var jsonResponse = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<SpecialistRank>(jsonResponse);
        }
        public static async Task DelRankAsync(HttpClient httpClient, string url, int id)
        {
            string concate_url = $"{url}?Id_rank={id}";

            await httpClient.DeleteAsync(concate_url);

        }
    }
}
