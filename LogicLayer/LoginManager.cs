using DataAccessInterfaces;
using DataAccessLayer;
using LogicLayerInterfaces;

namespace LogicLayer
{
	public class LoginManager : ILoginManager
	{
		private ILoginAccessor loginAccessor = new LoginAccessor();

		public string verifyUser(string username, string password)
		{
			string role = "";
			role = loginAccessor.verifyUser(username, password);
			return role;
		}
	}
}
