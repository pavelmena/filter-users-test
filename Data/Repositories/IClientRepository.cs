using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public interface IClientRepository : IGenericRepository<Client>
    {
        IEnumerable<Client> GetClients();
    }
}
