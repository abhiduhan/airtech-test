using System.Collections.Generic;

namespace airtech_test
{

    class ScheduledFlights {

        //return currently scheduled flights based on number of days and total planes
        public Queue<FlightData> GetSchedule(int days, int totalPlanes){
            var flightSchedule = new Queue<FlightData>();
            var listOfPlanes = new List<FlightData> ();
            var flightNumber = 1;
            for (int i = 0; i < days; i++) {
                var planeNumber = 1;
                var currentDay = i + 1;
                
                for (int x = 0; x < totalPlanes; x++) {
                    listOfPlanes.Add (new FlightData ());
                }
                
                foreach (var plane in listOfPlanes) {
                    plane.Day = currentDay.ToString ();
                    plane.DepartureCity = "YUL";
                    plane.FlightNumber = flightNumber.ToString();
                    switch (planeNumber) {
                        case 1:
                            plane.Destination = "YYZ";
                            break;
                        case 2:
                            plane.Destination = "YYC";
                            break;
                        case 3:
                            plane.Destination = "YVR";
                            break;
                    }
                    flightSchedule.Enqueue (plane);
                    planeNumber++;
                    flightNumber++;
                }
                listOfPlanes.Clear ();
            }
            return flightSchedule;
        }
        
    }
}