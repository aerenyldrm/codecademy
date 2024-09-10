using System;
using System.Collections.Generic;

public class InventoryManagement
{
    public static void Main()
    {
        List<string> inventoryList = ["Printer", "Laptop", "Desk Chair", "Monitor", "Keyboard"];
        Console.WriteLine(inventoryList.Count);

        bool removed = inventoryList.Remove("Printer");
        Console.WriteLine(removed);

        foreach (string inventory in inventoryList) Console.WriteLine(inventory);

        List<string> newItems = ["Mouse", "Desk Lamp"];
        inventoryList.AddRange(newItems);

        inventoryList.RemoveRange(4, 2);
        List<string> topInventory = inventoryList.GetRange(0, 3);

        foreach (string inventory in topInventory) Console.WriteLine(inventory);
    }
}