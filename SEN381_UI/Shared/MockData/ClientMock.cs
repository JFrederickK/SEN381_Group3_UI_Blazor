using SEN381_UI.Data;

namespace SEN381_UI.Shared.MockData
{
    public class ClientMock
    {
        public List<Client> GetClients()
        {
            List<Client> clients = new List<Client>();
            clients.Add(new Client("1", "Jandre", "Kruger", "27 sonnevled", "Jandre@gmail", "1234567891", new ClientPolicy(), "Approved", "notes"));
            clients.Add(new Client("1", "Jandre", "Kruger", "27 sonnevled", "Jandre@gmail", "1234567891", new ClientPolicy(), "Approved", "notes"));
            clients.Add(new Client("1", "Jandre", "Kruger", "27 sonnevled", "Jandre@gmail", "1234567891", new ClientPolicy(), "Approved", "notes"));
            clients.Add(new Client("1", "Jandre", "Kruger", "27 sonnevled", "Jandre@gmail", "1234567891", new ClientPolicy(), "Approved", "notes"));
            clients.Add(new Client("1", "Jandre", "Kruger", "27 sonnevled", "Jandre@gmail", "1234567891", new ClientPolicy(), "Approved", "notes"));
            clients.Add(new Client("1", "Jandre", "Kruger", "27 sonnevled", "Jandre@gmail", "1234567891", new ClientPolicy(), "Approved", "notes"));
            clients.Add(new Client("1", "Jandre", "Kruger", "27 sonnevled", "Jandre@gmail", "1234567891", new ClientPolicy(), "Approved", "notes"));
            return clients;

        }


    }
}


