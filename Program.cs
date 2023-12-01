Pack pack = new Pack(10, 10, 10);
InventoryItem arrow1 = new Arrow();
InventoryItem rope1 = new Rope();
InventoryItem arrow2 = new Arrow();
InventoryItem rope2 = new Rope();

pack.Add(arrow1);
pack.Add(rope1);
pack.Add(arrow2);
pack.Add(rope2);

Console.WriteLine(pack.ToString());

// Classes 

public class InventoryItem
{
    public double Weight { get; set; }
    public double Volume { get; set; }

    public InventoryItem(double weight, double volume)
    {
        Weight = weight;
        Volume = volume;
    }

}

public class Arrow : InventoryItem
{
    public Arrow() : base(0.1, 0.05)
    {
    }
    public override string ToString()
    {
        return "Arrow";
    }
}
public class Bow : InventoryItem
{
    public Bow() : base(1, 4)
    {
    }
    public override string ToString()
    {
        return "Bow";
    }
}
public class Rope : InventoryItem
{
    public Rope() : base(1, 1.5)
    {
    }
    public override string ToString()
    {
        return "Rope";
    }
}
public class Water : InventoryItem
{
    public Water() : base(2, 3)
    {
    }
    public override string ToString()
    {
        return "Water";
    }
}
public class Food : InventoryItem
{
    public Food() : base(1, 0.5)
    {
    }
    public override string ToString()
    {
        return "Food";
    }
}
public class Sword : InventoryItem
{
    public Sword() : base(5, 3)
    {
    }
    public override string ToString()
    {
        return "Sword";
    }
}

public class Pack
{
    private InventoryItem[] _items;
    public int TotalItems { get; set; }
    public double MaxVolume { get; set; }
    public double MaxWeight { get; set; }
    public double TotalWeight { get; set; }
    public double TotalVolume { get; set; }

    public Pack(double maxWeight, double maxVolume, int maxItems)
    {
        MaxWeight = maxWeight;
        MaxVolume = maxVolume;
        _items = new InventoryItem[maxItems];
    }

    public bool Add(InventoryItem item)
    {
        if (item.Weight + TotalWeight < MaxWeight
            && item.Volume + TotalVolume < MaxVolume)
        {
            TotalWeight += item.Weight;
            TotalVolume += item.Volume;
            _items[TotalItems] = item;          
            TotalItems++;
            return true;
        }
        return false;
    }

    public override string ToString()
    {
        string itemToStr = "";
        foreach (var item in _items)
        {
             itemToStr += item + " ";
        }
        return $"Pack containing {itemToStr}";
    }

}