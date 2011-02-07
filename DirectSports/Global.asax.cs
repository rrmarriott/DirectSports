using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Security.Principal;
using DirectSports.BL;
using log4net;

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "logger.config", Watch = true)]

namespace DirectSports
{
    public class Global : System.Web.HttpApplication
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(Global));

        protected void Application_Start(object sender, EventArgs e)
        {
            log.Info("Application startup.");
        }

        protected void Application_End(object sender, EventArgs e)
        {
            log.Warn("Application shutdown.");
        }

        protected void Application_AuthenticateRequest(Object sender, EventArgs e)
        {
            if (Context.Request.IsAuthenticated)
            {
                // Retrieve user's identity from context user
                FormsIdentity ident = (FormsIdentity)Context.User.Identity;

                // Retrieve roles from the authentication ticket userdata field
                string[] roles = ident.Ticket.UserData.Split('|');

                // If we didn't load the roles before, go to the DB
                if (roles[0].Length == 0)
                {
                    // Fetch roles from the database somehow.
                    roles = SecurityManager.FindRolesForUser(Context.User.Identity.Name);

                    // Store roles inside the Forms ticket.
                    FormsAuthenticationTicket newticket = new FormsAuthenticationTicket(ident.Ticket.Version, ident.Ticket.Name, ident.Ticket.IssueDate, ident.Ticket.Expiration, ident.Ticket.IsPersistent, String.Join("|", roles), ident.Ticket.CookiePath);

                    // Create the cookie.    
                    HttpCookie authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(newticket));
                    authCookie.Path = FormsAuthentication.FormsCookiePath + "; HttpOnly; noScriptAccess";
                    authCookie.Secure = FormsAuthentication.RequireSSL;

                    if (newticket.IsPersistent)
                    {
                        authCookie.Expires = newticket.Expiration;
                    }

                    Context.Response.Cookies.Add(authCookie);
                }


                // Create principal and attach to user
                Context.User = new GenericPrincipal(ident, roles);
            }
        }
    }
}