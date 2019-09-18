using Models;
using System.Collections.Generic;

namespace WebApplication1.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Client> AvailableClients { get; set; }

        public HomeVM()
        {
            AvailableClients = new List<Client>();
        }
    }
    
}