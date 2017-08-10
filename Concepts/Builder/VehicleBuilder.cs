namespace Concepts.Builder
{
    public abstract class VehicleBuilder
    {
        public Vehicle VehicleInstance { get; protected set; }

        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
}
