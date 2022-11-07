using Newtonsoft.Json;
using SEN381_UI.Data;

namespace SEN381_UI.BusinessLayer.Services
{
    public class FamilyMemberService
    {
        public async Task<List<FamilyMember>> LoadFamilyMembers(string clientID)
            {
                using var client = new HttpClient();

                var result = await client.GetAsync($"https://localhost:7116/api/FamilyMember?clientID={clientID}");
                var resp = await result.Content.ReadAsStringAsync();
                List<FamilyMember> fam = JsonConvert.DeserializeObject<List<FamilyMember>>(resp);
                return fam;

            }
            public async Task<FamilyMember> getFamilyMemberDetails(string id)
            {
                HttpClient client = new HttpClient();
                string url = $"https://localhost:7116/api/FamilyMember/{id}";
                HttpResponseMessage response = await client.GetAsync(url);
                FamilyMember newclient = JsonConvert.DeserializeObject<FamilyMember>(await response.Content.ReadAsStringAsync());
                return newclient;
            }

            public async Task<FamilyMember> postFamilyMember(FamilyMember person)
            {
                var client = new HttpClient();
                string url = $"https://localhost:7116/api/FamilyMember";
                HttpResponseMessage response = await client.PostAsJsonAsync(url, person);
                FamilyMember postclient = JsonConvert.DeserializeObject<FamilyMember>(await response.Content.ReadAsStringAsync());
                return postclient;

            }
            public async Task<FamilyMember> deleteFamilymember(string id)
            {
                var client = new HttpClient();
                string url = $"https://localhost:7116/api/FamilyMember/{id}";
                HttpResponseMessage response = await client.DeleteAsync(url);
                FamilyMember fam = JsonConvert.DeserializeObject<FamilyMember>(await response.Content.ReadAsStringAsync());
                return fam;

            }

            public async Task<FamilyMember> updateFamilyMember(FamilyMember fam)
            {
                var client = new HttpClient();
                string url = $"https://localhost:7116/api/FamilyMember/{fam.MemberId}";
                HttpResponseMessage response = await client.PutAsJsonAsync(url, fam);
                FamilyMember famMem = JsonConvert.DeserializeObject<FamilyMember>(await response.Content.ReadAsStringAsync());
                return famMem;

            }


    }
}

