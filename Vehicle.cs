namespace Practice1
{
    abstract class Vehicle : IMessageWritter
    {
        private string typeOfVehicle;
        private string plate;
        private float speed;
        public City actualCity;
        public bool hasCity;

        public Vehicle(string typeOfVehicle, string plate)
        {
            this.typeOfVehicle = typeOfVehicle;
            this.plate = plate;
            speed = 0f;
            actualCity = null;
        }

        //Override ToString() method with class information
        public override string ToString()
        {
            return $"{GetTypeOfVehicle()} with plate {GetPlate()}";
        }

        public City GetCity()
        {
            return actualCity;
        }

        public void SetCity(City city)
        {
            hasCity = true;
            this.actualCity = city;
        }

        public string GetTypeOfVehicle()
        {
            return typeOfVehicle;
        }

        public string GetPlate()
        {
            return plate;
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
