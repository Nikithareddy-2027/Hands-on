drop table Tutorial
create table Tutorial(TutorialId int primary key, TutorialName varchar(100), TutorialDesc varchar(max), Published int, TutorialFee numeric)

select * from Tutorial

create table UserInfo(Id int primary key identity, Firstname varchar(100), Lastname varchar(100), Email varchar(50), Mobile numeric, Password varchar(100))

select * from UserInfo

create table TutorialUsers(Id int primary key identity, UserId int references UserInfo(Id), TutorialId int references Tutorial(TutorialId))

select * from TutorialUsers