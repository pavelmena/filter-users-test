using System.Collections.Generic;
using System.Linq;
using Data.Repositories;
using Models;

namespace Services.Implementations
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public IEnumerable<Client> GetClients(TypeEnum? type)
        {
            var clients = _clientRepository.GetClients();

            // Filter area
            if (type.HasValue)
            {
                clients = clients.Where(c => c.Type == type.Value).ToList();
            }

            return clients;
        }
    }
}
