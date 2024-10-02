namespace Practice1
{
    abstract class Vehicle : IMessageWritter
    {
        private string typeOfVehicle;
        private float speed;
        public City actualCity;
        public bool hasCity;

        public Vehicle(string typeOfVehicle)
        {
            this.typeOfVehicle = typeOfVehicle;
            speed = 0f;
            actualCity = null;
        }


        public City GetCity()
        {
            return actualCity;
        }

        public void SetCity(City city)
        {
            hasCity = true;
            this.actualCity = city;
            Console.WriteLine(WriteMessage($"belongs to the city: {city}"));
        }

        public string GetTypeOfVehicle()
        {
            return typeOfVehicle;
        }


        public float GetSpeed()
        {
            return speed;
        }

        public void SetSpeed(float speed)
        {
            this.speed = speed;
        }

        //Implment interface with Vechicle message structure
        public string WriteMessage(string message)
        {
            return $"{this}: {message}";
        }
    }
}
