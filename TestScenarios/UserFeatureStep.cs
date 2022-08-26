using LightBDD.Framework;
using LightBDD.NUnit3;
using Newtonsoft.Json;
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

        public async void When_Confirming_User_Credentials_Are_Correct()
        {
            //this is the response gathered from the first test
            var response = UsersController.Response;
            var content = await response.Content.ReadAsStringAsync();
            //Parse response as class
            _user = JsonConvert.DeserializeObject<User>(content);

            #region Validate User Credential & Email
            Assert.AreEqual(_user.Name, "Leanne Graham");
            Assert.AreEqual(_user.Username, "Bret");
            Assert.AreEqual(_user.Email, "Sincere@april.biz");
            #endregion

            #region Validate Address
            var address = _user.Address;
            Assert.IsNotNull(_user.Address);
            Assert.AreEqual(address.Street, "Kulas Light");
            Assert.AreEqual(address.City, "Gwenborough");
            Assert.AreEqual(address.Zipcode, "92998-3874");
            Assert.IsNotNull(address.geo);
            Assert.AreEqual(address.geo.lat, "-37.3159");
            Assert.AreEqual(address.geo.lng, "81.1496");
            #endregion

            #region Validate User details
            Assert.AreEqual(_user.Phone, "1-770-736-8031 x56442");
            Assert.AreEqual(_user.Website, "hildegard.org");
            #endregion

            #region Validate Company Details
            var company = _user.company;
            Assert.IsNotNull(company);
            Assert.AreEqual(company.Name, "Romaguera-Crona");
            Assert.AreEqual(company.CatchPhrase, "Multi-layered client-server neural-net");
            Assert.AreEqual(company.Bs, "harness real-time e-markets");
            #endregion





        }
    }
}