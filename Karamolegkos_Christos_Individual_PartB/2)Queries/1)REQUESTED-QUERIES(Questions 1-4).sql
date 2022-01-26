--1)--------------CREATE DATABASE FOR ASSIGNMENT

CREATE DATABASE Karamolegkos_PrivateSchool;

--USING THE SPECIFIC DATABASE

USE Karamolegkos_PrivateSchool;

--2)--------------CREATE TABLES


--Students
CREATE TABLE Students
( StudentId int Not Null Primary Key Identity(1,1),
  FirstName char(20) Not Null,
  LastName  char(20) Not Null,
  DateOfBirth date Not Null,
  TutitionFees int Not Null);

  --Trainers
  CREATE TABLE Trainers
  (TrainerId int Not Null Primary Key Identity(1,1),
   FirstName char(20) Not Null,
   LastName  char(20) Not Null,
   Subject char(20) Not Null);

   --Courses
   CREATE TABLE Courses
   (CourseId int Not Null Primary Key Identity(1,1),
   TitleC char(20) Not Null,
   Stream  char(20) Not Null,
   Type char(20) Not Null,
   StartDate date Not Null,
   EndDate date Not Null);

   --Assignments
   CREATE TABLE Assignments
   (AssignmentId int Not Null Primary Key Identity(1,1),
   TitleA char(20) Not Null,
   Description char(40) Not Null);

   --Students Per Course
   CREATE TABLE StudentCourse
   (StudentId int Not Null,
    CourseId int Not Null,
    Primary Key(StudentId,CourseId),
	Constraint fk_Student_Id Foreign Key (StudentId) REFERENCES Students(StudentId),
    Constraint fk_CourseStu_Id Foreign Key (CourseId) REFERENCES Courses(CourseId));

	--Assignments Per Course
	CREATE TABLE CourseAssignment
	(CourseId int Not Null,
	 AssignmentId int Not Null,
	 SubmissionDate date Not Null, 
	 Primary Key (CourseId,AssignmentId),
	 Constraint fk_Assignment_Id Foreign Key (AssignmentId) REFERENCES Assignments(AssignmentId),
	 Constraint fk_CourseAssi_Id Foreign Key (CourseId) REFERENCES Courses(CourseId));

	 --Trainers Per Course
	 CREATE TABLE TrainerCourse
	 (TrainerId int Not Null,
	 CourseId int Not Null,
	 Primary Key(TrainerId,CourseId),
	 Constraint fk_Trainer_Id Foreign Key (TrainerId) REFERENCES Trainers(TrainerId),
	 Constraint fk_CourseTra_Id Foreign Key (CourseId) REFERENCES Courses(CourseId));

	 --Assignments Students
	 CREATE TABLE StudentAssignment
	 (StudentId int Not Null,
	 AssignmentId int Not Null,
	 OralMark int Not Null,
	 TotalMark int Not Null,
	 Primary Key(StudentId,AssignmentId),
	 Constraint fk_Assign_Id Foreign Key (AssignmentId) REFERENCES Assignments(AssignmentId),
	 Constraint fk_StudentAssign_Id Foreign Key (StudentId) REFERENCES Students(StudentId));

	 --AssignmentPerStudentPerCourse
	 CREATE TABLE AssignmentPerStudentPerCourse
	 (StudentId int Not Null,
	 AssignmentId int Not Null,
	 CourseId int Not Null,
	 Primary Key(StudentId,AssignmentId,CourseId),
	 Constraint fk_Assign1_Id Foreign Key (AssignmentId) REFERENCES Assignments(AssignmentId),
	 Constraint fk_Student1_Id Foreign Key (StudentId) REFERENCES Students(StudentId),
	 Constraint fk_Course1_Id Foreign Key (CourseId) REFERENCES Courses(CourseId));


	 --PROCEDURES FOR CREATE ENTITIES--

CREATE PROCEDURE CreateStudent
(@FirstName char(15),@LastName  char(15),@DateOfBirth date,@TutitionFees int) AS
BEGIN
INSERT INTO Students(FirstName,LastName,DateOfBirth,TutitionFees) 
VALUES
(@FirstName,@LastName,@DateOfBirth,@TutitionFees)
END

CREATE PROCEDURE CreateCourse
(@TitleC char(20),@Stream  char(20),@Type char(20),@StartDate date,@EndDate date) AS
BEGIN
INSERT INTO Courses(TitleC,Stream,Type,StartDate,EndDate) 
VALUES
(@TitleC,@Stream,@Type,@StartDate,@EndDate)
END

CREATE PROCEDURE CreateAssignment
(@TitleA char(20),@Description char(40)) AS
BEGIN
INSERT INTO Assignments(TitleA,Description)
VALUES
(@TitleA,@Description)
END

CREATE PROCEDURE CreateTrainer
(@FirstName char(20),@LastName  char(20),@Subject char(20)) AS
BEGIN
INSERT INTO Trainers(FirstName,LastName,Subject)
VALUES(@FirstName,@LastName,@Subject)
END

CREATE PROCEDURE InsertStudentPerCourse
(@StudentId int,@CourseId int ) AS
BEGIN
INSERT INTO StudentCourse(StudentId,CourseId)
VALUES(@StudentId,@CourseId)
END

CREATE PROCEDURE InsertTrainerPerCourse
(@TrainerId int,@CourseId int ) AS
BEGIN
INSERT INTO TrainerCourse(TrainerId,CourseId)
VALUES(@TrainerId,@CourseId)
END

CREATE PROCEDURE InsertAssignmentPerStudentPerCourse
(@StudentId int,@AssignmentId int,@CourseId int ) AS
BEGIN
INSERT INTO AssignmentPerStudentPerCourse(StudentId,AssignmentId,CourseId)
VALUES(@StudentId,@AssignmentId,@CourseId)
END



--3)-----------------POPULATE THE TABLES WITH SYNTHETIC DATA

--Students
INSERT INTO Students (FirstName,LastName,DateOfBirth,TutitionFees) VALUES
('Christos','Karamolegkos','1990-06-17',2500),
('Stefania','Latsoudi','1989-12-27',4500),
('Giorgos','Votsis','1990-06-23',3500),
('Lefteris','Ligomenidis','1990-06-16',12500),
('Leandros','Athanasiadis','1989-07-20',7500),
('Fanis','Argiropoulos','1991-06-17',9900),
('Anna','Kitou','1989-10-16',19900),
('Artemis','Kim','1988-08-16',12500),
('Nina','Koutsoumpa','1992-05-30',2100),
('Giorgos','Gavrilakis','1990-07-17',22500),
('Simos','Kordilis','1991-09-23',6600),
('Kostas','Svoronos','1991-02-22',4500),
('Dimitris','Atzolidakis','1990-09-10',1500),
('Penny','Maggana','1996-09-11',42500),
('Anargyros','Arvanitis','1992-10-04',8500),
('Nikoleta','Drosou','1989-09-30',3300),
('Nikos','Mihelis','1992-06-06',8500),
('Eygenia','Apostolaki','1960-02-16',1500),
('Ioannis','Karamolegkos','1959-01-08',1500),
('Leonidas','Bolaris','1988-12-06',13500);

--Trainers
INSERT INTO Trainers (FirstName,LastName,Subject) VALUES
('Giorgos','Papadopoulos','Python '),
('Hector','Gatsos','C#'),
('Panagiotis','Bozas','Sql'),
('Despoina','Kirikou','Python'),
('Leon','Ntokardos','C#'),
('Marios','Kourbelis','Sql'),
('Eleni','Nikou','Python'),
('Stelios','Kourgiounis','C#');

--Courses
INSERT INTO Courses (TitleC,Stream,Type,StartDate,EndDate) VALUES
('Python','CB#15','Full Time','2021-10-10','2022-01-10'),
('Python','CB#15','Part Time','2021-10-10','2022-03-10'),
('C#','CB#15','Full Time','2021-11-10','2022-02-10'),
('C#','CB#15','Part Time','2021-11-10','2022-05-10'),
('Sql','CB#15','Full Time','2021-12-12','2022-03-12'),
('Sql','CB#15','Part Time','2021-12-12','2022-06-12');

--Assignments
INSERT INTO Assignments (TitleA,Description) VALUES
('Solo Project Python','Indvividual Project in Python'),
('Team Project Python','Team Project in Python'),
('Solo Project C#','Indvividual Project in C#'),
('Team Project C#','Team Project in C#'),
('Solo Project Sql','Indvividual Project Sql'),
('Team Project Sql','Team Project Sql');

--StudentCourse
INSERT INTO StudentCourse VALUES
(1,3),
(1,1),
(1,5),
(2,2),
(3,3),
(4,4),
(5,6),
(6,2),
(6,3),
(7,5),
(8,2),
(9,4),
(10,2),
(10,4),
(10,5),
(11,4),
(11,5),
(12,2),
(13,1),
(13,6),
(14,4),
(14,5),
(15,2),
(15,3),
(16,1),
(16,6),
(17,1),
(18,2),
(18,5),
(19,1),
(19,6),
(20,2),
(20,3),
(20,5);

--AssignmentCourse
INSERT INTO CourseAssignment VALUES
(1,1,'2021-12-12'),
(1,2,'2022-01-10'),
(2,1,'2022-02-13'),
(3,3,'2022-01-18'),
(3,4,'2022-02-09'),
(4,3,'2022-04-19'),
(5,5,'2021-12-22'),
(5,6,'2022-02-27'),
(6,5,'2022-05-13');

--TrainerCourse
INSERT INTO TrainerCourse VALUES
(1,1),
(2,3),
(2,4),
(3,5),
(3,6),
(4,2),
(5,3),
(6,5),
(6,6),
(7,1),
(8,3);

--StudentAssignment
INSERT INTO StudentAssignment VALUES
(1,3,50,100),
(1,4,70,95),
(1,1,60,100),
(1,2,78,98),
(1,5,100,100),
(1,6,99,100),
(2,1,68,75),
(3,3,67,97),
(3,4,87,90),
(4,3,65,89),
(5,5,90,100),
(6,1,82,93),
(6,3,76,86),
(6,4,87,99),
(7,5,67,80),
(7,6,89,92),
(8,1,70,70),
(9,3,81,89),
(10,1,100,100),
(10,3,70,80),
(10,5,89,93),
(10,6,91,99),
(11,3,45,56),
(12,1,45,49),
(13,1,67,78),
(13,2,89,92),
(13,5,67,77),
(14,3,56,59),
(14,5,60,70),
(14,6,98,100),
(15,1,55,95),
(15,3,69,72),
(15,4,87,89),
(16,1,90,100),
(16,2,95,100),
(16,5,99,100),
(17,1,81,90),
(17,2,82,84),
(18,1,70,71),
(18,5,91,99),
(18,6,92,93),
(19,1,82,100),
(19,2,99,100),
(19,5,100,100),
(20,1,99,100),
(20,3,98,100),
(20,4,45,47),
(20,5,76,77),
(20,6,99,100);

--AssignmentPerStudentPerCourse
INSERT INTO AssignmentPerStudentPerCourse VALUES
(1,1,1),
(1,2,1),
(1,5,5),
(1,6,5),
(2,1,2),
(3,3,3),
(3,4,3),
(4,3,4),
(5,5,6),
(6,1,2),
(6,3,3),
(6,4,3),
(7,5,5),
(7,6,5),
(8,1,2),
(9,3,4),
(10,1,2),
(10,3,4),
(10,5,5),
(10,6,5),
(11,3,4),
(11,5,5),
(11,6,5),
(12,1,2),
(13,1,1),
(13,2,1),
(13,5,6),
(14,3,4),
(14,5,5),
(14,6,5),
(15,1,2),
(15,3,3),
(15,4,3),
(16,1,1),
(16,2,1),
(16,5,6),
(17,1,1),
(17,2,1),
(18,1,2),
(18,5,5),
(18,6,5),
(19,1,1),
(19,2,1),
(19,5,6),
(20,1,2),
(20,3,3),
(20,4,3),
(20,5,5),
(20,6,5);

