using DataAccessInterfaces;
using DataObjects;
using static DataObjects.Flight;

namespace DataAccessFakes
{
	public class FlightAccessorFake : IFlightAccessor
	{
		//gishe added this from jim's code
		// create a few fake flight for testing
		private List<FlightVM> fakeFlights = new List<FlightVM>();

		public FlightAccessorFake()
		{
			fakeFlights.Add(new FlightVM
			{
				FlightId = 1,
				FlightNumber = "AA123",
				Departure = "DFW",
				Destination = "LAX",
				DepartureTime = DateTime.Now,
				ArrivalTime = DateTime.Now,
				AvailableSeats = 100,
				Price = 1002,
				Airline = "American Airlines",
				DepartureDate = DateTime.Now,
				ArrivalDate = DateTime.Now,
				DepartureCity = "Dallas",
				ArrivalCity = "Los Angeles",
				AriplaneID = 1,
				AirplaneType = "Boeing 737",
				Flights = new List<string>()
			});
			fakeFlights.Add(new FlightVM
			{
				FlightId = 2,
				FlightNumber = "AA124",
				Departure = "DFW",
				Destination = "LAX",
				DepartureTime = DateTime.Now,
				ArrivalTime = DateTime.Now,
				AvailableSeats = 100,
				Price = 100,
				Airline = "American Airlines",
				DepartureDate = DateTime.Now,
				ArrivalDate = DateTime.Now,
				DepartureCity = "Dallas",
				ArrivalCity = "Los Angeles",
				AriplaneID = 1,
				AirplaneType = "Boeing 747",
				Flights = new List<string>()
			});
		}

		public int deleteFlight(Flight flight)
		{
			//throw new NotImplementedException();
			int result = 0;
			foreach (var item in fakeFlights)
			{
				if (item.FlightId == flight.FlightId)
				{
					fakeFlights.Remove(item);
					result = 1;
					break;
				}
			}
			return result;
		}

		public int insert(Flight flight)
		{
			//throw new NotImplementedException();
			int result = 0;
			fakeFlights.Add((FlightVM)flight);
			result = 1;
			return result;
		}

		public List<string> selectAllAirportCode()
		{
			//throw new NotImplementedException();
			List<string> codes = new List<string>();
			codes.Add("DFW");
			codes.Add("LAX");
			codes.Add("ORD");
			codes.Add("JFK");
			codes.Add("SFO");
			codes.Add("MIA");
			codes.Add("LAS");
			codes.Add("SEA");
			codes.Add("CLT");
			return codes;
		}

		public List<Flight> selectAllFlights()
		{
			//throw new NotImplementedException();
			List<Flight> flights = new List<Flight>();
			foreach (var item in fakeFlights)
			{
				flights.Add(item);
			}
			return flights;
		}

		public List<Flight> SelectFlightsByAirline(string arrLine)
		{
			//throw new NotImplementedException();
			List<Flight> flights = new List<Flight>();
			foreach (var item in fakeFlights)
			{
				if (item.Airline == arrLine)
				{
					flights.Add(item);
				}
			}
			return flights;
		}

		public List<Flight> SelectFlightsByAirplaneID(int airPlaneID)
		{
			//throw new NotImplementedException();
			List<Flight> flights = new List<Flight>();
			foreach (var item in fakeFlights)
			{
				if (item.AriplaneID == airPlaneID)
				{
					flights.Add(item);
				}
			}
			return flights;
		}

		public List<Flight> SelectFlightsByArrivalCity(string arrCity)
		{
			//throw new NotImplementedException();
			List<Flight> flights = new List<Flight>();
			foreach (var item in fakeFlights)
			{
				if (item.ArrivalCity == arrCity)
				{
					flights.Add(item);
				}
			}
			return flights;
		}

		public List<Flight> SelectFlightsByArrivalDate(DateTime arrDate)
		{
			//throw new NotImplementedException();
			List<Flight> flights = new List<Flight>();
			foreach (var item in fakeFlights)
			{
				if (item.ArrivalDate == arrDate)
				{
					flights.Add(item);
				}
			}
			return flights;
		}

		public List<Flight> SelectFlightsByArrivalTime(DateTime arrTime)
		{
			//throw new NotImplementedException();
			List<Flight> flights = new List<Flight>();
			foreach (var item in fakeFlights)
			{
				if (item.ArrivalTime == arrTime)
				{
					flights.Add(item);
				}
			}
			return flights;
		}

		public List<Flight> SelectFlightsByDepartureCity(string depCity)
		{
			//throw new NotImplementedException();
			List<Flight> flights = new List<Flight>();
			foreach (var item in fakeFlights)
			{
				if (item.DepartureCity == depCity)
				{
					flights.Add(item);
				}
			}
			return flights;
		}

		public List<Flight> SelectFlightsByDepartureDate(DateTime depDate)
		{
			//throw new NotImplementedException();
			List<Flight> flights = new List<Flight>();
			foreach (var item in fakeFlights)
			{
				if (item.DepartureDate == depDate)
				{
					flights.Add(item);
				}
			}
			return flights;
		}

		public List<Flight> SelectFlightsByDepartureTime(DateTime depTime)
		{
			//throw new NotImplementedException();
			List<Flight> flights = new List<Flight>();
			foreach (var item in fakeFlights)
			{
				if (item.DepartureTime == depTime)
				{
					flights.Add(item);
				}
			}
			return flights;
		}

		public List<Flight> SelectFlightsByFlightNumber(int flightNum)
		{
			//throw new NotImplementedException();
			List<Flight> flights = new List<Flight>();
			foreach (var item in fakeFlights)
			{
				if (int.Parse(item.FlightNumber) == flightNum)
				{
					flights.Add(item);
				}
			}
			return flights;
		}

		public int updateFlight(Flight flight)
		{
			//throw new NotImplementedException();
			int result = 0;
			foreach (var item in fakeFlights)
			{
				if (item.FlightId == flight.FlightId)
				{
					fakeFlights.Remove(item);
					fakeFlights.Add((FlightVM)flight);
					result = 1;
					break;
				}
			}
			return result;
		}
	}
}
