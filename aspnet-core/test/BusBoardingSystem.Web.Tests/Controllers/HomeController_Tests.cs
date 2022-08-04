using System.Threading.Tasks;
using BusBoardingSystem.Models.TokenAuth;
using BusBoardingSystem.Web.Controllers;
using Shouldly;
using Xunit;

namespace BusBoardingSystem.Web.Tests.Controllers
{
    public class HomeController_Tests: BusBoardingSystemWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}