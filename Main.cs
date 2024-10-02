namespace Practice1
{
    internal class Program
    {

        static void Main()
        {
            //PoliceStation policeStacion0 = new PoliceStation("PoliceStation0");
            //Taxi taxi1 = new Taxi("0001 AAA");
            //Taxi taxi2 = new Taxi("0002 BBB");

            //PoliceCar policeCar1 = new PoliceCar("0001 CNP", true, policeStacion0);
            //PoliceCar policeCar2 = new PoliceCar("0002 CNP", true, policeStacion0);

            //policeCar1.StartPatrolling();
            //policeCar1.UseRadar(taxi1);

            //taxi2.StartRide();
            //policeCar2.UseRadar(taxi2);
            //policeCar2.StartPatrolling();
            //policeCar2.UseRadar(taxi2);
            //taxi2.StopRide();
            //policeCar2.EndPatrolling();

            //taxi1.StartRide();
            //taxi1.StartRide();
            //policeCar1.StartPatrolling();
            //policeCar1.UseRadar(taxi1);
            //taxi1.StopRide();
            //taxi1.StopRide();
            //policeCar1.EndPatrolling();

            //policeCar1.PrintRadarHistory();
            //policeCar2.PrintRadarHistory();

            //--------------------------------------------------------
            City city = new City("New York");
            Console.WriteLine(city.WriteMessage("created."));

            PoliceStation policeStation = new PoliceStation("PoliceStation1");
            Console.WriteLine(policeStation.WriteMessage("created."));

            Taxi taxi3 = new Taxi("0003 CCC");
            Taxi taxi4 = new Taxi("0004 DDD");

            taxi3.SetCity(city);
            taxi4.SetCity(city);

            city.AddLicense(taxi3);
            city.AddLicense(taxi4);

            PoliceCar policeCar3 = new PoliceCar("0003 CNP", false, policeStation);
            PoliceCar policeCar4 = new PoliceCar("0004 CNP", true, policeStation);

            policeStation.AddPoliceCar(policeCar3);
            policeStation.AddPoliceCar(policeCar4);

            policeCar3.UseRadar(taxi3);

            policeCar4.StartPatrolling();
            policeCar3.StartPatrolling();
            taxi3.StartRide();
            policeCar4.UseRadar(taxi3);



        }
    }
}
    

