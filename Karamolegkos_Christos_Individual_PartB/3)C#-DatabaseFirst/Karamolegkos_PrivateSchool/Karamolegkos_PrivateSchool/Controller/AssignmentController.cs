using Karamolegkos_Christos_PrivateSchool.Repository;
using Karamolegkos_Christos_PrivateSchool.View.Assignments;
using Karamolegkos_PrivateSchool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karamolegkos_Christos_PrivateSchool.Controller
{
    class AssignmentController
    {
        AssignmentRepository service = new AssignmentRepository();
        public void AllAssignments()
        {

            var assi = service.GetAll();
            ViewAssignment.AllAssignments(assi);

        }
        public void AllAssignmentsPerCoursePerStudent()
        {
            Karamolegkos_PrivateSchoolEntities db = new Karamolegkos_PrivateSchoolEntities();
            var stu = db.Students.ToList();
            var assi = db.Assignments.ToList();
            var cou = db.Courses.ToList();
            var everyOne = db.AssignmentPerStudentPerCourses.ToList();
            ViewAssignment.AllAssignmentsPerCoursePerStudents(cou, stu, assi,everyOne);
        }

    }
}

