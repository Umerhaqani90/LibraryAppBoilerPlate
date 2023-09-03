using Abp.Authorization;
using LibraryApp.Authorization.Roles;
using LibraryApp.Authorization.Users;

namespace LibraryApp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
