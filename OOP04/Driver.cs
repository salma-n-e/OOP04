using System;

namespace OOP04
{
    public class Driver
    {
        public int DriverId { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }

        public Driver(int driverId, string fullName, string phoneNumber)
        {
            DriverId = driverId;
            FullName = fullName;
            PhoneNumber = phoneNumber;
        }

        public void PrintDriverInfo()
        {
            Console.WriteLine($"Driver ID: {DriverId}, Name: {FullName}, Phone: {PhoneNumber}");
        }
    }
}