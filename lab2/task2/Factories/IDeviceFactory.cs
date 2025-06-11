﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.Devices;

namespace task2.Factories
{
    interface IDeviceFactory
    {
        IDevice InitiateLaptop();
        IDevice InitiateNetbook();
        IDevice InitiateEBook();
        IDevice InitiateSmartphone();
    }
}