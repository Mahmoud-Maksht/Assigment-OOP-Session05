namespace OOP_Session05;

internal sealed class CompleteShipment : Shipment
{
    public CompleteShipment(string trackingcode, string description, double weight, decimal deliveryfee, DeliveryAddress destination , int shipmentCount) : base(trackingcode, description, weight, deliveryfee, destination , shipmentCount    )
    {
          
    }   
    public override decimal EstimatedCost()
    {
        return DeliveryFee + (decimal)(Weight * 5);
    }
    
    public override void PrintShipmentDetails()
    {
        Console.WriteLine($"Tracking Code: {TrackingCode}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Weight: {Weight} kg");
        Console.WriteLine($"Delivery Fee: ${DeliveryFee}");
        Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
        Console.WriteLine($"Estimated Cost: ${EstimatedCost()}");
    }
}

