using Abp.Authorization;
using abpVue.Authorization.Roles;
using abpVue.Authorization.Users;

namespace abpVue.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
