using Newtonsoft.Json;
using System.Text;
using SEN381_UI.Data;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Net;

namespace SEN381_UI.BusinessLayer.Services
{
    public class ClientService
    {
        public async Task<List<Client>> LoadClient(int size, int page)
        {
            using var client = new HttpClient();
            Console.WriteLine(page);
            Console.WriteLine(size);
            var result = await client.GetAsync($"https://localhost:7116/api/Client?page={page}&size={size}");
            var resp = await result.Content.ReadAsStringAsync();
            List<Client> clients = JsonConvert.DeserializeObject<List<Client>>(resp);
            return clients;

        }
        public async Task<Client> getClientDetails(string id)
        {
            Console.WriteLine("Start Request");
            HttpClient client = new HttpClient();
            string url = $"https://localhost:7116/api/Client/{id}";
            HttpResponseMessage response = await client.GetAsync(url);
            Client newclient = JsonConvert.DeserializeObject<Client>(await response.Content.ReadAsStringAsync());
            return newclient;
        }

        public async Task<Client> postClientDetails(Client person)
        {
            var client = new HttpClient();
            string url = $"https://localhost:7116/api/Client";
            HttpResponseMessage response = await client.PostAsJsonAsync(url, person);
            Client postclient = JsonConvert.DeserializeObject<Client>(await response.Content.ReadAsStringAsync());
            return postclient;

        }
        public async Task<Client> deleteClient(string id)
        {
            var client = new HttpClient();
            string url = $"https://localhost:7116/api/Client/{id}";
            HttpResponseMessage response = await client.DeleteAsync(url);
            Client coverage = JsonConvert.DeserializeObject<Client>(await response.Content.ReadAsStringAsync());

            Console.WriteLine(coverage);
            return coverage;

        }

        public async Task<Client> updateClient(Client cov)
        {
            Console.WriteLine("Update start");
            var client = new HttpClient();
            string url = $"https://localhost:7116/api/Client/{cov.ClientID}";
            Console.WriteLine(cov.ClientID);
            Console.WriteLine(url);
            HttpResponseMessage response = await client.PutAsJsonAsync(url, cov);
            Client coverage = JsonConvert.DeserializeObject<Client>(await response.Content.ReadAsStringAsync());
            Console.WriteLine(coverage);
            return coverage;

        }


    }
}
