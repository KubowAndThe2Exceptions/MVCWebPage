using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;

namespace MVCDemo.Extensions
{
    public static class IPrincipalExtension
    {
        public static String GetFirstName(this IPrincipal principal)
        {
            var claimsPrincipal = principal as ClaimsPrincipal;

            var personFirstNameClaim = claimsPrincipal.Claims.FirstOrDefault(c => c.Type == "FirstName");
            if (personFirstNameClaim != null)
            {
                return personFirstNameClaim.Value;
            }

            return String.Empty;
        }
    }
}