using SEN381_API_Group3.shared.models;

namespace SEN381_UI.Data
{
    public class ClientMock
    {
        public List<Client> GetClients() { 
        List<Client> clients = new List<Client>();
            clients.Add(new Client("1", "Jandre","Kruger", "27 sonnevled", "Jandre@gmail", "1234567891", "1", "Approved", "notes"));
            clients.Add(new Client("1", "Jandre", "Kruger", "27 sonnevled", "Jandre@gmail", "1234567891", "1", "Approved", "notes"));
            clients.Add(new Client("1", "Jandre", "Kruger", "27 sonnevled", "Jandre@gmail", "1234567891", "1", "Approved", "notes"));
            clients.Add(new Client("1", "Jandre", "Kruger", "27 sonnevled", "Jandre@gmail", "1234567891", "1", "Approved", "notes"));
            clients.Add(new Client("1", "Jandre", "Kruger", "27 sonnevled", "Jandre@gmail", "1234567891", "1", "Approved", "notes"));
            clients.Add(new Client("1", "Jandre", "Kruger", "27 sonnevled", "Jandre@gmail", "1234567891", "1", "Approved", "notes"));
            clients.Add(new Client("1", "Jandre", "Kruger", "27 sonnevled", "Jandre@gmail", "1234567891", "1", "Approved", "notes"));

            return clients;
        }
    }
}
