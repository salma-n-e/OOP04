using System.Diagnostics.Contracts;
using System.Xml.Linq;

namespace OOP04
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Q 1
            // a) focuses on hiding complex implementation details from the user and displaying
            // only the essential features of an object.
            // b) It reduces code complexity, minimizes dependency tight-coupling, and improves maintainability

            // Q 2
            // a) Abstract Class: Serves as a base identity (is a relationship).
            // It can contain state (fields), implementation details (concrete methods), constructors,
            // access modifiers, and abstract method signatures.

            // Interface: Defines a contract / behavior(can do capability).
            // Historically contains only method and property declarations without instance state,
            // though modern languages allow default implementations.

            // b) Unrelated classes need to share a common behavior
            // c) Multiple Abstract Classes: No. Most object oriented languages
            // do not support multiple inheritance of classes .

            // Multiple Interfaces: Yes.A single class can implement multiple interfaces simultaneously.

            
            DeliveryAddress addr1 = new DeliveryAddress("Cairo", "Street 10" , 5);
            DeliveryAddress addr2 = new DeliveryAddress("Giza", "Street 5" , 89);
            DeliveryAddress addr3 = new DeliveryAddress("Alexandria", "Street 20" ,90);

            
            StandardShipment std = new StandardShipment("SH001", "Books", 2.5, 50m, addr1);

            
            ExpressShipment exp = new ExpressShipment("SH002", "Electronics", 1.2, 100m, addr2, 25m);

            
            InternationalShipment inter = new InternationalShipment("SH003", "Documents", 0.5, 200m, addr3, "Germany", 30m);


            DeliveryCenter center = new DeliveryCenter("Main Hub", 10);
                center.AddShipment(std);
                center.AddShipment(exp);
                center.AddShipment(inter);

               
                Console.WriteLine("========================================");
                Console.WriteLine("  All Shipment Details ");
                Console.WriteLine("========================================");
                center.PrintAllShipments();

                
                Console.WriteLine("========================================");
                Console.WriteLine("  Tracking Statuses via DeliveryCenter ");
                Console.WriteLine("========================================");
                center.PrintTrackingStatuses();

                
                Console.WriteLine("========================================");
                Console.WriteLine("  Insurance Costs via DeliveryReport ");
                Console.WriteLine("========================================");
                DeliveryReport.PrintInsurance(std);
                DeliveryReport.PrintInsurance(exp);
                DeliveryReport.PrintInsurance(inter);

                
                Console.WriteLine("========================================");
                Console.WriteLine("  Polymorphism via ITrackable Array ");
                Console.WriteLine("========================================");
                ITrackable[] trackables = new ITrackable[] { std, exp, inter };
                foreach (ITrackable item in trackables)
                {
                    DeliveryReport.PrintShipment(item);
                }

                
                Console.WriteLine("========================================");
                Console.WriteLine("  Polymorphism via IInsurable Array ");
                Console.WriteLine("========================================");
                IInsurable[] insurables = new IInsurable[] { std, exp, inter };
                foreach (IInsurable item in insurables)
                {
                    DeliveryReport.PrintInsurance(item);
                }
            }
        }
    }