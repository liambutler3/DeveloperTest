using System.Web.Mvc;
using testWebApp.Models;
using System.Data.SqlClient;
using System;

namespace testWebApp.Controllers
{
    public class UserController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index (UserModel model)
        {
            if (ModelState.IsValid)
            {
                string sql = String.Format(
                    "INSERT INTO [dbo].[tbl_Users] ([Firstname], [Lastname], [Email], [Password])" +
                    "VALUES ('{0}','{1}','{2}','{3}')", model.FirstName, model.LastName, model.Email, model.Password);

                using (SqlConnection connection = new SqlConnection(model.ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.ExecuteNonQuery();
                }

                model.Sucess = true;

                return View(model);
            }
            return View();
        }
    }
}