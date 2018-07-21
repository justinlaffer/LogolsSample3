Create database Review;
Use Review;

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

select  p.FirstName,p.LastName,ps.PersonStatusID,ps.StatusDescription
from Person p
inner join PersonStatus ps
ON p.PersonStatusID = ps.PersonStatusID;
  
  Insert Into Person
  (FirstName,LastName, PersonID, PersonStatusID)
  Values
  ('Justin','Laffer', 1, 1),
  ('Sam','Cohen',2,2),
  ('Elliott','Disner',3,3),
  ('Ben','Tredwell',4,4);
  
  Insert Into PersonStatus
  (PersonStatusID, StatusDescription)
  Values
  (1,'Alive'),
  (2,'Zombie'),
  (3,'Dead'),
  (4,'Unknown');
  
