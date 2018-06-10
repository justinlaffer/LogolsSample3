Create database Zombie
Use Zombie

Create Table Person
(
FirstName varchar(255),
LastName varchar(255),
PersonID int,
PersonStatusID int
);

Create Table PersonStatus
(
PersonStatusID int,
StatusDescription varchar(255)
);

Insert Into PersonStatus
(PersonStatusID,StatusDescription)
Values
(1, 'Alive'),
(2, 'Zombie'),
(3, 'Dead'),
(4, 'Unknown');

Insert Into Person
(FirstName, LastName, PersonID,PersonStatusID)
Values
('Justin','Laffer',1,1),
('Trevor','Daniel',2,2),
('Sam','Cohen',3,3),
('Elliott','Daniel',4,4)

select * from PersonStatus;
select * from Person;

select FirstName, LastName, 
PersonID, PersonStatusID from Person
WHERE PersonStatusID=4;

select FirstName, LastName,
PersonID, PersonStatusId from Person
Where PersonStatusID=1 
OR PersonStatusID=4;

select FirstName, LastName,
PersonID, PersonStatusID from Person
WHERE PersonStatusID=1
AND FirstName='Tom';

UPDATE Person
SET PersonStatusID=1
WHERE FirstName='Justin';

DELETE from Person
WHERE PersonStatusID=3;

select p.FirstName, p.LastName, p.PersonID, ps.PersonStatusID, ps.StatusDescription
from Person p
inner join PersonStatus ps
ON p.PersonStatusID = ps.PersonStatusID;

select p.FirstName, p.LastName, p.PersonID, ps.PersonStatusID, ps.StatusDescription
from Person p
right Outer Join PersonStatus ps
ON p.PersonStatusID = ps.PersonStatusID;




