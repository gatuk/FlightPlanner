using DataObjects;

namespace LogicLayer
{
	public interface IPassengerManager
	{

		PassengerVM loginPassenger(string email, string password);
		//Helper methods, but public for reuse 
		string HashSha256(string source);
		bool AuthenticatePassenger(string email, string password);
		PassengerVM GetPassengerVMByEmail(string email);
		List<string> GetRolesByPassengerID(int PassengerID);
		List<Passenger> getAllPassengers();

		//object GetRolesByPassengerID(int testID);

		bool ResetPassword(string email, string password, string newPassword);
		public int updatePassenger(Passenger passenger);
		public int addPassenger(Passenger passenger);
	}
}
