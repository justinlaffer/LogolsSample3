Create database Project;
Use Project;

Create Table Person
(
  PersonID int Not NUll auto_increment,
  FirstName varchar(255),
  LastName varchar(255),
  PersonStatusID int,
  Primary Key(PersonID)
  );
  
  Create Table PersonStatus
  (
    PersonStatusID int,
    StatusDescription varchar(255)
);