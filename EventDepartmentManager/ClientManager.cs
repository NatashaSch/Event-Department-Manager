using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDepartmentManager
{
    class ClientManager
    {
        private List<Client> clients = new List<Client>();

        public void addNewClient(Client client)
        {
            clients.Add(client);
        }
        public void removeClient(Client client)
        {
            clients.Remove(client);
        }

        public List<Client> getAllClients()
        {
            return clients;
        }

        public Client getOneClient(string name)
        {
            Client cl = new Client();
            foreach (var item in clients)
            {
                if (item.Name == name)
                {
                    cl = item;
                }
            }
            return cl;
        }

        public void editClient()
        {
            //this method will be implemented later 
        }
    }
}
