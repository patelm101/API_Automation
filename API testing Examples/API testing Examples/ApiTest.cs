using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_testing_Examples
{
    [TestClass]
    public class ApiTest
    {
        [TestMethod]
        public async Task TestApiCall()
        {
            // Arrange
            string apiUrl = "https://api.example.com/data";

            // Act
            string result = await YourClassName.GetApiResponse(apiUrl);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Contains("expected response content")); // Adjust based on your actual expected response
        }
    }
}
