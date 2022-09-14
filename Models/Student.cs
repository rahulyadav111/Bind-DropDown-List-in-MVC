using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BindDropDownMVC.Models
{
    public class Student
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Education { get; set; }
        public string Location { get; set; }
        public List<Student> usersinfo { get; set; }
    }
}