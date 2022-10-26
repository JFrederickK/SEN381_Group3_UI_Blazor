using Newtonsoft.Json;
using System.Text;
using SEN381_UI.Data;
using System.Net.Http.Json;
using System.Text.Json.Serialization;


namespace SEN381_UI.BusinessLayer
{
    public class ClientService
    {
        public async Task<List<Client>> LoadClient()
        { 
        using var client = new HttpClient();

            var result = await client.GetAsync("https://localhost:7116/api/Client?page=1&size=3");


            var resp = await result.Content.ReadAsStringAsync();
            List<Client> contributors = JsonConvert.DeserializeObject<List<Client>>(resp);
            return contributors;
            
        }

        public async Task postClientDetails(Client person) {

            var json = JsonConvert.SerializeObject(person);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var url = "https://localhost:7116/api/Client";
            using var client = new HttpClient();
            var response = await client.PostAsync(url, data);
            var result = await response.Content.ReadAsStringAsync();
            Console.WriteLine(result);

        }

    }
}
