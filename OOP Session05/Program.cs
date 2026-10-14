namespace OOP_Session05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            #region Q1
            //a - What happens when you assign one object variable to another object variable?
            // Both variables reference the same object in memory, so they access the same data. Any changes made through one variable will be reflected when accessing the object through the other variable.
            // b - Does assigning one object to another create a new object? Explain.
            // No, because Both variables reference the same object in memory
            // c - What is the difference between copying an object and copying its reference?
            // Copying an object: Creates a separate object in memory, so changes to one object do not affect the other.
            // Copying a reference: Both variables refer to the same object in memory, so changes made through one variable affect the same object accessed by the other.

            #endregion

            #region Q2
            //a- What is a Shallow Copy?
            // A Shallow Copy creates a new object and copies its fields. Value types are copied independently, while reference types share the same referenced objects.
            // b- What is a Deep Copy?
            // A deep copy creates a new object and copies all its fields, including referenced objects, so the original and the copy are completely independent.
            // c- What happens to reference-type members when a Shallow Copy is created?
            // When a Shallow Copy is created, the reference-type members are copied, but they still point to the same objects in memory as the original object.
            // d- What happens to reference-type members when a Deep Copy is created?
            // When a Deep Copy is created, the reference-type members are also copied, and new instances of the referenced objects are created, so the original and the copy are completely independent.
            // e- Give one situation where Deep Copy would be safer than Shallow Copy.
            // Deep Copy is safer when copying an object that contains reference types, such as an address. It prevents changes to the copied object from affecting the original object.
            #endregion

            #region Q3
            // a- What is a static field, and how is it different from an instance field?
            // A static field belongs to the class itself and is shared among all instances of the class, while an instance field belongs to a specific object and can have different values for each instance.
            // b- What is a static method? Can a static method directly access instance members?
            // A static method belongs to the class itself and can be called without creating an instance of the class. It cannot directly access instance members because it does not have a reference to a specific object.
            // c- What is a static constructor, and when is it executed?
            // A static constructor initializes static data. It is executed automatically once, before the class is used for the first time.
            // d- What is a static class? Can you create an object from a static class?
            // A static class is a class that contains only static members. You cannot create an object from a static class.

            #endregion

            #region Q4
            // a- What is an Extension Method ?
            // An extension method is a static method that can be called as if it were an instance method of the extended type.
            // b- What keyword must be used in the first parameter of an extension method?
            // The keyword "this" must be used in the first parameter of an extension method.
            // c- Where must an extension method be declared?
            // An extension method must be declared in a static class.
            // d- Can an extension method access private members of the class it extends?
            // No, an extension method cannot access private members of the class it extends. It can only access public and protected members.

            #endregion

            #region Q5
            //a - What is a Partial Class ?
            // A partial class allows a class to be split across multiple files.
            // b- Why would a developer split one class into multiple files?
            // A developer might split a class into multiple files to improve code organization, maintainability, and collaboration among team members.

            #endregion

            #endregion

            #region Part02
            Console.WriteLine("---------- before copying ----------");
            DeliveryAddress address1 = new DeliveryAddress("New York", "5th Avenue", 123);
            Shipment shipment1 = new Shipment("S101", "Laptop", 15, 10, address1, 0);
            Shipment shipment2 = shipment1;
            Shipment shipment3 = shipment1.ShallowCopyShipment();
            Shipment shipment4 = shipment1.DeepCopyShipment();
            Console.WriteLine("----------- Shipment 1 object -----------");
            shipment1.PrintShipmentDetails();
            Console.WriteLine("----------- Shipment 2 object -----------");
            shipment2.PrintShipmentDetails();
            Console.WriteLine("----------- Shipment 3 shallow copy -----------");
            shipment3.PrintShipmentDetails();
            Console.WriteLine("----------- Shipment 4 deep copy -----------");
            shipment4.PrintShipmentDetails();

            Console.WriteLine("---------- After copying ----------");
            shipment2.Destination.city = "Los Angeles";
            shipment2.Destination.street = "Sunset Boulevard";
            shipment2.Destination.buildingNumber = 456;
            shipment2.TrackingCode = "S202";
            shipment2.Description = "Smartphone";
            shipment2.Weight = 5;
            shipment2.DeliveryFee = 20;
            shipment3.Destination.city = "Giza";
            shipment3.Destination.street = "Pyramid Street";
            shipment3.Destination.buildingNumber = 564;
            shipment3.TrackingCode = "S111";
            shipment3.Description = "Tablet";
            shipment3.Weight = 7;
            shipment3.DeliveryFee = 12;
            shipment4.Destination.city = "Cairo";
            shipment4.Destination.street = "El Nile Street";
            shipment4.Destination.buildingNumber = 968;
            shipment4.TrackingCode = "S777";
            shipment4.Description = "Camera";
            shipment4.Weight = 6;
            shipment4.DeliveryFee = 9;
            Console.WriteLine("----------- Shipment 1 object -----------");
            shipment1.PrintShipmentDetails();
            Console.WriteLine("----------- Shipment 2 object -----------");
            shipment2.PrintShipmentDetails();
            Console.WriteLine("----------- Shipment 3 shallow copy -----------");
            shipment3.PrintShipmentDetails();
            Console.WriteLine("----------- Shipment 4 deep copy -----------");
            shipment4.PrintShipmentDetails();
            Console.WriteLine("---------- Reference Comparison ----------");
            Console.WriteLine($"Shipment 1 and Shipment 2 are the same object: " + $"{ReferenceEquals(shipment1, shipment2)}"); 
            Console.WriteLine($"Shipment 1 and Shipment 3 are the same object: " + $"{ReferenceEquals(shipment1, shipment3)}"); 
            Console.WriteLine($"Shipment 1 and Shipment 4 are the same object: " + $"{ReferenceEquals(shipment1, shipment4)}"); 
            Console.WriteLine($"Shipment 1 and Shipment 3 have the same address object: " + $"{ReferenceEquals(shipment1.Destination, shipment3.Destination)}");
            Console.WriteLine($"Shipment 1 and Shipment 4 have the same address object: " + $"{ReferenceEquals(shipment1.Destination, shipment4.Destination)}");

            
            #endregion
        }
    }
}
