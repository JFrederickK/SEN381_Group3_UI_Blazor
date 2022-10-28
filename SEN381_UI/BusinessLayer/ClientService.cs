using Newtonsoft.Json;
using System.Text;
using SEN381_UI.Data;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Net;

namespace SEN381_UI.BusinessLayer
{
    public class ClientService
    {
        public async Task<List<Client>> LoadClient()
        { 
        using var client = new HttpClient();

            var result = await client.GetAsync("https://localhost:7116/api/Client?page=1&size=5");
            var resp = await result.Content.ReadAsStringAsync();
            List<Client> contributors = JsonConvert.DeserializeObject<List<Client>>(resp);
            return contributors;
            
        }

        public async Task<Client> postClientDetails(Client person) {
            HttpClient client = new HttpClient();
            string url = $"https://localhost:7116/api/Client";
            HttpResponseMessage response = await client.PostAsJsonAsync(url, person);
            Client postclient = JsonConvert.DeserializeObject<Client>(await response.Content.ReadAsStringAsync());
            Console.WriteLine("clinet info");
            Console.WriteLine(postclient.clientAddress);
            return postclient;

        }

    }
}
