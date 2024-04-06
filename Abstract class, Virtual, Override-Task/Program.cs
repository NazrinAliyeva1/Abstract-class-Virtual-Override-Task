using Abstract_class__Virtual__Override_Task.Models;

namespace Abstract_class__Virtual__Override_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(433, true);
            Bicycle bicycle = new Bicycle("Elektrikli");
            Console.WriteLine(bicycle._type);

            Console.WriteLine("\nDiger hala baxsaq:");

            Car car2 = new Car(212, false);
            Bicycle bicycle2 = new Bicycle("Elektriksiz");
            Console.WriteLine(bicycle2._type);

            Object[] objects = new Object[] { car, bicycle, car2, bicycle2 };

            Console.WriteLine("\nObjects melumatlari: ");
            foreach(var obj in objects)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
