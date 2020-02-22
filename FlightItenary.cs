using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace airtech_test
{
    class FlightItenary
    {
        /*  
            Generate flight itenary
            parameters: List of orders
            parameters: number of days scheduled for flights
            parameters: number of total planes
        */
        public List<string> GenerateItenary(JObject orderList, int days, int totalPlanes)
        {
            var schedule = new ScheduledFlights();
            var scheduledPlanes = schedule.GetSchedule(days, totalPlanes);
            var flightItnery = new List<string>();
            var itenary = "";
            foreach (var order in orderList)
            {
                var index = 1;
                foreach (var plane in scheduledPlanes)
                {
                    if (plane.Destination == order.Value["destination"].ToString())
                    {
                        if (plane.Load < 20)
                        {
                            itenary = "order: " + order.Key.ToString() + ", flightNumber: " + plane.FlightNumber + ", departure: " + plane.DepartureCity + ", arrival: " + plane.Destination + ", day: " + plane.Day;
                            flightItnery.Add(itenary);
                            plane.Load++;
                            break;
                        }
                        else if (plane.Day == "2")
                        {
                            break;
                        }
                    }
                    else if (index == scheduledPlanes.Count)
                    {
                        itenary = "order: " + order.Key.ToString() + ", flightNumber: not scheduled";
                        flightItnery.Add(itenary);
                        break;
                    }
                    index++;
                }

            }
            return flightItnery;

        }
    }
}