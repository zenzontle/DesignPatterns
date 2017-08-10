using System;

namespace Concepts.Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();

            VehicleBuilder builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.VehicleInstance.Show();

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.VehicleInstance.Show();

            Console.ReadKey();
        }
    }
}
