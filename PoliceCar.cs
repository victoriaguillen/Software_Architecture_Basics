using System.Diagnostics.Metrics;

namespace Practice1
{
    class PoliceCar : VehicleWithPlate
    {
        //constant string as TypeOfVehicle wont change allong PoliceCar instances
        private const string typeOfVehicle = "Police Car"; 
        private bool isPatrolling;
        private SpeedRadar speedRadar;
        private bool chasing;
        private PoliceStation policeStation;
        private bool radar;

        public PoliceCar(string plate, bool radar, PoliceStation police_station) : base(typeOfVehicle, plate)
        {
            Console.WriteLine(WriteMessage("created"));
            isPatrolling = false;
            speedRadar = AddRadar(radar);
            chasing = false;
            policeStation = police_station;
        }
     

        public PoliceStation GetPoliceStation()
        {
                return this.policeStation;
        }

        public SpeedRadar AddRadar(bool radar)
        {
            if (radar)
            {
                Console.WriteLine(WriteMessage("speed radar added"));
                return new SpeedRadar();
            }
            else
            {
                Console.WriteLine(WriteMessage("has no speed radar"));
                return null;
            }
        }
    

        public void NotifyPoliceStation(string cPlate, string tPlate)
        {
          policeStation.AlertActivation(cPlate, tPlate);

        }

        public void UseRadar(VehicleWithPlate vehicle)
        {
            if (isPatrolling && speedRadar != null)
            {              
                speedRadar.TriggerRadar(vehicle);
                string meassurement = speedRadar.GetLastReading();
                Console.WriteLine(WriteMessage($"Triggered radar. Result: {meassurement}"));

                if (meassurement.Contains("Catched above legal speed."))
                {
                    Console.WriteLine(WriteMessage($"is now chassing vehicle with plate {vehicle.GetPlate()}. Alert sended to {GetPoliceStation()}"));
                    NotifyPoliceStation(GetPlate(), vehicle.GetPlate());


                    if (vehicle.hasCity)
                    {
                        vehicle.GetCity().AlertOfSpeeding(vehicle);
                    }     
                } 
            }
            else
            {
                if (speedRadar == null )
                {
                    Console.WriteLine(WriteMessage($"has no radar."));
                }
                else
                {
                    Console.WriteLine(WriteMessage($"has no active radar."));
                }
            }
        }

        public bool IsPatrolling()
        {
            return isPatrolling;
        }

        public void StartPatrolling()
        {
            if (!isPatrolling)
            {
                isPatrolling = true;
                Console.WriteLine(WriteMessage("started patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("is already patrolling."));
            }
        }

        public void EndPatrolling()
        {
            if (isPatrolling)
            {
                isPatrolling = false;
                Console.WriteLine(WriteMessage("stopped patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("was not patrolling."));
            }
        }

        public void PrintRadarHistory()
        {
            Console.WriteLine(WriteMessage("Report radar speed history:"));
            foreach (float speed in speedRadar.SpeedHistory)
            {
                Console.WriteLine(speed);
            }
        }

        public void StartChasing(string plate)
        {
            this.chasing = true;
            Console.WriteLine(WriteMessage($"is now chassing vehicle with plate {plate}"));
        }

    }
}