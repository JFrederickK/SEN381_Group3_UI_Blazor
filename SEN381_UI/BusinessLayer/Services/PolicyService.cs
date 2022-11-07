using Newtonsoft.Json;
using SEN381_UI.Data;

namespace SEN381_UI.BusinessLayer.Services
{
    public class PolicyService
    {

        public async Task<List<Policy>> getPolicies(int size, int page)
        {
            HttpClient client = new HttpClient();
            string url = $"https://localhost:7116/api/Policy?page={page}&size={size}";
            HttpResponseMessage response = await client.GetAsync(url);
            List<Policy> coverages = JsonConvert.DeserializeObject<List<Policy>>(await response.Content.ReadAsStringAsync());
            if (coverages != null)
            {
                return coverages;
            }
            return new List<Policy>();
        }


        public async Task<Policy> addPolicy(Policy pol)
        {
            HttpClient client = new HttpClient();
            string url = $"https://localhost:7116/api/Policy";
            HttpResponseMessage response = await client.PostAsJsonAsync(url, pol);
            Policy policy = JsonConvert.DeserializeObject<Policy>(await response.Content.ReadAsStringAsync());

            Console.WriteLine(policy);
            return policy;

        }


        public async Task<Policy> getPolicyDetails(string id)
        {
            Console.WriteLine("Start Request");
            HttpClient client = new HttpClient();
            string url = $"https://localhost:7116/api/Policy/{id}";
            HttpResponseMessage response = await client.GetAsync(url);
            Policy policy = JsonConvert.DeserializeObject<Policy>(await response.Content.ReadAsStringAsync());
            if (policy != null)
            {
                Console.WriteLine(policy);
                return policy;
            }
            return new Policy();
        }


        public async Task<Policy> deletePolicy(string id)
        {
            HttpClient client = new HttpClient();
            string url = $"https://localhost:7116/api/Policy/{id}";
            HttpResponseMessage response = await client.DeleteAsync(url);
            Policy policy = JsonConvert.DeserializeObject<Policy>(await response.Content.ReadAsStringAsync());

            Console.WriteLine(policy);
            return policy;

        }

        public async Task<Policy> updatePolicy(Policy pol)
        {
            HttpClient client = new HttpClient();
            string url = $"https://localhost:7116/api/Policy/{pol.PolicyId}";
            HttpResponseMessage response = await client.PutAsJsonAsync<Policy>(url, pol);
            Policy policy = JsonConvert.DeserializeObject<Policy>(await response.Content.ReadAsStringAsync());

            Console.WriteLine(policy);
            return policy;
        }
        public async Task<Package> updatePolicy(Package pol)
        {
            HttpClient client = new HttpClient();
            string url = $"https://localhost:7116/api/Package?page=1&size=12";
            HttpResponseMessage response = await client.PutAsJsonAsync<Package>(url, pol);
            Package policy = JsonConvert.DeserializeObject<Package>(await response.Content.ReadAsStringAsync());

            Console.WriteLine(policy);
            return policy;
        }
    }
}
