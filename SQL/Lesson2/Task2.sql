INSERT INTO Product
(Name, ProductNumber, Cost, Count, SellStartDate)
VALUES
('Корона', 'AK-53818', '5$', '50', '08/15/2011'), 
('Милка', 'AM-51122', '5$', '50', '08/15/2011'),
('Аленка', 'AA-52211', '5$', '50', '08/15/2011'),
('Snickers', 'BS-32118', '5$', '50', '08/15/2011'),
('Snickers', 'BSL-3818', '5$', '50', '08/15/2011'),
('Bounty', 'BB-38218', '5$', '50', '08/15/2011'),
('Nuts', 'BN-37818', '5$', '50', '08/15/2011'),
('Mars', 'BM-3618', '5$', '50', '08/15/2011'),
('Свиточ', 'AS-54181', '5$', '50', '08/15/2011'),
('Свиточ', 'AS-54182', '5$', '50', '08/15/2011');
GO

SELECT * FROM Product

UPDATE Product
SET Cost = '6.35',
	SellStartDate = '07/15/2011'
WHERE Name = 'Милка'
GO

SELECT * FROM Product
WHERE Count < 59;

SELECT * FROM Product
WHERE SellStartDate > '2011-08-01'

