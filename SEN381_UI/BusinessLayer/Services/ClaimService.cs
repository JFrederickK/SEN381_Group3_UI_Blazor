using Newtonsoft.Json;
using SEN381_UI.Data;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace SEN381_UI.BusinessLayer.Services
{
    public class ClaimService
    {

        public async Task<List<Claim>> LoadClaim()
        {
            var claim = new HttpClient();

            var result = await claim.GetAsync($"https://localhost:7116/api/Claims?page=1&size=2");
            var resp = await result.Content.ReadAsStringAsync();
            List<Claim> contributors = JsonConvert.DeserializeObject<List<Claim>>(resp);
            Console.WriteLine(contributors);
            return contributors;

        }
        public async Task<Claim> postClaimDetails(Client person)
        {
            var client = new HttpClient();
            string url = $"https://localhost:7116/api/Client";
            HttpResponseMessage response = await client.PostAsJsonAsync(url, person);
            Claim postclient = JsonConvert.DeserializeObject<Claim>(await response.Content.ReadAsStringAsync());
            return postclient;

        }
        public async Task<Claim> getClientDetails(string id)
        {
            Console.WriteLine("Start Request");
            HttpClient claim = new HttpClient();
            string url = $"https://localhost:7116/api/Client/{id}";
            HttpResponseMessage response = await claim.GetAsync(url);
            Claim newclient = JsonConvert.DeserializeObject<Claim>(await response.Content.ReadAsStringAsync());
            return newclient;
        }

    }
}
