namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires does your vehicle have?");
            int amountOftires = int.Parse(Console.ReadLine());
            var vehicle = VehicleFactory.GetVehicle(amountOftires);
            vehicle.Drive();
        }
    }
}