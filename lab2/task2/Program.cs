using System.Text;
using task2.Devices;
using task2.Factories;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        IDeviceFactory iproneFactory = new IProneFactory();
        IDeviceFactory kiaomiFactory = new KiaomiFactory();
        IDeviceFactory balaxyFactory = new BalaxyFactory();

        IDevice iproneLaptop = iproneFactory.InitiateLaptop();
        IDevice kiaomiSmartphone = kiaomiFactory.InitiateSmartphone();
        IDevice balaxyEBook = balaxyFactory.InitiateEBook();

        iproneLaptop.DisplayInfo();
        kiaomiSmartphone.DisplayInfo();
        balaxyEBook.DisplayInfo();
    }
}