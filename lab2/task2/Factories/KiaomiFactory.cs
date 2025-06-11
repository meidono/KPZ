using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.Devices;

namespace task2.Factories
{
    class KiaomiFactory : IDeviceFactory
    {
        public IDevice InitiateLaptop() => new Laptop("Kiaomi");
        public IDevice InitiateNetbook() => new Netbook("Kiaomi");
        public IDevice InitiateEBook() => new EBook("Kiaomi");
        public IDevice InitiateSmartphone() => new Smartphone("Kiaomi");
    }
}
