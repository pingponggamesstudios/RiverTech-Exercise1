using LightBDD.Framework;
using LightBDD.NUnit3;
using System.Threading.Tasks;
using LightBDD.Framework.Scenarios;

[assembly: LightBddScopeAttribute]
namespace RiverTech___Exercise_1__Web_API_TestScenarios
{
    [FeatureDescription(
@"Connect to the API, gather the details and confirm that information is correct.")]
    public partial class UserFeature : UserFeatureStep
    {
        [Scenario]
        public async Task Verify_user_information()
        {
            
           await Runner.AddSteps(
                    Given_API_Server_is_Online,
                    When_Confirming_User_Credentials_Are_Correct)
                .RunAsync();
        }
    }
}