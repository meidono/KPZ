using ConsoleApp.Classes;

namespace ConsoleApp.Interfaces;

public interface IReporting
{
    void RegisterSupply(Warehouse item);
    void RegisterShipment(string name, int quantity);
    void InventoryReport();
}