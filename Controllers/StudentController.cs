using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BindDropDownMVC.Models;

namespace BindDropDownMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {

            Student objuser = new Student();
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Rahul; Persist Security Info=True; User ID=sa; Password=Sa@2014"))
            {
                using (SqlCommand cmd = new SqlCommand("select * from userdetails", con))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    List<Student> userlist = new List<Student>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        Student uobj = new Student();
                        uobj.UserId = Convert.ToInt32(ds.Tables[0].Rows[i]["userid"].ToString());
                        uobj.Education = ds.Tables[0].Rows[i]["education"].ToString();
                        uobj.UserName = ds.Tables[0].Rows[i]["username"].ToString();
                        uobj.Education = ds.Tables[0].Rows[i]["education"].ToString();
                        uobj.Location = ds.Tables[0].Rows[i]["location"].ToString();
                        userlist.Add(uobj);
                    }
                    objuser.usersinfo = userlist;
                }
                con.Close();
            }
            return View(objuser);
        }
    }
}

       