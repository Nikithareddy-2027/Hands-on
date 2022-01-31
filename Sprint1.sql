create database Sprint1

drop table TransactionDetails

select * from CustomerDetails
create table CustomerDetails(CustName varchar(100), CustId int primary key identity, Address varchar(max), City varchar(50), PinCode numeric, PhNo int)
insert into CustomerDetails values('Nikitha', 'nfkuyd\sbjndlkjdoeiuhd','WNP',509103,87664)

select * from ReceiverDetails
create table ReceiverDetails(ReceiverName varchar(100), ReceiverId numeric primary key identity, Address varchar(max), City varchar(50), PinCode numeric, PhNo int)
insert into ReceiverDetails values('Jyoshna', 'nbtrssdyu','ANT',64556,074432)

select * from TransactionDetails
create table TransactionDetails(TransId int primary key, TotalAmount numeric, Date DATE, BankAccNo int)
insert into TransactionDetails values(1,2345,'20-01-2022', 2324536547)
insert into TransactionDetails values(2,2685,'2-03-2022 4:23:33am', 2324902410)


select * from BillingDetails
create table BillingDetails(BillNo numeric primary key, CustId int references CustomerDetails(CustId), TransId int references TransactionDetails(TransId), Date Date, AmountPaid numeric)


select*from RegisterDetails
create table RegisterDetails(FirstName varchar(50), Lastname varchar(50), Email varchar(100),PhoneNumber numeric, Password varchar(50), Re_enterpassword varchar(50) )