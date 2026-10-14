namespace OOP_Session05;

public class DeliveryAddress
{
    private string City;
    private string Street;
    private int BuildingNumber;

    public DeliveryAddress( string city, string streetint ,int buildingNumber )
    {
        City = city;
        Street = street;
        BuildingNumber = buildingNumber;
    }
    public string city
    {
        get { return City; }
        set { City = value; }
    }
    public string street
    {
        get { return Street; }
        set { Street = value; }
    }
    public int buildingNumber
    {
        get { return BuildingNumber; }
        set { BuildingNumber = value; }
    }

    public string GetFullAddress()
    {
        return $"{BuildingNumber} {Street} {City}";
    }
}

