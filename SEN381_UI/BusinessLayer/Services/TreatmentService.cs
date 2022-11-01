using Newtonsoft.Json;
using SEN381_UI.Data;

namespace SEN381_UI.BusinessLayer.Services
{
    public class TreatmentService
    {
        public async Task<List<Treatment>> getTreatments(int size, int page)
        {
            HttpClient client = new HttpClient();
            string url = $"https://localhost:7116/api/Treatment?page={page}&size={size}";
            HttpResponseMessage response = await client.GetAsync(url);
            List<Treatment> treatments = JsonConvert.DeserializeObject<List<Treatment>>(await response.Content.ReadAsStringAsync());
            if (treatments != null)
            {
                return treatments;
            }
            return new List<Treatment>();
        }

        public async Task<Treatment> addTreatment(Treatment treat)
        {
            HttpClient client = new HttpClient();
            string url = $"https://localhost:7116/api/Treatment";
            HttpResponseMessage response = await client.PostAsJsonAsync<Treatment>(url, treat);
            Treatment treatment = JsonConvert.DeserializeObject<Treatment>(await response.Content.ReadAsStringAsync());

            return treatment;

        }

        public async Task<Treatment> getTreatmentDetails(string id)
        {
            HttpClient client = new HttpClient();
            string url = $"https://localhost:7116/api/Treatment/{id}";
            HttpResponseMessage response = await client.GetAsync(url);
            Treatment? treatment = JsonConvert.DeserializeObject<Treatment>(await response.Content.ReadAsStringAsync());
            if (treatment != null)
            {
                return treatment;
            }
            return null;
        }

        public async Task<Treatment> deleteTreatment(string id)
        {
            HttpClient client = new HttpClient();
            string url = $"https://localhost:7116/api/Treatment/{id}";
            HttpResponseMessage response = await client.DeleteAsync(url);
            Treatment treatment = JsonConvert.DeserializeObject<Treatment>(await response.Content.ReadAsStringAsync());

            return treatment;

        }

        public async Task<Treatment> updateCoverage(Treatment treatment)
        {
            HttpClient client = new HttpClient();
            string url = $"https://localhost:7116/api/Treatment/{treatment.TreatmentID}";
            HttpResponseMessage response = await client.PutAsJsonAsync<Treatment>(url, treatment);
            Treatment treat = JsonConvert.DeserializeObject<Treatment>(await response.Content.ReadAsStringAsync());

            return treat;

        }
    }
}
