using System.Diagnostics.Contracts;
using System.Xml.Linq;

namespace OOP04
{
    internal class Program
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
        }
    }
}
