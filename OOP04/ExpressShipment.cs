using System;

namespace OOP04
{
    
    public class ExpressShipment : Shipment, ITrackable, IInsurable
    {
        private decimal extraFee;

        public decimal ExtraFee
        {
            get { return extraFee; }
            set
            {
                if (value >= 0)
                    extraFee = value;
                else
                    extraFee = 0;
            }
        }

        
        public override decimal EstimatedCost
        {
            get { return DeliveryFee + ExtraFee; }
        }

        public ExpressShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }

       
        public override void printShipment()
        {
            Console.WriteLine($"[Express Shipment] Code: {TrackingCode}, Cost: {EstimatedCost:C}");
            Console.WriteLine($"Extra Fee: {ExtraFee:C}");
        }

        
        public string GetTrackingStatus()
        {
            return $"Express Shipment {TrackingCode} is out for fast delivery.";
        }

       
        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.8m;
        }
    }
}