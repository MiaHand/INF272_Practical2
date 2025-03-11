using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INF272_Practical.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult TableStudents()
        {
            List<Models.StudentClass> students = new List<Models.StudentClass>();

            students.Add(new Models.StudentClass { StudentNumber = "u04949872", Name = "Mia", Surname = "Hand", EmailAddress = "u04949872@tuks.co.za", myLink = "~/HTML/HtmlStudent1.html" });
            students.Add(new Models.StudentClass { StudentNumber = "u22512188", Name = "Cheyenne", Surname = "Scheepers", EmailAddress = "u22512188@tuks.co.za", myLink = "~/HTML/HtmlStudent2.html" });
            students.Add(new Models.StudentClass { StudentNumber = "u20434066", Name = "Rory", Surname = "Finbow", EmailAddress = "u20434066@tuks.co.za", myLink = "~/HTML/HtmlStudent3.html" });
            students.Add(new Models.StudentClass { StudentNumber = "u21493180", Name = "Samantha", Surname = "van Es", EmailAddress = "u21493180@tuks.co.za", myLink = "~/HTML/HtmlStudent4.html" });
            students.Add(new Models.StudentClass { StudentNumber = "u22507176", Name = "Dehan", Surname = "Kriel", EmailAddress = "u22507176@tuks.co.za", myLink = "~/HTML/HtmlStudent5.html" });

            return View("TableStudents", students);
        }
    }
}