namespace Practice1
{
    class Scooter : VehicleWithoutPlate
    {
        private static string typeOfVehicle = "Scooter";

        public Scooter() : base(typeOfVehicle) 
        {
            Console.WriteLine(WriteMessage("created"));
        }

        public void Cha()
        {
            SetSpeed(100.0f);
        }

    }
}
