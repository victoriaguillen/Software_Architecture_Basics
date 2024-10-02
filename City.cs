using System.Reflection;

namespace Practice1
{
    class City : IMessageWritter
    {
        private List<PoliceStation> policeStations;
        private List<Taxi> licensesList;
        private string name;

        public City(string name)
        {
            policeStations = new List<PoliceStation>();
            licensesList = new List<Taxi>();
            this.name = name;
        }

        public override string ToString()
        {
            return $"City {GetCityName()}";
        }

        public List<PoliceStation> GetPoliceStations()
        {
            return policeStations;
        }

        public string GetCityName()
        {
            return name;
        }

        public void AddPoliceStation(PoliceStation policeStation)
        {
            this.policeStations.Add(policeStation);
        }

        public void AddLicense(Taxi taxi)
        {
            this.licensesList.Add(taxi);
            Console.WriteLine(taxi.WriteMessage($"has a license in {this.GetCityName()}"));

        }

        public string WriteMessage(string message)
        {
            return $"{this}: {message}";
        }

        public void AlertOfSpeeding(VehicleWithPlate vehicle)
        {

            if (vehicle.GetTypeOfVehicle() == "Taxi")
            {
                string plate = vehicle.GetPlate();
                bool found = false;

                for (int i = 0; i < this.licensesList.Count; i++)
                {
                    if (this.licensesList[i].GetPlate() == plate)
                    {
                        this.licensesList.RemoveAt(i);
                        Console.WriteLine(WriteMessage($"removed license to taxi with plate :{vehicle.GetPlate()}"));
                        found = true;
                    }
                }

                if (!found)
                {
                    Console.WriteLine(WriteMessage($"taxi with plate {vehicle.GetPlate()} has no license in this city."));
                }

            }
        }
    }
}


    
