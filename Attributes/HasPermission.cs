using AuthLibrary.Constants.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace AuthLibrary.Attributes
{
    public class HasPermission : AuthorizeAttribute
    {
        public HasPermission(string service, string feature, string action)
        {
            Policy = AppPermission.NameFor(service, feature, action);
        }
    }
}
