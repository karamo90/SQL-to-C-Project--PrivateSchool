﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Karamolegkos_PrivateSchool
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Karamolegkos_PrivateSchoolEntities : DbContext
    {
        public Karamolegkos_PrivateSchoolEntities()
            : base("name=Karamolegkos_PrivateSchoolEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AssignmentPerStudentPerCourse> AssignmentPerStudentPerCourses { get; set; }
        public virtual DbSet<Assignment> Assignments { get; set; }
        public virtual DbSet<CourseAssignment> CourseAssignments { get; set; }
        public virtual DbSet<Cours> Courses { get; set; }
        public virtual DbSet<StudentAssignment> StudentAssignments { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Trainer> Trainers { get; set; }
        public virtual DbSet<AllAssignment> AllAssignments { get; set; }
        public virtual DbSet<AllCours> AllCourses { get; set; }
        public virtual DbSet<AllStudent> AllStudents { get; set; }
        public virtual DbSet<AllTrainer> AllTrainers { get; set; }
        public virtual DbSet<AssignmentsPerCourse> AssignmentsPerCourses { get; set; }
        public virtual DbSet<AssignmentsPerCoursePerStudent> AssignmentsPerCoursePerStudents { get; set; }
        public virtual DbSet<StudentsPerCourse> StudentsPerCourses { get; set; }
        public virtual DbSet<StudentsWithMoreThanOneCourse> StudentsWithMoreThanOneCourses { get; set; }
        public virtual DbSet<TrainersPerCourse> TrainersPerCourses { get; set; }
    
        public virtual int CreateAssignment(string titleA, string description)
        {
            var titleAParameter = titleA != null ?
                new ObjectParameter("TitleA", titleA) :
                new ObjectParameter("TitleA", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateAssignment", titleAParameter, descriptionParameter);
        }
    
        public virtual int CreateCourse(string titleC, string stream, string type, Nullable<System.DateTime> startDate, Nullable<System.DateTime> endDate)
        {
            var titleCParameter = titleC != null ?
                new ObjectParameter("TitleC", titleC) :
                new ObjectParameter("TitleC", typeof(string));
    
            var streamParameter = stream != null ?
                new ObjectParameter("Stream", stream) :
                new ObjectParameter("Stream", typeof(string));
    
            var typeParameter = type != null ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(string));
    
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("StartDate", startDate) :
                new ObjectParameter("StartDate", typeof(System.DateTime));
    
            var endDateParameter = endDate.HasValue ?
                new ObjectParameter("EndDate", endDate) :
                new ObjectParameter("EndDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateCourse", titleCParameter, streamParameter, typeParameter, startDateParameter, endDateParameter);
        }
    
        public virtual int CreateStudent(string firstName, string lastName, Nullable<System.DateTime> dateOfBirth, Nullable<int> tutitionFees)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var dateOfBirthParameter = dateOfBirth.HasValue ?
                new ObjectParameter("DateOfBirth", dateOfBirth) :
                new ObjectParameter("DateOfBirth", typeof(System.DateTime));
    
            var tutitionFeesParameter = tutitionFees.HasValue ?
                new ObjectParameter("TutitionFees", tutitionFees) :
                new ObjectParameter("TutitionFees", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateStudent", firstNameParameter, lastNameParameter, dateOfBirthParameter, tutitionFeesParameter);
        }
    
        public virtual int CreateTrainer(string firstName, string lastName, string subject)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var subjectParameter = subject != null ?
                new ObjectParameter("Subject", subject) :
                new ObjectParameter("Subject", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateTrainer", firstNameParameter, lastNameParameter, subjectParameter);
        }
    
        public virtual int InsertAssignmentPerStudentPerCourse(Nullable<int> studentId, Nullable<int> assignmentId, Nullable<int> courseId)
        {
            var studentIdParameter = studentId.HasValue ?
                new ObjectParameter("StudentId", studentId) :
                new ObjectParameter("StudentId", typeof(int));
    
            var assignmentIdParameter = assignmentId.HasValue ?
                new ObjectParameter("AssignmentId", assignmentId) :
                new ObjectParameter("AssignmentId", typeof(int));
    
            var courseIdParameter = courseId.HasValue ?
                new ObjectParameter("CourseId", courseId) :
                new ObjectParameter("CourseId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertAssignmentPerStudentPerCourse", studentIdParameter, assignmentIdParameter, courseIdParameter);
        }
    
        public virtual int InsertStudentPerCourse(Nullable<int> studentId, Nullable<int> courseId)
        {
            var studentIdParameter = studentId.HasValue ?
                new ObjectParameter("StudentId", studentId) :
                new ObjectParameter("StudentId", typeof(int));
    
            var courseIdParameter = courseId.HasValue ?
                new ObjectParameter("CourseId", courseId) :
                new ObjectParameter("CourseId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertStudentPerCourse", studentIdParameter, courseIdParameter);
        }
    
        public virtual int InsertTrainerPerCourse(Nullable<int> trainerId, Nullable<int> courseId)
        {
            var trainerIdParameter = trainerId.HasValue ?
                new ObjectParameter("TrainerId", trainerId) :
                new ObjectParameter("TrainerId", typeof(int));
    
            var courseIdParameter = courseId.HasValue ?
                new ObjectParameter("CourseId", courseId) :
                new ObjectParameter("CourseId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertTrainerPerCourse", trainerIdParameter, courseIdParameter);
        }
    }
}
