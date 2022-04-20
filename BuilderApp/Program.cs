using BuilderLibrary;
using BuilderLibrary.Base;
using BuilderLibrary.VehicleBuilder;


/*
 
 Factory: Consider a restaurant. The creation of "today's meal" is a factory pattern, because you tell the kitchen "get me today's meal" and the kitchen (factory) decides what object to generate, based on hidden criteria.


Builder: The builder appears if you order a custom pizza. In this case, the waiter tells the chef (builder) "I need a pizza; add cheese, onions and bacon to it!" Thus, the builder exposes the attributes the generated object should have, but hides how to set them.
 
 */
namespace BuilderApp
{

    /// <summary>
    /// Source of Knowledge
    /// https://www.dofactory.com/net/builder-design-pattern
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleBuilderBase builder;

            // Create shop with vehicle builders
            Shop shop = new Shop();

            // Construct and display vehicles
            builder = new ScooterBuilder();
            shop.Construct(builder);
            var scooter = builder.GetVehicle();
            scooter.Show();


            builder = new CarBuilder();
            shop.Construct(builder);
            var car = builder.GetVehicle();
            car.Show();


            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            var motorcycle = builder.GetVehicle();
            motorcycle.Show();

            // Wait for user
            Console.ReadKey();
        }
    }
}