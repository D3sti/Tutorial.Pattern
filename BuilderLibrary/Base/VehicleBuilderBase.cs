namespace BuilderLibrary.Base
{

    /// <summary>
    /// The 'Builder' abstract class  
    /// 
    /// Specifies an abstract interface for creating parts of a Product object.
    /// </summary>
    public abstract class VehicleBuilderBase
    {
        protected Vehicle vehicle;
        // Gets vehicle instance


        public Vehicle Vehicle
        {
            get { return vehicle; }
        }


        // Abstract build methods
        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
        public abstract Vehicle GetVehicle();



    }
}