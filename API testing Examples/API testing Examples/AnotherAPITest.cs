using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_testing_Examples
{
    class AnotherAPITest
    {

        [Test]
        public void SearchBooks()
        {
            var baseUrl = "https://fakerestapi.azurewebsites.net/api/v1/Books";
            RestClient client = new RestClient(baseUrl);
            RestRequest restRequest = new RestRequest(baseUrl, Method.Get);
            RestResponse restResponse = client.Execute(restRequest);
            restResponse.Should().NotBeNull();
            restResponse.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

    }
}
