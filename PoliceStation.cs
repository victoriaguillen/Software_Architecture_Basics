using System.Xml.Linq;

namespace Practice1
{
    class PoliceStation: IMessageWritter
    {
        private List<PoliceCar> policeCars;
        private bool alert;
        private string name;

        public PoliceStation(string name)
        {
            policeCars = new List<PoliceCar>();
            this.alert = false;
            this.name = name;
        }

        public override string ToString()
        {
            return $"Police station {GetPoliceStationName()}";
        }

        public string GetPoliceStationName()
        { 
            return name; 
        }

        //method for adding police cars to the police station
        public void AddPoliceCar(PoliceCar policeCar)
        {
            policeCars.Add(policeCar);
            Console.WriteLine(policeCar.WriteMessage($"added to Police Station {this.GetPoliceStationName()}"));
        }

        //method for notifying if there is a speed infraction
        public void AlertActivation(string cPlate, string tPlate)
        {
            this.alert = true;
            Console.WriteLine(WriteMessage(("alert recived")));

            for (int i = 0; i < this.policeCars.Count; i++)
            {
                PoliceCar car;
                car = this.policeCars[i];

                //we dont want to notify the car that 
                if (car.IsPatrolling() && car.GetPlate() != cPlate)
                {
                    car.StartChasing(tPlate);
                }
            }
        }

        //Property for obtaining the list of police cars
        public List<PoliceCar> GetPoliceCars()
        {
            return this.policeCars;  
        }

        public string WriteMessage(string message)
        {
            return $"{this}: {message}";
        }


    }
}