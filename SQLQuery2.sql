create database Handson

drop table customer

create table salesman(salesman_id int primary key,name varchar(50),city varchar(15), commission decimal(5,2))

insert into salesman values(5001, 'James Hoog', 'New York', 0.15)
insert into salesman values(5002, 'Nail Knite', 'Paris', 0.13)
insert into salesman values(5005, 'Pit Alex', 'London', 0.11)
insert into salesman values(5006, 'Mc Lyon', 'Paris', 0.14)
insert into salesman values(5007, 'Paul Adam', 'Rose', 0.13)
insert into salesman values(5003, 'Lauson Hen', 'San Jose ', 0.12)


create table customer(customer_id int primary key, cust_name varchar(30), city varchar(15), grade int, salesman_id numeric(5))
insert into customer values(3002, 'Nick Rimando', 'New York' ,100 , 5001)
insert into customer values(3007, 'Brad Davis','New York' , 200, 5001)
insert into customer values(3005, 'Graham Zusi', 'California' ,200, 5002)
insert into customer values(3008, 'Julian Green','London' , 300, 5002)
insert into customer values(3004, '2Fabian Johnson', 'Paris' ,300, 5006)
insert into customer values(3009, 'Geoff Cameron', 'Berlin' ,100, 5003)
insert into customer values(3003, 'Jozy Altidor', 'Moscow' ,200, 5007)
insert into customer(customer_id, cust_name, city, salesman_id) values(3001, 'Brad Guzan', 'London' , 5005)


create table orders(ord_no int primary key,purch_amt decimal(8,2), ord_date date, customer_id int references customer(customer_id), salesman_id int references salesman(salesman_id))

insert into orders values(70001, 150.5, '2012-10-05', 3005, 5002)
insert into orders values(70009, 270.65, '2012-09-10', 3001, 5005)
insert into orders values(770002, 65.26, '2012-10-05', 3002, 5001)
insert into orders values(70004, 110.5, '2012-08-17', 3009, 5003)
insert into orders values(70007, 948.5, '2012-09-10', 3005, 5002)
insert into orders values(70005, 2400.6, '2012-07-27', 3007, 5001)
insert into orders values(770008, 5760, '2012-09-10', 3002, 5001)
insert into orders values(770010, 1983.43, '2012-10-10', 3004, 5006)
insert into orders values(70003, 2480.4, '2012-10-10', 3009, 5003)
insert into orders values(70012, 250.45, '2012-06-27', 3008,5002)
insert into orders values(70011, 75.29, '2012-08-17', 3003, 5007)
insert into orders values(70013, 3045.6, '2012-04-25', 3002, 5001)


select * from orders

select * from customer


--Assessment
--Write a SQL query to calculate total purchase amount of all orders. Return total purchase amount.
select sum(purch_amt) as sum
from orders

--write a SQL query to find the highest grade of the customers for each of the city. Return city, maximum grade.
select city as City, max(grade)as Max
from customer
group by city

--write a SQL query to find highest order (purchase) amount by each customer in a particular order date. 
--Filter the result by highest order (purchase) amount above 2000.00. 
--Return customer id, order date and maximum purchase amount.
select customer_id as "Customer Id",ord_date as "order Date", max(purch_amt) as max
from orders
where purch_amt > 2000.00
group by customer_id, ord_date
order by max(purch_amt) asc

--write a SQL query to find the salesperson and customer who belongs to same city. Return Salesman, cust_name and city.
select salesman.name as Salesman, customer.cust_name as " Cust Name", customer.city as city
from customer, salesman
where customer.city = salesman.city 




--1.	Write a SQL statement to display all the information of all salesmen
select * from salesman

--2.	Write a SQL statement to display specific columns like name and commission for all the salesmen
select name, commission from salesman

--3.	Write a query to display the columns in a specific order like order date, salesman id, order number and purchase amount from for all the orders
select ord_date, salesman_id, ord_no, purch_amt from orders

--4.	write a SQL query to find the salespeople who lives in the City of 'Paris'. Return salesperson's name, city.
select city, name
from salesman
where city = 'Paris';
--5.	write a SQL query to find those customers whose grade is 200. Return customer_id, cust_name, city, grade, salesman_id
select customer_id, cust_name, city, grade, salesman_id
from customer
where grade = 200;

--6.	write a SQL query to find the orders, which are delivered by a salesperson of ID. 5001. Return ord_no, ord_date, purch_amt
select ord_no, ord_date, purch_amt
from orders
where salesman_id = 5001;

