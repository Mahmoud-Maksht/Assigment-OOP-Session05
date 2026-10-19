namespace OOP_Session05;

public partial class Shipment
{
    private string trackingcode;
    private string description;
    private double weight;
    private decimal deliveryfee;
    private DeliveryAddress destination;
    public static int ShipmentCount { get; private set; } = 0;
    public string TrackingCode
    {
        get { return trackingcode; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value)) trackingcode = value;
        }

    }
    public string Description
    {
        get { return description; }
        set { if (!string.IsNullOrWhiteSpace(value)) description = value; }
    }
    public double Weight
    {
        get { return weight; }
        set { if (value > 0) weight = value; }
    }
    public decimal DeliveryFee
    {
        get { return deliveryfee; }
        set { if (value > 0) deliveryfee = value; }
    }
    public DeliveryAddress Destination
    {
        get { return destination; }
        set { destination = value; }
    }
    public virtual decimal EstimatedCost()
    {
        return DeliveryFee + (decimal)(Weight * 5);
    }

    public Shipment(string trackingcode)
    {
        TrackingCode = trackingcode;
        Description = "Unknown";
        Weight = 1;
        DeliveryFee = 50;
        Destination = default;
    }
    public Shipment(string trackingcode, string description, double weight, decimal deliveryfee, DeliveryAddress destination  )
    {
        TrackingCode = trackingcode;
        Description = description;
        Weight = weight;
        DeliveryFee = deliveryfee;
        Destination = destination;
        ShipmentCount++;
    }
    public decimal UpdateDeliveryFee(decimal newFee)
    {
        if (newFee > 0)
        {
            DeliveryFee = newFee;
        }
        return DeliveryFee;
    }

    public virtual void PrintShipmentDetails()
    {
        Console.WriteLine($"Tracking Code: {TrackingCode}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Weight: {Weight} kg");
        Console.WriteLine($"Delivery Fee: ${DeliveryFee}");
        Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
        Console.WriteLine($"Estimated Cost: ${EstimatedCost()}");
    }

    public void UpdateWeight(double newWeight)
    {
        if (newWeight > 0)
        {
            Weight = newWeight;
        }
    }
    public void UpdateWeight(double newWeight, double extraPackingWeight)
    {
        if (newWeight > 0 && extraPackingWeight >= 0)
        {
            Weight = newWeight + extraPackingWeight;
        }
    }

    public Shipment CopyShipment()
    {
        return new Shipment(TrackingCode, Description, Weight, DeliveryFee, Destination);
    }

    public Shipment ShallowCopyShipment()
    {
        return (Shipment)this.MemberwiseClone();
    }
    public Shipment DeepCopyShipment()
    {
        Shipment copy = (Shipment)this.MemberwiseClone();
        copy.Destination = new DeliveryAddress(Destination.city, Destination.street, Destination.buildingNumber);
        return copy;
    }
    
    public static int GetTotalShipments()
    {
        return ShipmentCount;
    }

}

