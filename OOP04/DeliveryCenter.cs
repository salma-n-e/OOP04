using System;

namespace OOP04
{
    public class DeliveryCenter
    {
        private Shipment[] shipments;
        private int count;

        public string CenterName { get; set; }
        public Driver AssignedDriver { get; set; }

        public DeliveryCenter(string centerName, int capacity, Driver driver = null)
        {
            CenterName = centerName;
            shipments = new Shipment[capacity];
            count = 0;
            AssignedDriver = driver;
        }

        public void AddShipment(Shipment shipment)
        {
            if (count < shipments.Length && shipment != null)
            {
                shipments[count] = shipment;
                count++;
            }
        }

        public void RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < count; i++)
            {
                if (shipments[i].TrackingCode == trackingCode)
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        shipments[j] = shipments[j + 1];
                    }
                    shipments[count - 1] = null;
                    count--;
                    break;
                }
            }
        }

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < count)
                    return shipments[index];
                return null;
            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < count; i++)
                {
                    if (shipments[i].TrackingCode == trackingCode)
                        return shipments[i];
                }
                return null;
            }
        }

        public void PrintAllShipments()
        {
            Console.WriteLine($"All Shipments in {CenterName}");

            for (int i = 0; i < count; i++)
            {
                shipments[i].printShipment();
                Console.WriteLine("");
            }
        }

        
        public void PrintTrackingStatuses()
        {
            Console.WriteLine($" Tracking Statuses for {CenterName} ");

            for (int i = 0; i < count; i++)
            {
                
                if (shipments[i] is ITrackable trackableItem)
                {
                    Console.WriteLine(trackableItem.GetTrackingStatus()); 
                }
            }
        }
    }
}