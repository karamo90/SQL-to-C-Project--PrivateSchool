using Karamolegkos_Christos_PrivateSchool.Repository;
using Karamolegkos_Christos_PrivateSchool.View.Courses;
using Karamolegkos_PrivateSchool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karamolegkos_Christos_PrivateSchool.Controller
{
    class CourseController
    {
        Karamolegkos_PrivateSchoolEntities db = new Karamolegkos_PrivateSchoolEntities();
        CourseRepository service = new CourseRepository();
        public void AllCourses()
        {
            var cou = service.GetAll();
            ViewCourse.AllCourses(cou);
        }
        public void AllStudentsPerCourse()
        {
            var cou = service.GetAll();
            ViewCourse.PrintStudentsPerCourses(cou);
        }
        public void AllTrainersPerCourse()
        {
            var cou = service.GetAll();
            ViewCourse.PrintTrainersPerCourse(cou);
        }
        public void AllAssignmentsPerCourse()
        {
            Karamolegkos_PrivateSchoolEntities db = new Karamolegkos_PrivateSchoolEntities();
            var cou = service.GetAll();
            var assi = db.Assignments.ToList();
            var ca = db.CourseAssignments.ToList();
            ViewCourse.PrintAssignmentsPerCourse(cou, assi, ca);
        }

    }
}

