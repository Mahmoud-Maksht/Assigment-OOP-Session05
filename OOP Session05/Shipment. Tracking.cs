namespace OOP_Session05;

public partial class Shipment
{
    public string TrackingStatus { get; private set; } = "Pending";

    public string GetTrackingStatus()
    {
        return TrackingStatus;
    }

    public void UpdateTrackingStatus(string newStatus)
    {
        if (!string.IsNullOrWhiteSpace(newStatus))
            TrackingStatus = newStatus;
    }
}
