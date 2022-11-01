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

            var result = await claim.GetAsync($"https://localhost:7116/api/Claims?page=1&size=12");
            var resp = await result.Content.ReadAsStringAsync();
            List<Claim> contributors = JsonConvert.DeserializeObject<List<Claim>>(resp);
            Console.WriteLine(contributors);
            return contributors;

        }
        public async Task<Claim> postClaimDetails(Claim person)
        {
            var client = new HttpClient();
            string url = $"https://localhost:7116/api/Claims";
            HttpResponseMessage response = await client.PostAsJsonAsync(url, person);
            Claim postclient = JsonConvert.DeserializeObject<Claim>(await response.Content.ReadAsStringAsync());
            return postclient;

        }
        public async Task<Claim> getClientDetails(int id)
        {
            Console.WriteLine("Start Request");
            HttpClient claim = new HttpClient();
            string url = $"https://localhost:7116/api/Claims/{id}";
            HttpResponseMessage response = await claim.GetAsync(url);
            Claim newclient = JsonConvert.DeserializeObject<Claim>(await response.Content.ReadAsStringAsync());
            return newclient;
        }
        public async Task<Claim> deleteClaim(int id)
        {
            var claim = new HttpClient();
            string url = $"https://localhost:7116/api/Claims/{id}";
            HttpResponseMessage response = await claim.DeleteAsync(url);
            Claim coverage = JsonConvert.DeserializeObject<Claim>(await response.Content.ReadAsStringAsync());

            Console.WriteLine(coverage);
            return coverage;

        }
        public async Task<Claim> updateClaim(Claim cov)
        {
            Console.WriteLine("Update start");
            var client = new HttpClient();
            string url = $"https://localhost:7116/api/Claims/{cov.ClaimID}";
            Console.WriteLine(cov.ClaimID);
            Console.WriteLine(url);
            HttpResponseMessage response = await client.PutAsJsonAsync(url, cov);
            Claim coverage = JsonConvert.DeserializeObject<Claim>(await response.Content.ReadAsStringAsync());
            Console.WriteLine(coverage);
            return coverage;

        }
        public async Task<List<MedicalCondition>> LoadMedicalCondition()
        {
            var claim = new HttpClient();

            var result = await claim.GetAsync($"https://localhost:7116/api/MedicalCondition?page=1&size=12");
            var resp = await result.Content.ReadAsStringAsync();
            List<MedicalCondition> contributors = JsonConvert.DeserializeObject<List<MedicalCondition>>(resp);
            Console.WriteLine(contributors);
            return contributors;

        }

    }
}
