--Select
--ANSI
--Case Insensitive
select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers

select * from Customers where City = 'Paris'

select * from Products where CategoryID = 1 or CategoryID = 3

select * from Products where CategoryID = 1 or UnitPrice>=10

select * from Products order by UnitPrice desc --default: (a)rtan: ascending  --(d)üşen: descending 

select * from Products where CategoryID=1 order by UnitPrice desc

select CategoryID, count(*) Adet from Products
Where UnitPrice > 20
Group by CategoryID
Having count(*) < 10

--Inner join sadece iki tabloda eşleşen dataları getirir
select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products
inner join Categories on Products.CategoryID = Categories.CategoryID
where UnitPrice>10

--DTO: Data Transformation Object

--yazıma göre sol tablodakinde olup sağ tabloda olmayanları getir
select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is NULL

select * from Customers