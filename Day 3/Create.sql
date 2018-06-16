USE TimeMachine;
CREATE TABLE TimeTraveler (
  TimeTravelerId int NOT NULL AUTO_INCREMENT,
  FirstName varchar(100) NOT NULL,
  LastName varchar(100) NOT NULL,
  PRIMARY KEY ('TimeTravelerId')
);

CREATE TABLE TimeTravelLog (
  TimeTravelLogId int NOT NULL AUTO_INCREMENT,
  TimeTravelerId int NOT NULL,
  TravelToYear int NOT NULL,
  TravelDate datetime DEFAULT NULL,
  PRIMARY KEY ('TimeTravelLogId')
);

