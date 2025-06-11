
using ConsoleApp.Classes;


class Program
{

   static void  Main(string[] args)
    {

        Money money = new Money(10, 2);
        Console.WriteLine(money);
        money.SetCash(1,3);
        Console.WriteLine(money);
        
        Product product = new Product("Phone", new Money(92299, 00));
        Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
        product.PriceDecrease(100, 50);
        Console.WriteLine($"New Price: {product.Price}");

        Warehouse warehouse = new Warehouse("Router", "Units", new Money(1500, 00), 139, DateTime.Now);
        Console.WriteLine($"Warehouse: {warehouse.Name}, Stock: {warehouse.Quantity} {warehouse.Unit}");
        warehouse.UpdateStock(23, DateTime.Now);
        Console.WriteLine($"Updated Stock: {warehouse.Quantity} {warehouse.Unit}");

        Reporting reporting = new Reporting();
        reporting.RegisterSupply(warehouse);
        reporting.RegisterShipment("Router", 3);
        reporting.InventoryReport();

    }
    
    
    
}