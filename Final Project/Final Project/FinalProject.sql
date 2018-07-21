Create database FinalProject;
Use FinalProject; 

Create Table Member
(
FirstName varchar(255),
LastName varchar(255),
MemberID int,
MemberStatusID int
);

Create Table MemberStatus
(
MemberStatusID int,
MemberStatusDescription varchar(255)
);

Create Table Class
(
  ClassID int,
  ClassDescription varchar(255)
);

Create Table ClassMember
(
	ClassID int,
  MemberID int
);

select m.FirstName, m.LastName, ms.MemberStatusID, ms.MemberStatusDescription, c.ClassDescription
from Member m
inner join MemberStatus ms
ON m.MemberStatusID = ms.MemberStatusID
inner join ClassMember cm
On m.MemberId = cm.MemberID
inner join Class c
On c.ClassID = cm.ClassID;

 Insert Into Member
  (FirstName,LastName, MemberID, MemberStatusID)
  Values
  ('Justin','Laffer', 1, 1),
  ('John','Smith',1,1),
  ('Jim','Miller',2,2),
  ('Sam','Tredwell',2,2);
  
  
  Insert Into MemberStatus
  (MemberStatusID, MemberStatusDescription)
  Values
  (1,'Active'),
  (2,'Inactive');

 Insert Into Class
 (ClassID, ClassDescription)
 Values
 ('1','Swim Class'),
 ('2','Cycling Class'),
 ('3','Kickboxing Class'),
 ('4', 'Pilates Class');
 
 Insert Into ClassMember
 (ClassID,MemberID)
 Values 
 (1, 1),
 (2, 1),
 (3, 2),
 (4, 2);
 
