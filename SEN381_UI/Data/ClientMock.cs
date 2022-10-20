using SEN381_UI.Data;

namespace SEN381_UI.Data
{
    public class ClientMock
    {
        public List<Client> GetClients() {
        List<Client> clients = new List<Client>();
            clients.Add(new Client("1", "Jandre", "Kruger","27Sonneveld", "jandreKruger01@gmail.com", "0786077697", "1", "Approved", "needed"));
            return clients;
        }
    }
}
