using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories.Implementations
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        public IEnumerable<Client> GetClients()
        {
            // Mock database clients due to we arent using any Database so far.            
            var clients = new List<Client>
            {
                new Client
                {
                    Id = 1,
                    Name = "Jhon",
                    Type = TypeEnum.Corporate
                },
                new Client
                {
                    Id = 2,
                    Name = "Ricardo",
                    Type = TypeEnum.Venue
                }
            };

            return clients;
        }
    }
}
