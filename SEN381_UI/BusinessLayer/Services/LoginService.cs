using Newtonsoft.Json;
using SEN381_UI.Data;

namespace SEN381_UI.BusinessLayer.Services
{
    public class LoginService
    {
        public async Task<List<EmployeeDetails>> LoadLogin()
        {
            using var medical = new HttpClient();

            var result = await medical.GetAsync("https://localhost:7116/api/LoginReg");
            var resp = await result.Content.ReadAsStringAsync();
            List<EmployeeDetails> contributors = JsonConvert.DeserializeObject<List<EmployeeDetails>>(resp);
            return contributors;

        }
        public async Task<EmployeeDetails> getLoginByEmail(string id)
        {
            Console.WriteLine("Start Request");
            HttpClient medical = new HttpClient();
            string url = $"https://localhost:7116/api/LoginReg/{id}";
            HttpResponseMessage response = await medical.GetAsync(url);
            EmployeeDetails newmedical = JsonConvert.DeserializeObject<EmployeeDetails>(await response.Content.ReadAsStringAsync());
            return newmedical;
        }
       public async Task<EmployeeDetails> updateMedical(EmployeeDetails cov)
        {
            Console.WriteLine("Update start");
            var medical = new HttpClient();
            string url = $"https://localhost:7116/api/LoginReg/{cov.EmployeeEmail}";
            HttpResponseMessage response = await medical.PutAsJsonAsync(url, cov);
            EmployeeDetails coverage = JsonConvert.DeserializeObject<EmployeeDetails>(await response.Content.ReadAsStringAsync());
            Console.WriteLine(coverage);
            return coverage;

        }
        public async Task<EmployeeDetails> postEmployee(EmployeeDetails person)
        {
            var medical = new HttpClient();
            string url = $"https://localhost:7116/api/LoginReg/";
            HttpResponseMessage response = await medical.PostAsJsonAsync(url, person);
            EmployeeDetails postclient = JsonConvert.DeserializeObject<EmployeeDetails>(await response.Content.ReadAsStringAsync());
            return postclient;

        }
        public async Task<bool> deleteMedicalCondition(string id)
        {
            var medical = new HttpClient();
            string url = $"https://localhost:7116/api/LoginReg/{id}";
            HttpResponseMessage response = await medical.DeleteAsync(url);
            bool coverage = JsonConvert.DeserializeObject<bool>(await response.Content.ReadAsStringAsync());
            return coverage;
        }

    }
}
