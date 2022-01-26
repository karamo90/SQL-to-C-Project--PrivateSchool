using Karamolegkos_Christos_PrivateSchool.Repository;
using Karamolegkos_Christos_PrivateSchool.View.Students;
using Karamolegkos_PrivateSchool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karamolegkos_Christos_PrivateSchool.Controller
{
    class StudentController
    {
        Karamolegkos_PrivateSchoolEntities db = new Karamolegkos_PrivateSchoolEntities();
        StudentRepository service = new StudentRepository();
        public void AllStudents()
        {
            var stu = service.GetAll();
            ViewStudent.AllStudents(stu);

        }
        public void AllStudentsWithMoreThanOneCourse()
        {
            var stu = db.StudentsWithMoreThanOneCourses.ToList();
            ViewStudent.AllStudentsWithMoreThanOneCourse(stu);


        }



    }
}

