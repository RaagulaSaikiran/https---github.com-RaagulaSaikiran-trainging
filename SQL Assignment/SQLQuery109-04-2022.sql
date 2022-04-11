use weare_pvtltd


use ABC


ALTER TABLE Customer
ALTER COLUMN FirstName varchar(20) not null;

ALTER TABLE orders
ALTER COLUMN OrderDate Datetime not null;

select * from Customer

SELECT Country
FROM Customer
WHERE FirstName  LIKE 'a%' or 'i%';


SELECT FirstName
FROM Customer
WHERE FirstName  LIKE '__i%';


select * from Customer
select * from OrderItem
select * from orders
select * from Product

ALTER TABLE Customer
ALTER COLUMN FirstName varchar(20) not null;

CREATE INDEX IndexOrderCustomerid on orders(id);
CREATE INDEX  IndexOrderOrderDate on orders(OrderDate);

CREATE INDEX IndexProductSuplierId on Customer(id);
CREATE INDEX IndexProductName on Product(ProductName);



CREATE INDEX  IndexOrderidemid on OrderItem(id);
CREATE INDEX   IndexProductId on OrderItem(ProductId);



CREATE INDEX IndexCustomerName on  Customer(FirstName,LastName);