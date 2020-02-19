using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using Model;
using BussinesServices.cs;
using System.Web.Security;
using Newtonsoft.Json;

namespace WebApplication1
{
    public partial class LogIN : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            lbWarning.Visible = false;

            // Ucitavanje podataka u tabelu [tblUSERS]
            // Enabled jer se ucitava samo jednom u bazu
            // Menja skriptu
            btFill_tblUsers.Enabled = false;
            btFill_tblUsers.Visible = false;
        }

        private string GetTruePasswd(string passwd)
        {
            return FormsAuthentication.
                        HashPasswordForStoringInConfigFile(passwd.ToLower(), "SHA1");
        }

        private bool authentification(string username, string passwd, out Users authUser, out string info)
        {
            UserServices service = new UserServices();
            Users user = service.GetUserByName(username);
            string truePasswd = GetTruePasswd(passwd);

            authUser = null;

            if (!(user.UserName == username))
            {
                info = "Username is not matched!";
                return false;
            }

            if (user.IsLocked == 1)
            {
                info = "Acount is locked!";
                return false;
            }
                
            if (!(user.UserPasswd == truePasswd))
            {
                user.RetryAtempts += 1;

                if (user.RetryAtempts >= 3)
                {
                    user.IsLocked = 1;
                }
                user.LockedDate = DateTime.Now;

                int update = service.UpdateUser(user);

                info = @"Password is not matched! " + 
                        "You have: " + (3 - user.RetryAtempts) + " attempts left!";
                return false;
            }

            if (user.RetryAtempts > 0)
            {
                user.RetryAtempts = 0;
                int update = service.UpdateUser(user);
            }

            authUser = new Users(user.UserId, user.UserName, user.Email, user.Role);
            info = "Successful login!";
            return true;
        }

        public void userSignIn(Users authUser, bool remember)
        {
            string userData = JsonConvert.SerializeObject(authUser);

            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket
                                                        (
                                                         1, //version
                                                         authUser.UserName, //user name
                                                         DateTime.Now, //start date
                                                                       //DateTime.Now.AddDays(7), //expire date
                                                         DateTime.Now.AddSeconds(HttpContext.Current.Session.Timeout),
                                                         remember,
                                                         //userData //user data
                                                         authUser.Role.Trim()
                                                         );

            string encryptTicket = FormsAuthentication.Encrypt(ticket);

            var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptTicket);
            cookie.Expires = ticket.Expiration;
            cookie.Path = FormsAuthentication.FormsCookiePath;

            if (HttpContext.Current != null)
                HttpContext.Current.Response.Cookies.Add(cookie);
        }

        protected void btLogIn_Click(object sender, EventArgs e)
        {
            string info;
            string username = tbUserName.Text.ToLower().Trim();
            string passwd = tbPasswd.Text.ToLower().Trim();

            Users authUser = new Users();

            if (authentification(username, passwd, out authUser, out info))
            {
                lbWarning.Visible = true;
                lbWarning.Text = info;

                userSignIn(authUser, cbRemeber.Checked);
                //Response.Redirect("Default.aspx");
            }
            else
            {
                lbWarning.Visible = true;
                lbWarning.Text = info;
            }

            tbPasswd.Text = "";
            tbUserName.Text = "";
        }

        protected void btFill_tblUsers_Click(object sender, EventArgs e)
        {
            //Izvrsava se samo jednom za popunu tabele "tblUsers" u bazi !!!

            Fill_tblUSERS.With_CUSTOMERS customers = new Fill_tblUSERS.With_CUSTOMERS();
            customers.CreateUserForEachCustomer();

            Fill_tblUSERS.With_EMPLOYEES employees = new Fill_tblUSERS.With_EMPLOYEES();
            employees.CreateUserForEachEmployee();
        }

        protected void tbUserName_TextChanged(object sender, EventArgs e)
        {
        }

        protected void tbPasswd_TextChanged(object sender, EventArgs e)
        { 
        }
    }
}