using LightBDD.Framework;
using LightBDD.NUnit3;
using NUnit.Framework;
using RiverTech___Exercise_1__Web_API_.Controllers;
using RiverTech___Exercise_1__Web_API_.Models;
using System.Net.Http;
using System.Threading.Tasks;


namespace RiverTech___Exercise_1__Web_API_TestScenarios
{
    public partial class UserFeatureStep : FeatureFixture
    {
        private User _user;

        [SetUp]
        public void SetUp()
        {
            _user = new User();
        }

        public async void Given_API_Server_is_Online()
        {
            HttpResponseMessage responseMessage = await Task.Run(() => UsersController.ConnectWithAPIServer());
            Assert.IsTrue(responseMessage.IsSuccessStatusCode);
        }
    }
}