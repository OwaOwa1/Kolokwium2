using Kolokwium_2.Models;

namespace Kolokwium_2.Services
{
    public class Class : Interface
    {
        private readonly Class1 _context;
        public Class(Class1 context)
        {
            _context = context;
        }
    }
}
