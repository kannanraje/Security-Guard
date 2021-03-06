﻿using System.Web.Mvc;

namespace SecurityGuard.Areas.SGMembership
{
    public class SGMembershipAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "SGMembership";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {

            //context.MapRoute("GrantRolesToUser", "SGMembership/Membership/GrantRolesToUser/{username}",
            //    new { controller = "Membership", action = "GrantRolesToUser", userName = "" }
            //    );

            //context.MapRoute("UserDetails", "SGMembership/Membership/Update/{userName}",
            //    new { controller = "Membership", action = "Update", userName = "" }
            //    );

            context.MapRoute("SearchMembership", "SGMembership/Membership/index/{searchterm}/{filterby}",
                new { controller = "Membership", action = "Index", searchterm = UrlParameter.Optional, filterby = UrlParameter.Optional }
                );

            context.MapRoute("Membership", "SGMembership/Membership/{action}/{userName}",
                new { controller = "Membership", userName = UrlParameter.Optional }
                );  

            context.MapRoute(
                "SGMembership_default",
                "SGMembership/{controller}/{action}/{id}",
                new { controller = "Dashboard", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
