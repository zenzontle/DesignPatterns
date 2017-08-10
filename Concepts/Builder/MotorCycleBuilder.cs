namespace Concepts.Builder
{
    public class MotorCycleBuilder : VehicleBuilder
    {
        public MotorCycleBuilder()
        {
            VehicleInstance = new Vehicle("MotorCycle");
        }

        public override void BuildFrame()
        {
            VehicleInstance["frame"] = "MotorCycle Frame";
        }

        public override void BuildEngine()
        {
            VehicleInstance["engine"] = "500 cc";
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
