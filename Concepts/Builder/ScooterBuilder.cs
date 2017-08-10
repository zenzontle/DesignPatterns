namespace Concepts.Builder
{
    public class ScooterBuilder : VehicleBuilder
    {
        public ScooterBuilder()
        {
            VehicleInstance = new Vehicle("Scooter");
        }

        public override void BuildFrame()
        {
            VehicleInstance["frame"] = "Scooter Frame";
        }

        public override void BuildEngine()
        {
            VehicleInstance["engine"] = "50 cc";
        }

        public override void BuildWheels()
        {
            VehicleInstance["wheels"] = "2";
        }

        public override void BuildDoors()
        {
            VehicleInstance["doors"] = "0";
        }
    }
}
