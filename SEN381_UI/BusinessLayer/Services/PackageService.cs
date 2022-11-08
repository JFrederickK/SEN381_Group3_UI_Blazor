using Newtonsoft.Json;
using SEN381_UI.Data;

namespace SEN381_UI.BusinessLayer.Services
{
    public class PackageService
    {
        public async Task<List<Package>> getPackages(int size, int page)
        {
            HttpClient client = new HttpClient();
            string url = $"https://localhost:7116/api/Package?page={page}&size={size}";
            HttpResponseMessage response = await client.GetAsync(url);
            List<Package> packages = JsonConvert.DeserializeObject<List<Package>>(await response.Content.ReadAsStringAsync());
            if (packages != null)
            {
                return packages;
            }
            return new List<Package>();
        }

        public async Task<Package> addPackage(Package package)
        {
            Console.WriteLine(package.PackageID);
            Console.WriteLine(package.PackageEndDate);
            Console.WriteLine(package.PackageStartDate);
            Console.WriteLine(package.TreatmentCoverages.Count);
            HttpClient client = new HttpClient();
            string url = $"https://localhost:7116/api/Package";
            HttpResponseMessage response = await client.PostAsJsonAsync<Package>(url, package);
            Package pack = JsonConvert.DeserializeObject<Package>(await response.Content.ReadAsStringAsync());
            Console.WriteLine(pack);
            return pack;

        }

        public async Task<Package> getPacakgeDetails(string id)
        {
            HttpClient client = new HttpClient();
            string url = $"https://localhost:7116/api/Package/{id}";
            HttpResponseMessage response = await client.GetAsync(url);
            Package package = JsonConvert.DeserializeObject<Package>(await response.Content.ReadAsStringAsync());
            if (package != null)
            {
                return package;
            }
            return null;
        }

        public async Task<Package> deletePackage(string id)
        {
            HttpClient client = new HttpClient();
            string url = $"https://localhost:7116/api/Package/{id}";
            HttpResponseMessage response = await client.DeleteAsync(url);
            Package pack = JsonConvert.DeserializeObject<Package>(await response.Content.ReadAsStringAsync());

            return pack;

        }

        public async Task<Package> updatePackage(Package package)
        {
            HttpClient client = new HttpClient();
            string url = $"https://localhost:7116/api/Package/{package.PackageID}";
            HttpResponseMessage response = await client.PutAsJsonAsync<Package>(url, package);
            Package pack = JsonConvert.DeserializeObject<Package>(await response.Content.ReadAsStringAsync());

            return pack;

        }
    }
}
