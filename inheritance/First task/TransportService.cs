using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class TransportService
    {
        public void printTransportType(Transport transport) => Console.WriteLine(transport.GetTypeOfTransport(transport));
    }
}
