using DataAccessInterfaces;
using DataAccessLayer;
using DataObjects;

namespace LogicLayer
{
	public class PassengerManager : IPassengerManager
	{
		// dependency inversion for the data provider
		private IPassengerAccessor _passengerAccessor = null;
		// the default constructor will use the database
		public PassengerManager()
		{
			_passengerAccessor = new PassengerAccessor();
		}

		public PassengerManager(IPassengerAccessor passengerAccessor)
		{
			_passengerAccessor = passengerAccessor;
		}

		public int addPassenger(Passenger passenger)
		{
			int result = 0;
			result = _passengerAccessor.insertPassenger(passenger);
			return result;
		}

		public bool AuthenticatePassenger(string email, string password)
		{
			throw new NotImplementedException();
		}

		public List<Passenger> getAllPassengers()
		{
			List<Passenger> passengers = new List<Passenger>();
			passengers = _passengerAccessor.selectAllPassengers();
			return passengers;
		}

		public PassengerVM GetPassengerVMByEmail(string email)
		{
			throw new NotImplementedException();
		}

		public List<string> GetRolesByPassengerID(int PassengerID)
		{
			throw new NotImplementedException();
		}

		public string HashSha256(string source)
		{
			throw new NotImplementedException();
		}

		public PassengerVM loginPassenger(string email, string password)
		{
			throw new NotImplementedException();
		}

		public bool ResetPassword(string email, string password, string newPassword)
		{
			throw new NotImplementedException();
		}

		public int updatePassenger(Passenger passenger)
		{
			int result = 0;
			result = _passengerAccessor.updatePassenger(passenger);
			return result;
		}
	}
}
