INSERT INTO Product
(Name, ProductNumber, Cost, Count, SellStartDate)
VALUES
('������', 'AK-53818', '5$', '50', '08/15/2011'), 
('�����', 'AM-51122', '5$', '50', '08/15/2011'),
('������', 'AA-52211', '5$', '50', '08/15/2011'),
('Snickers', 'BS-32118', '5$', '50', '08/15/2011'),
('Snickers', 'BSL-3818', '5$', '50', '08/15/2011'),
('Bounty', 'BB-38218', '5$', '50', '08/15/2011'),
('Nuts', 'BN-37818', '5$', '50', '08/15/2011'),
('Mars', 'BM-3618', '5$', '50', '08/15/2011'),
('������', 'AS-54181', '5$', '50', '08/15/2011'),
('������', 'AS-54182', '5$', '50', '08/15/2011');
GO

SELECT * FROM Product

UPDATE Product
SET Cost = '6.35',
	SellStartDate = '07/15/2011'
WHERE Name = '�����'
GO

SELECT * FROM Product
WHERE Count < 59;

SELECT * FROM Product
WHERE SellStartDate > '2011-08-01'

