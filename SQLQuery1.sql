USE SchoolDB;
GO


DROP TABLE IF EXISTS StudentSubjects;
DROP TABLE IF EXISTS TeacherSubjects;
DROP TABLE IF EXISTS Students;
DROP TABLE IF EXISTS Subjects;
DROP TABLE IF EXISTS TeachingStaffs;
DROP TABLE IF EXISTS Administrators;
GO


CREATE TABLE Administrators(
    AdminId INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Phone VARCHAR(20),
    Email VARCHAR(100),
    Salary DECIMAL(18,2),
    IsFullTime BIT,
    WorkingHours INT
);

CREATE TABLE Students(
    StudentId INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Phone VARCHAR(20),
    Email VARCHAR(100)
);

CREATE TABLE Subjects(
    SubjectId INT IDENTITY(1,1) PRIMARY KEY,
    SubjectName VARCHAR(100) NOT NULL
);

CREATE TABLE TeachingStaffs(
    TeacherId INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Phone VARCHAR(20),
    Email VARCHAR(100),
    Salary INT
);

CREATE TABLE StudentSubjects(
    StudentId INT NOT NULL,
    SubjectId INT NOT NULL,
    PRIMARY KEY (StudentId, SubjectId)
);

CREATE TABLE TeacherSubjects(
    TeacherId INT NOT NULL,
    SubjectId INT NOT NULL,
    PRIMARY KEY (TeacherId, SubjectId)
);



ALTER TABLE StudentSubjects
ADD CONSTRAINT FK_StudentSubjects_Students
FOREIGN KEY (StudentId) REFERENCES Students(StudentId);

ALTER TABLE StudentSubjects
ADD CONSTRAINT FK_StudentSubjects_Subjects
FOREIGN KEY (SubjectId) REFERENCES Subjects(SubjectId);

ALTER TABLE TeacherSubjects
ADD CONSTRAINT FK_TeacherSubjects_Teachers
FOREIGN KEY (TeacherId) REFERENCES TeachingStaffs(TeacherId);

ALTER TABLE TeacherSubjects
ADD CONSTRAINT FK_TeacherSubjects_Subjects
FOREIGN KEY (SubjectId) REFERENCES Subjects(SubjectId);


INSERT INTO Subjects (SubjectName)
VALUES 
('Math'),
('English'),
('Physics');


INSERT INTO Students (Name, Phone, Email)
VALUES 
('Nguyen Van A', '0123456789', 'a@gmail.com'),
('Tran Van B', '0987654321', 'b@gmail.com');


INSERT INTO StudentSubjects (StudentId, SubjectId)
VALUES 
(1, 1), -- A học Math
(1, 2), -- A học English
(2, 1), -- B học Math
(2, 3); -- B học Physics



SELECT 
    s.StudentId,
    s.Name,
    s.Phone,
    s.Email,
    sub.SubjectName
FROM Students s
JOIN StudentSubjects ss ON s.StudentId = ss.StudentId
JOIN Subjects sub ON ss.SubjectId = sub.SubjectId;