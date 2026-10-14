namespace OOP_Session05;

internal class PriorityInternationalShipment: InternationalShipment
{
    public sealed override void GenerateCustomsReport()
    {
        Console.WriteLine("Priority Customs Report");
    }
    public PriorityInternationalShipment(string trackingcode, string description, double weight, decimal deliveryfee, DeliveryAddress destination, string destinationcountry, decimal customfee, int shipmentCount) : base(trackingcode, description, weight, deliveryfee, destination, destinationcountry, customfee, shipmentCount )
    {
        
    }
}
