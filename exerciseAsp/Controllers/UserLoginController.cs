using exerciseAsp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace exerciseAsp.Controllers
{
    public class UserLoginController : Controller
    {
        public object FormAuthentication { get; private set; }

        // GET: UserLogin
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Index(LoginClass lc)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            SqlCommand sqlcomm = new SqlCommand("[dbo].[UserLogin]");
            sqlconn.Open();
            sqlcomm.Connection = sqlconn;
            sqlcomm.CommandType = CommandType.StoredProcedure;
            sqlcomm.Parameters.AddWithValue("@Email", lc.UserEmail);
            sqlcomm.Parameters.AddWithValue("@Password", lc.Password);
            SqlDataReader sdr = sqlcomm.ExecuteReader();

            if(sdr.Read())
            {
                FormsAuthentication.SetAuthCookie(lc.UserEmail, true);
                Session["username"] = lc.UserEmail.ToString();
                return RedirectToAction("Welcome");
            }

            else
            {
                ViewData["message"] = "Login details are not correct!Try it again!";

            }

            sqlconn.Close();
            return View();
        }
        public ActionResult Welcome()
        {
            return View();
        }
    }
}