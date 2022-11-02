using Newtonsoft.Json;
using SEN381_API_GROUP3.shared.models;
using SEN381_UI.Data;

namespace SEN381_UI.BusinessLayer.Services
{
    public class MedicalConditionService
    {
        public async Task<List<MedicalCondition>> LoadMedicalCondition()
        {
            using var medical = new HttpClient();

            var result = await medical.GetAsync("https://localhost:7116/api/MedicalCondition?page=1&size=12");
            var resp = await result.Content.ReadAsStringAsync();
            List<MedicalCondition> contributors = JsonConvert.DeserializeObject<List<MedicalCondition>>(resp);
            return contributors;

        }
        public async Task<MedicalCondition> getMCDetails(string id)
        {
            Console.WriteLine("Start Request");
            HttpClient medical = new HttpClient();
            string url = $"https://localhost:7116/api/MedicalCondition/{id}";
            HttpResponseMessage response = await medical.GetAsync(url);
            MedicalCondition newmedical = JsonConvert.DeserializeObject<MedicalCondition>(await response.Content.ReadAsStringAsync());
            return newmedical;
        }
        public async Task<MedicalCondition> updateMedical(MedicalCondition cov)
        {
            Console.WriteLine("Update start");
            var medical = new HttpClient();
            string url = $"https://localhost:7116/api/MedicalCondition/{cov.MedicalConditionID}";
            HttpResponseMessage response = await medical.PutAsJsonAsync(url, cov);
            MedicalCondition coverage = JsonConvert.DeserializeObject<MedicalCondition>(await response.Content.ReadAsStringAsync());
            Console.WriteLine(coverage);
            return coverage;

        }
        public async Task<MedicalCondition> postMedicalConditionDetails(MedicalCondition person)
        {
            var medical = new HttpClient();
            string url = $"https://localhost:7116/api/MedicalCondition";
            HttpResponseMessage response = await medical.PostAsJsonAsync(url, person);
            MedicalCondition postclient = JsonConvert.DeserializeObject<MedicalCondition>(await response.Content.ReadAsStringAsync());
            return postclient;

        }
        public async Task<MedicalCondition> deleteMedicalCondition(string id)
        {
            var medical = new HttpClient();
            string url = $"https://localhost:7116/api/MedicalCondition/{id}";
            HttpResponseMessage response = await medical.DeleteAsync(url);
            MedicalCondition coverage = JsonConvert.DeserializeObject<MedicalCondition>(await response.Content.ReadAsStringAsync());
            return coverage;

        }
        public async Task<List<MedicalConditionTreatment>> getMCTDetails(int id)
        {
            HttpClient medical = new HttpClient();
            string url = $"https://localhost:7116/api/MedicalConditionByTreatment/{id}";
            HttpResponseMessage response = await medical.GetAsync(url);
            List<MedicalConditionTreatment> newmedical = JsonConvert.DeserializeObject<List<MedicalConditionTreatment>>(await response.Content.ReadAsStringAsync());
            return newmedical;
        }

    }
}
