using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HttpForm.Models;
using Newtonsoft.Json;


namespace HttpForm.HttpRequest
{
    public class HttpUser
    {
        public static async Task<IEnumerable<User>> GetUserAsync<User>(HttpClient httpClient,string url)
        {
            return await httpClient.GetFromJsonAsync<List<User>>(url);
        }

        public static async Task<User> PostUserAsync(HttpClient httpClient, string url, Dictionary<string, string> dict)
        {
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.TransferEncodingChunked = true;

            var response = await httpClient.PostAsync(url, new FormUrlEncodedContent(dict));


            var jsonResponse = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<User>(jsonResponse); 
        }
        public static async Task DelUserAsync(HttpClient httpClient, string url,int id)
        {
            string concate_url = $"{url}?Id={id}";

            await httpClient.DeleteAsync(concate_url);

        }

    }
}
