using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using exerciseAsp.Models;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;


namespace exerciseAsp.Controllers
{
    public class ValidateController : Controller
    {
        // GET: Validate
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ValidateClass vc) 
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "Insert into [dbo].[UserReg] ([UserName],[Age],[Email],[UserPassword],[UserRePassword]) values (@UserName,@Age,@Email,@UserPassword,@UserRePassword)";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlconn.Open();
            sqlcomm.Parameters.AddWithValue("@UserName", vc.Username);
            sqlcomm.Parameters.AddWithValue("@Age", vc.Age);
            sqlcomm.Parameters.AddWithValue("@Email", vc.Email);
            sqlcomm.Parameters.AddWithValue("@UserPassword", vc.Password);
            sqlcomm.Parameters.AddWithValue("@UserRePassword", vc.RePassword);

            sqlcomm.ExecuteNonQuery();
            ViewData["Message"] = "Registered Successfully, Please Login!";
            sqlconn.Close();

            return View();
        }
    }
}