using System;

namespace OOP04
{
    public abstract class Shipment
    {

        private string trackingCode;
        private string description;
        private double weight;
        private decimal deliveryFee;

       
        public string TrackingCode
        {
            get { return trackingCode; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    trackingCode = value;
                else
                    trackingCode = "Unknown";
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    description = value;
                else
                    description = "Unknown";
            }
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                    weight = value;
                else
                    weight = 1;
            }
        }

        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            set
            {
                if (value >= 0)
                    deliveryFee = value;
                else
                    deliveryFee = 50;
            }
        }

        public DeliveryAddress Destination { get; set; }

        public virtual decimal EstimatedDeliveryTCost
        {
            get { return DeliveryFee + ((decimal)Weight * 5); }
        }

        // Constructors
        public Shipment(string trackingCode)
            : this(trackingCode, "Unknown", 1, 50, new DeliveryAddress("Unknown", "Unknown", 0))
        {
        }

        public Shipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }

        // Methods
        public void UpdateDeliveryFee(decimal updatedFee)
        {
            if (updatedFee >= 0)
                DeliveryFee = updatedFee;
        }
        public void UpdateWeight(double newWeight)
        {

            Weight = newWeight;
        }

        public void UpdateWeight(double newWeight, double extraPackingWeight)
        {
            if (extraPackingWeight > 0)
                Weight = newWeight + extraPackingWeight;
            else
                Weight = newWeight;
        }

        public virtual void PrintShipmentDetails()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Delivery Fee: {DeliveryFee}");
            Console.WriteLine($"Estimated Total Cost: {EstimatedDeliveryTCost}");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
        }
        public abstract decimal EstimatedCost { get; }

        public abstract void printShipment();
    }
}