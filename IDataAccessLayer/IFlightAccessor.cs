using DataObjects;

namespace DataAccessInterfaces
{
	public interface IFlightAccessor
	{
		public List<Flight> SelectFlightsByDepartureDate(DateTime depDate);
		public List<Flight> SelectFlightsByArrivalDate(DateTime arrDate);
		public List<Flight> SelectFlightsByDepartureCity(string depCity);
		public List<Flight> SelectFlightsByArrivalCity(string arrCity);
		public List<Flight> SelectFlightsByDepartureTime(DateTime depTime);
		public List<Flight> SelectFlightsByArrivalTime(DateTime arrTime);
		public List<Flight> SelectFlightsByAirline(string arrLine);
		public List<Flight> SelectFlightsByFlightNumber(string flightNum);
		public List<Flight> SelectFlightsByAirplaneID(int airPlaneID);
		public List<Flight> selectAllFlights();
		public int insert(Flight flight);
		public List<string> selectAllAirportCode();
		public int updateFlight(Flight flight);
		public int deleteFlight(Flight flight);
	}
}