namespace parqueo.Controllers
{
    using parqueo.Data;
    using parqueo.Models;
    using System.Linq;

    class ClientController
    {
        parqueodbEntities _db = new parqueodbEntities();

        public ClientModel SearchClient(int ciClient)
        {
            Client clientResponse = _db.Client.Where(c => c.ci == ciClient).FirstOrDefault();
            ClientModel client = null;
            if (clientResponse != null)
            {
                client = new ClientModel { 
                FullName = clientResponse.name + clientResponse.lastname,
                Address = clientResponse.address,
                CI = ciClient,
                Email = clientResponse.email,
                Phone = clientResponse.phone,
                SecondPhone = clientResponse.phone2,
                Type = clientResponse.type,
                };
            }
            
            return client;
        }

        public bool SaveClient(ClientModel newClient) 
        {
            Client clientToSave = new Client
            {
                name = newClient.Name,
                lastname = newClient.LastName,
                address = newClient.Address,
                ci = newClient.CI,
                email = newClient.Email,
                phone = newClient.Phone,
                type = "Premium"
            };
            try
            {
                Client client = _db.Client.Add(clientToSave);
                if (client != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}
