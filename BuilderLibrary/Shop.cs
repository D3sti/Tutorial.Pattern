using BuilderLibrary.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderLibrary
{

    /// <summary>
    /// The 'Director' class
    /// 
    /// Constructs an object using the Builder interface (Director of a Builder)
    /// </summary>
    public class Shop
    {
        /// <summary>
        /// Builder uses a complex series of steps
        /// </summary>
        /// <param name="vehicleBuilder"></param>
        public void Construct(VehicleBuilderBase vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
        }
    }
}
