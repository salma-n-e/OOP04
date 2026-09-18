using System;

namespace OOP04
{
    
    public class StandardShipment : Shipment, ITrackable, IInsurable
    {
        public StandardShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }

        
        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (decimal)(Weight * 1.5); }
        }

        
        public override void printShipment()
        {
            Console.WriteLine(" Standard Shipment Details ");
            Console.WriteLine($"[Standard Shipment] Code: {TrackingCode}, Cost: {EstimatedCost:C}");
        }

        
        public string GetTrackingStatus()
        {
            return $"Standard Shipment {TrackingCode} is in transit.";
        }

        
        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05m;
        }
    }
}