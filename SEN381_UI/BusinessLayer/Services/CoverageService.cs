using SEN381_UI.Data;
using Newtonsoft.Json;
using System;

namespace SEN381_UI.BusinessLayer.Services
{
    public class CoverageService
    {

        public async Task<List<Coverage>> getCoverages(int size, int page)
        {
            var client = new HttpClient();
            string url = $"https://localhost:7116/api/Coverage?page={page}&size={size}";
            HttpResponseMessage response = await client.GetAsync(url);
            List<Coverage> coverages= JsonConvert.DeserializeObject<List<Coverage>>(await response.Content.ReadAsStringAsync());
            if (coverages !=null)
            {
                Console.WriteLine(coverages);
                return coverages;
            }
            return new List<Coverage>();
        }

        public async Task<Coverage> addCoverage(Coverage cov)
        {
            var client = new HttpClient();
            string url = $"https://localhost:7116/api/Coverage";
            HttpResponseMessage response = await client.PostAsJsonAsync(url,cov);
            Coverage coverage = JsonConvert.DeserializeObject<Coverage>(await response.Content.ReadAsStringAsync());

            Console.WriteLine(coverage);
            return coverage;

        }
    }
}
