using Newtonsoft.Json;
using SEN381_UI.Data;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace SEN381_UI.BusinessLayer
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

    }
}
