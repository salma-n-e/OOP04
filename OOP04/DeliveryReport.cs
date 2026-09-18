using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    public class DeliveryReport 
    {

        public static void PrintShipment(ITrackable shipment)
        {
            if (shipment != null)
            {
                Console.WriteLine(shipment.GetTrackingStatus()); 
            }
        }

        public static void PrintInsurance(IInsurable shipment) 
        {
            if (shipment != null)
            {
                Console.WriteLine($"Insurance Cost: {shipment.CalculateInsurance():C}"); 
            }
        }
    }
}
