namespace OOP_Session05;

internal static class ShipmentExtention
{
    public static string GetSummary(this Shipment shipment)
    {
        ITrackable trackable =(ITrackable)shipment;
        return $"{shipment.TrackingCode} | {shipment.GetType().Name.Replace("Shipment", "")} | {shipment.Weight} KG | {trackable.GetTrackingCodeStatus()}";
    }
    public static bool IsDelivered(this Shipment shipment)
    {
        ITrackable trackable = (ITrackable)shipment;

        return trackable.GetTrackingCodeStatus() == "Delivered";
    }
}
