--write a SQL query to find the salesperson and customer who belongs to same city. Return Salesman, cust_name and city.
select * from customer
select * from salesman


select salesman.name, customer.cust_name, customer.city
from salesman inner join customer
on  salesman.city = customer.city
 
--write a SQL query to find those orders where order amount exists between 500 and 2000. Return ord_no, purch_amt, cust_name, city
select * from orders
select * from customer

select orders.ord_no, orders.purch_amt, customer.cust_name, customer.city
from orders inner join customer
on orders.customer_id = customer.customer_id 
where orders.purch_amt between 500 and 2000 

--write a SQL query to find the salesperson(s) and the customer(s) he handle. Return Customer Name, city, Salesman, commission
select customer.cust_name, customer.city, salesman.name as salesman , salesman.commission
from customer inner join salesman
on customer.salesman_id = salesman.salesman_id

--write a SQL query to find those salespersons who received a commission from the company more than 12%. Return Customer Name, customer city, Salesman, commission.
select customer.cust_name, customer.city,salesman.name as salesman, salesman.commission
from customer inner join salesman
on customer.salesman_id = salesman.salesman_id
where salesman.commission > 0.12

--write a SQL query to find those salespersons do not live in the same city where their customers live and received a commission from the company more than 12%. 
--Return Customer Name, customer city, Salesman, salesman city, commission.
select * from salesman
select * from customer

select customer.cust_name, customer.city, salesman.name as salesman, salesman.city, salesman.commission
from customer inner join salesman
on customer.salesman_id = salesman.salesman_id
where customer.city != salesman.city and salesman.commission > 0.12
