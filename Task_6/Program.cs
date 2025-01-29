using Test1;
using System.Net.Http.Json;
using System.Threading.Tasks;

class MainProgram{

    HttpClient httpClient = new HttpClient();
    public static async Task HttpMethodAsync(HttpClient httpClient){

        var data = await httpClient.GetFromJsonAsync<List<User>>("http://localhost:5009/getUsers");
        foreach(var d in data){
            Console.WriteLine($"Id = {d.Id}, Name = {d.Name}");
        }
    }

    static async Task Main(string[] args){

        HttpClient httpClient = new HttpClient();
        await HttpMethodAsync(httpClient);

    }
}