--USING THE SPECIFIC DATABASE

USE Karamolegkos_PrivateSchool;


--5)------------------------------ALL VIEWS REQUESTED

--A list of All Students
CREATE VIEW AllStudents As Select * From Students;
SELECT*FROM AllStudents;

--A list of All Assignments
CREATE VIEW AllAssignments As Select * From Assignments;
SELECT*FROM AllAssignments;

--A list of All Trainers
CREATE VIEW AllTrainers As Select * From Trainers;
SELECT*FROM AllTrainers;

--A list of All Courses
CREATE VIEW AllCourses As Select * From Courses;
SELECT*FROM AllCourses;


--A list of All the Students Per Course
CREATE VIEW StudentsPerCourse As
SELECT c.TitleC,c.Type,c.Stream,s.FirstName,s.LastName FROM Courses c
LEFT JOIN StudentCourse sc
ON c.CourseId=sc.CourseId
LEFT JOIN Students s
ON s.StudentId=sc.StudentId;

SELECT*FROM StudentsPerCourse;


--A list of All the Trainers Per Course
CREATE VIEW TrainersPerCourse As
SELECT c.TitleC,c.Type,c.Stream,t.FirstName,t.LastName FROM Courses c
LEFT JOIN TrainerCourse tc
ON c.CourseId=tc.CourseId
LEFT JOIN Trainers t
ON t.TrainerId=tc.TrainerId;

SELECT*FROM TrainersPerCourse;


--A list of All the Assignments Per Course
CREATE VIEW AssignmentsPerCourse As
SELECT c.TitleC AS 'Course Title',c.Type,c.Stream,a.TitleA AS 'Asssignment Title',a.Description FROM Courses c
LEFT JOIN CourseAssignment ca
ON c.CourseId=ca.CourseId
LEFT JOIN Assignments a
ON a.AssignmentId=ca.AssignmentId;

SELECT*FROM AssignmentsPerCourse;


--A list of All the Assignments Per Course Per Student
CREATE VIEW AssignmentsPerCoursePerStudent As
SELECT s.FirstName,s.LastName,c.TitleC As 'Course Title',c.Type,a.TitleA As 'Assignment Title',a.Description FROM Students s 
INNER JOIN StudentCourse sc
ON s.StudentId=sc.StudentId
INNER JOIN Courses c
ON c.CourseId=sc.CourseId
INNER JOIN CourseAssignment ca
ON sc.CourseId=ca.CourseId
INNER JOIN Assignments a
ON ca.AssignmentId=a.AssignmentId;

SELECT*FROM AssignmentsPerCoursePerStudent;


--A list of All the Students who have more than one Course
CREATE VIEW StudentsWithMoreThanOneCourse As
SELECT s.FirstName,s.LastName,COUNT(c.CourseId) AS 'Total Courses Selected' FROM Students s
INNER JOIN StudentCourse sc
ON s.StudentId=sc.StudentId
INNER JOIN Courses c
ON c.CourseId=sc.CourseId
GROUP BY s.FirstName,s.LastName
HAVING COUNT (c.CourseId)>1;

SELECT*FROM StudentsWithMoreThanOneCourse;
