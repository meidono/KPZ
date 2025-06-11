using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.Devices;

namespace task2.Factories
{
    class BalaxyFactory : IDeviceFactory
    {
        public IDevice InitiateLaptop() => new Laptop("Balaxy");
        public IDevice InitiateNetbook() => new Netbook("Balaxy");
        public IDevice InitiateEBook() => new EBook("Balaxy");
        public IDevice InitiateSmartphone() => new Smartphone("Balaxy");
    }
}
