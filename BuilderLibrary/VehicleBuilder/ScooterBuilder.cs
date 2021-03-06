using BuilderLibrary.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderLibrary.VehicleBuilder
{
    /// <summary>
    /// ConcreteBuilder  
    /// 
    /// Constructs and assembles parts of the product by implementing the Builder interface
    /// Defines and keeps track of the representation it creates
    /// Provides an interface for retrieving the product
    /// </summary>
    public class ScooterBuilder : VehicleBuilderBase
    {
        public ScooterBuilder()
        {
            vehicle = new Vehicle("Scooter");
        }
        public override void BuildFrame()
        {
            vehicle["frame"] = "Scooter Frame";
        }
        public override void BuildEngine()
        {
            vehicle["engine"] = "50 cc";
        }
        public override void BuildWheels()
        {
            vehicle["wheels"] = "2";
        }
        public override void BuildDoors()
        {
            vehicle["doors"] = "0";
        }
        public override Vehicle GetVehicle()
        {
            return vehicle;
        }
    }
}
