using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication1
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup

            //Ovo je zakomentarisano zbog nase Custom Validacije
            //RouteConfig.RegisterRoutes(RouteTable.Routes); 
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        //ove dve funkcije OBAVEZNE da bi pri requestu 
        //saznali nivo autentifikacije korisnika
        //trazeci informacije iz cookija

        // !!!!!!!!!!!!!!!!!!!!!!!!!!
        public override void Init()
        {
            base.PostAuthenticateRequest += OnAfterAuthenticateRequest;
        }

        private void OnAfterAuthenticateRequest(object sender, EventArgs eventArgs)
        {
            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
                var cookie = HttpContext.Current.Request.Cookies[FormsAuthentication.FormsCookieName];

                var decodeTicket = FormsAuthentication.Decrypt(cookie.Value);

                HttpContext.Current.User = new GenericPrincipal(HttpContext.Current.User.Identity, 
                                                                    new[] { decodeTicket.UserData });

                
            }
        }
    }
}