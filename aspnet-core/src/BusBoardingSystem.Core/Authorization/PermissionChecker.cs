using Abp.Authorization;
using BusBoardingSystem.Authorization.Roles;
using BusBoardingSystem.Authorization.Users;

namespace BusBoardingSystem.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
