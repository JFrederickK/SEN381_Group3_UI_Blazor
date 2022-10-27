namespace SEN381_UI.BusinessLayer.Services
{
    public class ClientService
    {
        public async void getClientList()
        {
            var client = new HttpClient();

            var result = await client.GetAsync("https://localhost:7116/api/Client");
            Console.WriteLine("Client:");
            Console.WriteLine(result.Content.ReadAsStream());
            
        }
    }
}
