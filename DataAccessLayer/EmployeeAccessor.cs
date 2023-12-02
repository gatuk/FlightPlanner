using DataAccessInterfaces;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
	public class EmployeeAccessor : IEmployeeAccessor
	{
		public int verifyUser(string username, string password)
		{
			int id = 0;
			// 1-connect to database
			SqlConnection conn = SqlConnectionProvider.GetConnection();

			// 2- verify the store procedure
			var cmd = new SqlCommand("sp_verify_user", conn);
			cmd.CommandType = CommandType.StoredProcedure;


			// 3- verify the parameters of the store procedure
			cmd.Parameters.AddWithValue("@username", username);
			cmd.Parameters.AddWithValue("@password", password);
			// 4- connect and execute
			try
			{
				conn.Open();
				var reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						id = reader.GetInt32(0);
					}
				}
				else
				{
					throw new ApplicationException("User not found");
				}
			}
			catch (Exception)
			{
				throw;
			}
			finally { conn.Close(); }

			return id;
		}
	}
}
