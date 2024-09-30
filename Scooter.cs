namespace Practice1
{
    class Scooter : Vehicle
    {
        private static string typeOfVehicle = "Scooter";

        public Scooter() : base(typeOfVehicle, null, false) 
        {
            Console.WriteLine(WriteMessage("created"));
        }

        public void Cha()
        {
            SetSpeed(100.0f);
        }

    }
}
