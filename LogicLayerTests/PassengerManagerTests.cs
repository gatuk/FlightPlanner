using DataAccessFakes;
using DataObjects;
using LogicLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogicLayerTests
{
	[TestClass]
	public class PassengerManagerTests
	{
		IPassengerManager _passengerManager = null;

		[TestInitialize]
		public void TestSetUp()
		{
			_passengerManager = new PassengerManager(new passengerAccessorFake());
		}

		[TestMethod]
		public void TestHashSha256ReturnsACorrectHashValue()
		{
			// in TDD (test-driven development, the test comes first)
			// we use the red-green-refactor workflow
			// we write the test method with the A-A-A framework

			// Arrange - set up the test condition
			string testString = "newuser";
			string actualHash = "";
			string expectedHash = "9c9064c59f1ffa2e174ee754d2979be80dd30db552ec03e7e327e9b1a4bd594e";

			// Act - invoke the method being tested, and capture results
			actualHash = _passengerManager.HashSha256(testString);

			// Assert
			Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expectedHash, actualHash);
		}

		[TestMethod]
		public void TestAuthenticateEmployeePassesWithCorrectEmailAndPassword()
		{
			// arrange
			string email = "tess@company.com";
			string password = "newuser";
			bool expectedResult = true;
			bool actualResult = false;

			// act
			actualResult = _passengerManager.AuthenticatePassenger(email, password);

			// assert
			Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expectedResult, actualResult);
		}

		[TestMethod]
		public void TestAuthenticateEmployeeFailsWithBadEmailAndPassword()
		{
			// arrange
			string email = "tess@company.com";
			string password = "newloser";           // bad password
			bool expectedResult = false;
			bool actualResult = true;

			// act
			actualResult = _passengerManager.AuthenticatePassenger(email, password);

			// assert
			Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expectedResult, actualResult);
		}

		[TestMethod]
		public void TestGetEmployeeByEmailReturnsCorrectPassenger()
		{
			// arrange
			string email = "tess@company.com";
			int expectedEmployeeID = 1;
			int actualEmployeeID = 0;

			// act
			PassengerVM passengerVM = _passengerManager.GetPassengerVMByEmail(email);
			actualEmployeeID = passengerVM.PassengerID;

			// assert
			Assert.AreEqual(expectedEmployeeID, actualEmployeeID);
		}

		[TestMethod]
		[ExpectedException(typeof(ApplicationException))]
		public void TestGetPassengerByEmailFailsWithBadEmail()
		{
			// arrange 
			string email = "ness@company.com"; // bad email
																				 // int expectedEmployeeID = 1;
			int actualEmployeeID = 0;

			// act
			PassengerVM employeeVM = _passengerManager.GetPassengerVMByEmail(email);
			actualEmployeeID = employeeVM.PassengerID;

			// assert - nothing to do
		}

		[TestMethod]
		public void TestGetRolesByEmployeeIDReturnsCorrectRoles()
		{
			// arrange
			int testID = 1;
			int expectedRoleCount = 2;
			int actualRoleCount = 0;

			// act
			actualRoleCount = _passengerManager.GetRolesByPassengerID(testID).Count;

			// assert
			Assert.AreEqual(expectedRoleCount, actualRoleCount);
		}

		[TestMethod]
		public void TestResetPasswordWorksCorrectly()
		{
			// arrange
			string email = "tess@company.com";
			string password = "newuser";
			string newPassword = "password";
			bool expectedResult = true;
			bool actualResult = false;

			// act
			actualResult = _passengerManager.ResetPassword(email, password, newPassword);

			// assert
			Assert.AreEqual(expectedResult, actualResult);
		}
	}
}
