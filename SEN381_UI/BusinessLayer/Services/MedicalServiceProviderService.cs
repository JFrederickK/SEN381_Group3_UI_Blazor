using Newtonsoft.Json;
using SEN381_UI.Data;

namespace SEN381_UI.BusinessLayer.Services
{
    public class MedicalServiceProviderService
    {
        public async Task<List<MedicalServiceProvider>> getProviders(int size, int page)
        {
            HttpClient client = new HttpClient();
            string url = $"https://localhost:7116/api/MedicalServiceProvider?page={page}&size={size}";
            HttpResponseMessage response = await client.GetAsync(url);
            List<MedicalServiceProvider> providers = JsonConvert.DeserializeObject<List<MedicalServiceProvider>>(await response.Content.ReadAsStringAsync());
            if (providers != null)
            {
                return providers;
            }
            return new List<MedicalServiceProvider>();
        }

        public async Task<MedicalServiceProvider> addProvider(MedicalServiceProvider prov)
        {
            HttpClient client = new HttpClient();
            string url = $"https://localhost:7116/api/MedicalServiceProvider";
            HttpResponseMessage response = await client.PostAsJsonAsync<MedicalServiceProvider>(url, prov);
            MedicalServiceProvider provider = JsonConvert.DeserializeObject<MedicalServiceProvider>(await response.Content.ReadAsStringAsync());

            return provider;

        }

        public async Task<MedicalServiceProvider> getProviderDetails(string id)
        {
            HttpClient client = new HttpClient();
            string url = $"https://localhost:7116/api/MedicalServiceProvider/{id}";
            HttpResponseMessage response = await client.GetAsync(url);
            MedicalServiceProvider provider = JsonConvert.DeserializeObject<MedicalServiceProvider>(await response.Content.ReadAsStringAsync());
            if (provider != null)
            {
                return provider;
            }
            return null;
        }

        public async Task<MedicalServiceProvider> deleteProvider(string id)
        {
            HttpClient client = new HttpClient();
            string url = $"https://localhost:7116/api/MedicalServiceProvider/{id}";
            HttpResponseMessage response = await client.DeleteAsync(url);
            MedicalServiceProvider provider = JsonConvert.DeserializeObject<MedicalServiceProvider>(await response.Content.ReadAsStringAsync());

            return provider;

        }

        public async Task<MedicalServiceProvider> updateProvider(MedicalServiceProvider provider)
        {
            HttpClient client = new HttpClient();
            string url = $"https://localhost:7116/api/MedicalServiceProvider/{provider.PolicyProviderID}";
            HttpResponseMessage response = await client.PutAsJsonAsync<MedicalServiceProvider>(url, provider);
            MedicalServiceProvider prov = JsonConvert.DeserializeObject<MedicalServiceProvider>(await response.Content.ReadAsStringAsync());

            return prov;

        }
    }
}
