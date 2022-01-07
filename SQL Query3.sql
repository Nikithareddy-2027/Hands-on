--write a SQL query to calculate average purchase amount of all orders. Return average purchase amount. 

select * from orders

select avg(purch_amt) as 'average purchase amount'
from orders

--SELECT AVG (purch_amt)
--FROM orders;
 
--avg
--1461.7650000000000000

--write a SQL query to count the number of unique salespeople. Return number of salespeople.  
select * from salesman

select COUNT (DISTINCT salesman_Id ) 
from orders

--write a SQL query to count the number of customers. Return number of customers.
select * from customer

select count(*) 
from customer

--write a SQL query to find the maximum purchase amount
select * from orders

select min(purch_amt) as maxamount
from orders


--write a SQL query to find the highest grade of the customers for each of the city. Return city, maximum grade.
select * from customer

select city, max(grade) as maxgrade
from customer
group by city
order by maxgrade desc

--write a SQL query to find the highest purchase amount ordered by each customer. Return customer ID, maximum purchase amount
select * from orders

select customer_id, max(purch_amt) as maxpurchamt
from orders
group by customer_id
order by maxpurchamt desc