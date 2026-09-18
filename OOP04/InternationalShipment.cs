using OOP04;
using System;

namespace OOP04
{
    public class InternationalShipment : Shipment, ITrackable, IInsurable
    {
        private string DestinationCountry;
        private decimal CustomsFee;

        public string DestinationCountryProperty
        {
            get { return DestinationCountry; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    DestinationCountry = value;
                else
                    DestinationCountry = "Unknown";
            }
        }

        public decimal CustomsFeeproperty
        {
            get { return CustomsFee; }
            set
            {
                if (value >= 0)
                    CustomsFee = value;
                else
                    CustomsFee = 0;
            }
        }

       
        public override decimal EstimatedCost
        {
            get { return DeliveryFee + CustomsFee; }
        }

        public InternationalShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountryProperty = destinationCountry;
            CustomsFeeproperty = customsFee;
        }

        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine($"Customs Report generated for {TrackingCode} to {DestinationCountry}. Fee: {CustomsFee:C}");
        }

        
        public override void printShipment()
        {
            Console.WriteLine($"[International Shipment] Code: {TrackingCode}, Cost: {EstimatedCost:C}");
            Console.WriteLine($"Destination Country: {DestinationCountryProperty}");
            Console.WriteLine($"Customs Fee: {CustomsFeeproperty:C}");
        }

        public string GetTrackingStatus()
        {
            return $"International Shipment {TrackingCode} to {DestinationCountryProperty} is in transit.";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.12m;
        }
    }
}