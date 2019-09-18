using Models;
using System;
using System.Collections.Generic;

namespace Services
{
    public interface IClientService
    {
        IEnumerable<Client> GetClients(TypeEnum? type);
    }
}
