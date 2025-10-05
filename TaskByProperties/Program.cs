using System;

class InventoryItem
{
    private string _name;
    private byte _quantity;

    public InventoryItem(string name, byte quantity)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("Name cannot be empty!");
        this._name = name;
        this._quantity = quantity;
    }

    public byte Quantity
    {
        get => _quantity;
        set
        {
            if (value < 0 || value > 64)
                throw new ArgumentException("Quantity cannot be negative!");
            _quantity = value;
        }
    }

    public void Print()
    {
        Console.WriteLine($"Item: {_name}, Quantity: {Quantity}");
    }
}

class Program
{
    static void Main()
    {
        InventoryItem inventoryItem_1 = new InventoryItem(name: "Wood", quantity: 64);
        InventoryItem inventoryItem_2 = new InventoryItem(name: "Iron", quantity: 48);
        InventoryItem inventoryItem_3 = new InventoryItem(name: "Diamonds", quantity: 12);

        InventoryItem[] items = { inventoryItem_1, inventoryItem_2, inventoryItem_3 };
        
        foreach (var item in items)
        {
            item.Print();
        }
    }
}