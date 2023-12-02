using DataAccessInterfaces;
using DataObjects;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
	public class FlightAccessor : IFlightAccessor
	{
		public int deleteFlight(Flight flight)
		{
			int result = 0;
			SqlConnection conn = SqlConnectionProvider.GetConnection();
			var cmd = new SqlCommand("sp_delete_flight", conn);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("@FlightId", flight.FlightId);
			try
			{
				conn.Open();
				result = cmd.ExecuteNonQuery();
			}
			catch (Exception)
			{

				throw;
			}
			finally { conn.Close(); }
			return result;
		}

		public int insert(Flight flight)
		{
			int result = 0;
			SqlConnection conn = SqlConnectionProvider.GetConnection();
			var cmd = new SqlCommand("sp_insert_flight", conn);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("@FlightNumber", flight.FlightNumber);
			cmd.Parameters.AddWithValue("@Departure", flight.Departure);
			cmd.Parameters.AddWithValue("@Destination", flight.Destination);
			cmd.Parameters.AddWithValue("@DepartureTime", flight.DepartureTime);
			cmd.Parameters.AddWithValue("@ArrivalTime", flight.ArrivalTime);
			cmd.Parameters.AddWithValue("@AvailableSeats", flight.AvailableSeats);
			cmd.Parameters.AddWithValue("@Price", flight.Price);
			cmd.Parameters.AddWithValue("@Airline", flight.Airline);
			try
			{
				conn.Open();
				result = cmd.ExecuteNonQuery();
			}
			catch (Exception)
			{

				throw;
			}
			finally { conn.Close(); }
			return result;
		}

		public List<string> selectAllAirportCode()
		{
			List<string> airPortCodes = new List<string>();
			SqlConnection conn = SqlConnectionProvider.GetConnection();
			SqlCommand cmd = new SqlCommand("sp_select_all_airport_codes", conn);
			cmd.CommandType = CommandType.StoredProcedure;
			try
			{
				conn.Open();
				var reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						airPortCodes.Add(reader.GetString(0));
					}

				}
			}
			catch (Exception)
			{

				throw;
			}
			finally { conn.Close(); }
			return airPortCodes;
		}

		public List<Flight> selectAllFlights()
		{
			List<Flight> flights = new List<Flight>();
			SqlConnection conn = SqlConnectionProvider.GetConnection();
			SqlCommand cmd = new SqlCommand("sp_select_all_flights", conn);
			cmd.CommandType = CommandType.StoredProcedure;
			try
			{
				conn.Open();
				var reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Flight flight = new Flight();
						flight.FlightId = reader.GetInt32(0);
						flight.FlightNumber = reader.GetString(1);
						flight.Departure = reader.GetString(2);
						flight.Destination = reader.GetString(3);
						flight.DepartureTime = reader.GetDateTime(4);
						flight.ArrivalTime = reader.GetDateTime(5);
						//flight.Capacity = reader.GetInt32(6);
						flight.AvailableSeats = reader.GetInt32(6);
						flight.Price = reader.GetDecimal(7);
						flight.Airline = reader.GetString(8);
						//flight.Aircraft = reader.GetString(9);
						//flight.Status = reader.GetString(9);
						//flight.Active = reader.GetBoolean(9);
						flights.Add(flight);
					}

				}
			}
			catch (Exception)
			{

				throw;
			}
			finally { conn.Close(); }
			return flights;
		}

		public List<Flight> SelectFlightsByAirline(string arrLine)
		{
			//throw new NotImplementedException();
			List<Flight> flights = new List<Flight>();
			SqlConnection conn = SqlConnectionProvider.GetConnection();
			SqlCommand cmd = new SqlCommand("sp_select_flight_by_airline", conn);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("@Airline", arrLine);
			try
			{
				conn.Open();
				var reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Flight flight = new Flight();
						flight.FlightId = reader.GetInt32(0);
						flight.FlightNumber = reader.GetString(1);
						flight.Departure = reader.GetString(2);
						flight.Destination = reader.GetString(3);
						flight.DepartureTime = reader.GetDateTime(4);
						flight.ArrivalTime = reader.GetDateTime(5);
						//flight.Capacity = reader.GetInt32(6);
						flight.AvailableSeats = reader.GetInt32(6);
						flight.Price = reader.GetDecimal(7);
						flight.Airline = reader.GetString(8);
						//flight.Aircraft = reader.GetString(9);
						//flight.Status = reader.GetString(9);
						//flight.Active = reader.GetBoolean(9);
						flights.Add(flight);
					}

				}
			}
			catch (Exception)
			{

				throw;
			}
			finally { conn.Close(); }
			return flights;
		}

		public List<Flight> SelectFlightsByAirplaneID(int airPlaneID)
		{
			//throw new NotImplementedException();
			List<Flight> flights = new List<Flight>();
			SqlConnection conn = SqlConnectionProvider.GetConnection();
			SqlCommand cmd = new SqlCommand("sp_select_flight_by_airplane_id", conn);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("@AirplaneID", airPlaneID);
			try
			{
				conn.Open();
				var reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Flight flight = new Flight();
						flight.FlightId = reader.GetInt32(0);
						flight.FlightNumber = reader.GetString(1);
						flight.Departure = reader.GetString(2);
						flight.Destination = reader.GetString(3);
						flight.DepartureTime = reader.GetDateTime(4);
						flight.ArrivalTime = reader.GetDateTime(5);
						//flight.Capacity = reader.GetInt32(6);
						flight.AvailableSeats = reader.GetInt32(6);
						flight.Price = reader.GetDecimal(7);
						flight.Airline = reader.GetString(8);
						//flight.Aircraft = reader.GetString(9);
						//flight.Status = reader.GetString(9);
						//flight.Active = reader.GetBoolean(9);
						flights.Add(flight);
					}

				}
			}
			catch (Exception)
			{

				throw;
			}
			finally { conn.Close(); }
			return flights;
		}

		public List<Flight> SelectFlightsByArrivalCity(string arrCity)
		{
			//throw new NotImplementedException();
			List<Flight> flights = new List<Flight>();
			SqlConnection conn = SqlConnectionProvider.GetConnection();
			SqlCommand cmd = new SqlCommand("sp_select_flight_by_arrival_city", conn);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("@ArrivalCity", arrCity);
			try
			{
				conn.Open();
				var reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Flight flight = new Flight();
						flight.FlightId = reader.GetInt32(0);
						flight.FlightNumber = reader.GetString(1);
						flight.Departure = reader.GetString(2);
						flight.Destination = reader.GetString(3);
						flight.DepartureTime = reader.GetDateTime(4);
						flight.ArrivalTime = reader.GetDateTime(5);
						//flight.Capacity = reader.GetInt32(6);
						flight.AvailableSeats = reader.GetInt32(6);
						flight.Price = reader.GetDecimal(7);
						flight.Airline = reader.GetString(8);
						//flight.Aircraft = reader.GetString(9);
						//flight.Status = reader.GetString(9);
						//flight.Active = reader.GetBoolean(9);
						flights.Add(flight);
					}

				}
			}
			catch (Exception)
			{

				throw;
			}
			finally { conn.Close(); }
			return flights;
		}
		public List<Flight> SelectFlightsByDepartureCity(string depCity)
		{
			//throw new NotImplementedException();
			List<Flight> flights = new List<Flight>();
			SqlConnection conn = SqlConnectionProvider.GetConnection();
			SqlCommand cmd = new SqlCommand("sp_select_flight_by_departure_city", conn);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("@DepartureCity", depCity);
			try
			{
				conn.Open();
				var reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Flight flight = new Flight();
						flight.FlightId = reader.GetInt32(0);
						flight.FlightNumber = reader.GetString(1);
						flight.Departure = reader.GetString(2);
						flight.Destination = reader.GetString(3);
						flight.DepartureTime = reader.GetDateTime(4);
						flight.ArrivalTime = reader.GetDateTime(5);
						//flight.Capacity = reader.GetInt32(6);
						flight.AvailableSeats = reader.GetInt32(6);
						flight.Price = reader.GetDecimal(7);
						flight.Airline = reader.GetString(8);
						//flight.Aircraft = reader.GetString(9);
						//flight.Status = reader.GetString(9);
						//flight.Active = reader.GetBoolean(9);
						flights.Add(flight);
					}

				}
			}
			catch (Exception)
			{

				throw;
			}
			finally { conn.Close(); }
			return flights;

		}
		public List<Flight> SelectFlightsByArrivalDate(DateTime arrDate)
		{
			//throw new NotImplementedException();
			List<Flight> flights = new List<Flight>();
			SqlConnection conn = SqlConnectionProvider.GetConnection();
			SqlCommand cmd = new SqlCommand("sp_select_flight_by_arrival_date", conn);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("@ArrivalDate", arrDate);
			try
			{
				conn.Open();
				var reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Flight flight = new Flight();
						flight.FlightId = reader.GetInt32(0);
						flight.FlightNumber = reader.GetString(1);
						flight.Departure = reader.GetString(2);
						flight.Destination = reader.GetString(3);
						flight.DepartureTime = reader.GetDateTime(4);
						flight.ArrivalTime = reader.GetDateTime(5);
						//flight.Capacity = reader.GetInt32(6);
						flight.AvailableSeats = reader.GetInt32(6);
						flight.Price = reader.GetDecimal(7);
						flight.Airline = reader.GetString(8);
						//flight.Aircraft = reader.GetString(9);
						//flight.Status = reader.GetString(9);
						//flight.Active = reader.GetBoolean(9);
						flights.Add(flight);
					}

				}
			}
			catch (Exception)
			{

				throw;
			}
			finally { conn.Close(); }
			return flights;
		}
		public List<Flight> SelectFlightsByDepartureDate(DateTime depDate)
		{
			//throw new NotImplementedException();
			List<Flight> flights = new List<Flight>();
			SqlConnection conn = SqlConnectionProvider.GetConnection();
			SqlCommand cmd = new SqlCommand("sp_select_flight_by_departure_date", conn);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("@DepartureDate", depDate);
			try
			{
				conn.Open();
				var reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Flight flight = new Flight();
						flight.FlightId = reader.GetInt32(0);
						flight.FlightNumber = reader.GetString(1);
						flight.Departure = reader.GetString(2);
						flight.Destination = reader.GetString(3);
						flight.DepartureTime = reader.GetDateTime(4);
						flight.ArrivalTime = reader.GetDateTime(5);
						//flight.Capacity = reader.GetInt32(6);
						flight.AvailableSeats = reader.GetInt32(6);
						flight.Price = reader.GetDecimal(7);
						flight.Airline = reader.GetString(8);
						//flight.Aircraft = reader.GetString(9);
						//flight.Status = reader.GetString(9);
						//flight.Active = reader.GetBoolean(9);
						flights.Add(flight);
					}

				}
			}
			catch (Exception)
			{

				throw;
			}
			finally { conn.Close(); }
			return flights;
		}
		public List<Flight> SelectFlightsByArrivalTime(DateTime arrTime)
		{
			//throw new NotImplementedException();
			List<Flight> flights = new List<Flight>();
			SqlConnection conn = SqlConnectionProvider.GetConnection();
			SqlCommand cmd = new SqlCommand("sp_select_flight_by_arrival_time", conn);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("@ArrivalTime", arrTime);
			try
			{
				conn.Open();
				var reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Flight flight = new Flight();
						flight.FlightId = reader.GetInt32(0);
						flight.FlightNumber = reader.GetString(1);
						flight.Departure = reader.GetString(2);
						flight.Destination = reader.GetString(3);
						flight.DepartureTime = reader.GetDateTime(4);
						flight.ArrivalTime = reader.GetDateTime(5);
						//flight.Capacity = reader.GetInt32(6);
						flight.AvailableSeats = reader.GetInt32(6);
						flight.Price = reader.GetDecimal(7);
						flight.Airline = reader.GetString(8);
						//flight.Aircraft = reader.GetString(9);
						//flight.Status = reader.GetString(9);
						//flight.Active = reader.GetBoolean(9);
						flights.Add(flight);
					}

				}
			}
			catch (Exception)
			{

				throw;
			}
			finally { conn.Close(); }
			return flights;
		}
		public List<Flight> SelectFlightsByDepartureTime(DateTime depTime)
		{
			//throw new NotImplementedException();
			List<Flight> flights = new List<Flight>();
			SqlConnection conn = SqlConnectionProvider.GetConnection();
			SqlCommand cmd = new SqlCommand("sp_select_flight_by_departure_time", conn);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("@DepartureTime", depTime);
			try
			{
				conn.Open();
				var reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Flight flight = new Flight();
						flight.FlightId = reader.GetInt32(0);
						flight.FlightNumber = reader.GetString(1);
						flight.Departure = reader.GetString(2);
						flight.Destination = reader.GetString(3);
						flight.DepartureTime = reader.GetDateTime(4);
						flight.ArrivalTime = reader.GetDateTime(5);
						//flight.Capacity = reader.GetInt32(6);
						flight.AvailableSeats = reader.GetInt32(6);
						flight.Price = reader.GetDecimal(7);
						flight.Airline = reader.GetString(8);
						//flight.Aircraft = reader.GetString(9);
						//flight.Status = reader.GetString(9);
						//flight.Active = reader.GetBoolean(9);
						flights.Add(flight);
					}

				}
			}
			catch (Exception)
			{

				throw;
			}
			finally { conn.Close(); }
			return flights;
		}
		public List<Flight> SelectFlightsByFlightNumber(string flightNumber)
		{
			//throw new NotImplementedException();
			List<Flight> flights = new List<Flight>();
			SqlConnection conn = SqlConnectionProvider.GetConnection();
			SqlCommand cmd = new SqlCommand("sp_select_flight_by_flight_number", conn);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("@FlightNumber", flightNumber);
			try
			{
				conn.Open();
				var reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Flight flight = new Flight();
						flight.FlightId = reader.GetInt32(0);
						flight.FlightNumber = reader.GetString(1);
						flight.Departure = reader.GetString(2);
						flight.Destination = reader.GetString(3);
						flight.DepartureTime = reader.GetDateTime(4);
						flight.ArrivalTime = reader.GetDateTime(5);
						//flight.Capacity = reader.GetInt32(6);
						flight.AvailableSeats = reader.GetInt32(6);
						flight.Price = reader.GetDecimal(7);
						flight.Airline = reader.GetString(8);
						//flight.Aircraft = reader.GetString(9);
						//flight.Status = reader.GetString(9);
						//flight.Active = reader.GetBoolean(9);
						flights.Add(flight);
					}

				}
			}
			catch (Exception)
			{

				throw;
			}
			finally { conn.Close(); }
			return flights;
		}

		public int updateFlight(Flight flight)
		{
			int result = 0;
			SqlConnection conn = SqlConnectionProvider.GetConnection();
			var cmd = new SqlCommand("sp_update_flight", conn);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("@FlightId", flight.FlightId);
			cmd.Parameters.AddWithValue("@FlightNumber", flight.FlightNumber);
			cmd.Parameters.AddWithValue("@Departure", flight.Departure);
			cmd.Parameters.AddWithValue("@Destination", flight.Destination);
			cmd.Parameters.AddWithValue("@DepartureTime", flight.DepartureTime);
			cmd.Parameters.AddWithValue("@ArrivalTime", flight.ArrivalTime);
			cmd.Parameters.AddWithValue("@AvailableSeats", flight.AvailableSeats);
			cmd.Parameters.AddWithValue("@Price", flight.Price);
			cmd.Parameters.AddWithValue("@Airline", flight.Airline);
			try
			{
				conn.Open();
				result = cmd.ExecuteNonQuery();
			}
			catch (Exception)
			{
				throw;
			}
			finally { conn.Close(); }
			return result;
		}
	}
}
