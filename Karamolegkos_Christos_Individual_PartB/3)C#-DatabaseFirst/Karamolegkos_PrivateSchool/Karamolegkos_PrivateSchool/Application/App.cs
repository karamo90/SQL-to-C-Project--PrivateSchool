using Karamolegkos_Christos_PrivateSchool.Controller;
using Karamolegkos_PrivateSchool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karamolegkos_Christos_PrivateSchool.Application
{
    class App
    {
        public static void Run()
        {
            Karamolegkos_PrivateSchoolEntities db = new Karamolegkos_PrivateSchoolEntities();
            AssignmentController assignmentController = new AssignmentController();
            CourseController courseController = new CourseController();
            StudentController studentController = new StudentController();
            TrainerController trainerController = new TrainerController();
            string input = "";
            string input2 = "";
            InitialMenu.InitialMenu.Menu();
            do
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("These are your Choices:");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("1-Read Synthetic Data");
                Console.WriteLine("2-Input Data");
                Console.WriteLine("3-Exit");
                input2 = Console.ReadLine();
                Console.Clear();
                switch (input2)
                {
                    case "1":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("---------------------Synthetic Data Entries--------------------------");
                        Console.ResetColor();
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"{new string('-', 69)}");
                            Console.ResetColor();
                            Console.WriteLine("1-Read all Students");
                            Console.WriteLine("2-Read all Courses");
                            Console.WriteLine("3-Read all Trainers");
                            Console.WriteLine("4-Read all Assignments");
                            Console.WriteLine("5-Read all Students Per Course");
                            Console.WriteLine("6-Read all Trainers Per Courses");
                            Console.WriteLine("7-Read all Assignments Per Courses");
                            Console.WriteLine("8-Read all Assignments Per Courses Per Students");
                            Console.WriteLine("9-Read all Students that Belong to more than one Course");
                            Console.WriteLine(new string('-', 69));
                            Console.WriteLine("R for Return to the previously MENU");
                            Console.WriteLine("E for EXIT");
                            Console.WriteLine();
                            input = Console.ReadLine();
                            Console.Clear();
                            switch (input)
                            {
                                case "1": studentController.AllStudents(); break;
                                case "2": courseController.AllCourses(); break;
                                case "3": trainerController.AllTrainers(); break;
                                case "4": assignmentController.AllAssignments(); break;
                                case "5": courseController.AllStudentsPerCourse(); break;
                                case "6": courseController.AllTrainersPerCourse(); break;
                                case "7": courseController.AllAssignmentsPerCourse(); break;
                                case "8": assignmentController.AllAssignmentsPerCoursePerStudent(); break;
                                case "9": studentController.AllStudentsWithMoreThanOneCourse(); break;
                                case "R": InitialMenu.InitialMenu.Menu(); break;
                                case "E":
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Goodbye and Have a nice Day!");
                                    Console.ResetColor(); break;


                                default:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Wrong Input please Type again!");
                                    Console.WriteLine();
                                    Console.ResetColor(); break;

                            }

                        } while (input != "E" && input != "R"); break;

                    case "2":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("---------------------Create and Attach Data Entries--------------------------");
                        Console.ResetColor();
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"{new string('-', 66)}");
                            Console.ResetColor();
                            Console.WriteLine("1-Create and Add new Students");
                            Console.WriteLine("2-Create and Add new Courses");
                            Console.WriteLine("3-Create and Add new Trainers");
                            Console.WriteLine("4-Create and Add new Assignments");
                            Console.WriteLine("5-Attach Student to a Course");
                            Console.WriteLine("6-Attach Trainer to a Course");
                            Console.WriteLine("7-Attach Assignment to Course to Student");
                            Console.WriteLine(new string('-', 69));
                            Console.WriteLine("R for Return to the previously MENU");
                            Console.WriteLine("E for EXIT");
                            input = Console.ReadLine();
                            Console.Clear();
                            switch (input)
                            {
                                case "1": View.Students.CreateNewStudent.CreateNewStudentToDatabase(); break;
                                case "2": View.Courses.CreateNewCourse.CreateNewCourseToDatabase(); break;
                                case "3": View.Trainers.CreateNewTrainer.CreateNewTrainerToDatabase(); break;
                                case "4": View.Assignments.CreateNewAssignment.CreateNewAssignmentToDatabase(); break;
                                case "5": View.Attach.InsertStudentToCourse.AttachStudentToCourse(); break;
                                case "6": View.Attach.InsertTrainerToCourse.AttachTrainerToCourse(); break;
                                case "7": View.Attach.InsertAssignmentPerStudentPerCourse.AttachAssignmentStudentCourse(); break;
                                case "R": InitialMenu.InitialMenu.Menu(); break;
                                case "E":
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Goodbye and Have a nice Day!");
                                    Console.ResetColor(); break;
                                default:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Wrong Input please Type again!");
                                    Console.WriteLine();
                                    Console.ResetColor(); break;

                            }

                        } while (input != "E" && input != "R"); break;
                    case "3":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Goodbye and Have a nice Day!");
                        Console.ResetColor(); break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{new string('-', 30)}{"Wrong Input please Type again!"}{new string('-', 30)}");
                        Console.WriteLine();
                        Console.ResetColor();
                        InitialMenu.InitialMenu.Menu(); break;
                }
            } while (input2 != "3" && input != "E");
        }
    }
}





        













