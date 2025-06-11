using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.Devices;

namespace task2.Factories
{
    class IProneFactory : IDeviceFactory
    {
        public IDevice InitiateLaptop() => new Laptop("IProne");
        public IDevice InitiateNetbook() => new Netbook("IProne");
        public IDevice InitiateEBook() => new EBook("IProne");
        public IDevice InitiateSmartphone() => new Smartphone("IProne");
    }
}
