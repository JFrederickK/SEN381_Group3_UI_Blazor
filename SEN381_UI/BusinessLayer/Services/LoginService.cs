using Newtonsoft.Json;
using SEN381_UI.Data;

namespace SEN381_UI.BusinessLayer.Services
{
    public class LoginService
    {
        public async Task<EmployeeDetails?> getLoginByEmail(string email, string password, string name)
        {
            HttpClient client = new HttpClient();
            string url = $"https://localhost:7116/api/LoginReg/Login?email={email}&password={password}&name={name}";
            url = url.Replace("@","%40");
            HttpResponseMessage response = await client.GetAsync(url);
            EmployeeDetails? emp = JsonConvert.DeserializeObject<EmployeeDetails?>(await response.Content.ReadAsStringAsync());
            Console.WriteLine(emp);
            return emp;
        }
        public async Task<EmployeeDetails?> postEmployee(EmployeeDetails person)
        {
            var medical = new HttpClient();
            string url = $"https://localhost:7116/api/LoginReg/";
            HttpResponseMessage response = await medical.PostAsJsonAsync(url, person);
            EmployeeDetails? postEmp = JsonConvert.DeserializeObject<EmployeeDetails?>(await response.Content.ReadAsStringAsync());
            return postEmp;

        }
    }
}