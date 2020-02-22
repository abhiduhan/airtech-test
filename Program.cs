using System;

namespace airtech_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var flightItenary = new FlightItenary();
            var jsonReader = new ReadJsonFile();
            restart: Console.WriteLine("Please choose from following options:\n 1. View scheduled flights \n 2. Generate flight itenary based on coding-assigment-orders.json file.");
            var userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    var scheduledFlights = new ScheduledFlights();
                    var schedule = scheduledFlights.GetSchedule(2, 3);
                    foreach (var plane in schedule)
                    {
                        Console.WriteLine("Flight: {0}, departure: {1}, arrival: {2}, day: {3}", plane.FlightNumber, plane.DepartureCity, plane.Destination, plane.Day);
                    }
                    break;
                case "2":
                    var orderList = jsonReader.ReadJson("coding-assigment-orders.json");
                    var itenary = flightItenary.GenerateItenary(orderList, 2, 3);
                    foreach (var flight in itenary)
                    {
                        Console.WriteLine(flight);
                    }
                    break;
            }

            Console.WriteLine("Do you want to continue? y or n:");
            userInput = Console.ReadLine();
            if(userInput == "y" || userInput == "yes"){
                goto restart;
            }
        }
    }
}
