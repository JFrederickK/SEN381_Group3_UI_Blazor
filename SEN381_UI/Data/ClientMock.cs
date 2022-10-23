<<<<<<< HEAD
﻿using SEN381_API_Group3.shared.models;
=======
﻿using SEN381_UI.Data;
>>>>>>> 820f74fbb66635f147d0241c8ce7db8d9f721cef

namespace SEN381_UI.Data
{
    public class ClientMock
    {
<<<<<<< HEAD
        public List<Client> GetClients() { 
        List<Client> clients = new List<Client>();
            clients.Add(new Client("1", "Jandre","Kruger", "27 sonnevled", "Jandre@gmail", "1234567891", "1", "Approved", "notes"));
            clients.Add(new Client("1", "Jandre", "Kruger", "27 sonnevled", "Jandre@gmail", "1234567891", "1", "Approved", "notes"));
            clients.Add(new Client("1", "Jandre", "Kruger", "27 sonnevled", "Jandre@gmail", "1234567891", "1", "Approved", "notes"));
            clients.Add(new Client("1", "Jandre", "Kruger", "27 sonnevled", "Jandre@gmail", "1234567891", "1", "Approved", "notes"));
            clients.Add(new Client("1", "Jandre", "Kruger", "27 sonnevled", "Jandre@gmail", "1234567891", "1", "Approved", "notes"));
            clients.Add(new Client("1", "Jandre", "Kruger", "27 sonnevled", "Jandre@gmail", "1234567891", "1", "Approved", "notes"));
            clients.Add(new Client("1", "Jandre", "Kruger", "27 sonnevled", "Jandre@gmail", "1234567891", "1", "Approved", "notes"));

=======
        public List<Client> GetClients() {
        List<Client> clients = new List<Client>();
            clients.Add(new Client("1", "Jandre", "Kruger","27Sonneveld", "jandreKruger01@gmail.com", "0786077697", "1", "Approved", "needed"));
>>>>>>> 820f74fbb66635f147d0241c8ce7db8d9f721cef
            return clients;
        }
    }
}
