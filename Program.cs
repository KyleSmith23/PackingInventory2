Pack pack = new Pack(10, 10, 10);
InventoryItem arrow1 = new Arrow();
InventoryItem rope1 = new Rope();

pack.Add(arrow1);
pack.Add(rope1);







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
}
public class Bow : InventoryItem
{
    public Bow() : base(1, 4)
    {
    }
}
public class Rope : InventoryItem
{
    public Rope() : base(1, 1.5)
    {
    }
}
public class Water : InventoryItem
{
    public Water() : base(2, 3)
    {
    }
}
public class Food : InventoryItem
{
    public Food() : base(1, 0.5)
    {
    }
}
public class Sword : InventoryItem
{
    public Sword() : base(5, 3)
    {
    }
}

public class Pack
{
    public InventoryItem[] PackItems {  get; set; }
    public int TotalItems { get; set; }
    public double MaxVolume { get; set; }
    public double MaxWeight { get; set; }
    public double TotalWeight { get; set; }
    public double TotalVolume { get; set; }

    public Pack(double maxWeight, double maxVolume, int maxItems)
    {
        MaxWeight = maxWeight;
        MaxVolume = maxVolume;
        PackItems = new InventoryItem[maxItems];
    }

    public bool Add(InventoryItem item)
    {
        if (item.Weight + TotalWeight < MaxWeight
            && item.Volume + TotalVolume < MaxVolume)
        {
            TotalWeight += item.Weight;
            TotalVolume += item.Volume;
            PackItems.Append(item);          
            TotalItems++;
            return true;
        }
        return false;
    }
}