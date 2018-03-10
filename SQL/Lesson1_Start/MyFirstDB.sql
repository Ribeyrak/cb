
CREATE DATABASE MyDB  
ON						
(
	NAME = 'MyDB',				
	FILENAME = 'Z:\repos\SQL\Lesson1_Start\MyDB.mdf',
	SIZE = 10MB,                 
	MAXSIZE = 100MB,			
	FILEGROWTH = 10MB				
)
LOG ON						
( 
	NAME = 'LogMyDB',				 
	FILENAME = 'Z:\repos\SQL\Lesson1_Start\MyDB.ldf',
	SIZE = 5MB,                       
	MAXSIZE = 50MB,                    
	FILEGROWTH = 5MB                   
)               
COLLATE Cyrillic_General_CI_AS -- «адаем кодировку дл€ базы данных по умолчанию


EXECUTE sp_helpdb MyDB;


USE MyDB                
GO   

----------------------------------------------------------------------------------

-- 1-€ содержит имена и номера телефонов сотрудников некой компании,
-- 2-€ содержит ведомости об их зарплате, и должност€х,
-- .3-€ содержит информацию о семейном положении, дате рождени€ и месте проживани€.

CREATE TABLE Worker
(
	--  лючевое слово IDENTITY задает начальное значение и устанавливает авто инкремент.
	-- ѕо умолчанию значение первой €чейки равно 1 и с каждой новой записью увеличиваетс€ на 1.
	WorkerId smallint IDENTITY NOT NULL,
	FirstName Varchar(20) NOT NULL,
	PhoneNumber char(10) NOT NULL
)
CREATE TABLE Position
(
	PositionID smallint IDENTITY NOT NULL,
	Position varchar(15) NOT NULL,
	Z_p Varchar(20) NULL,
)

CREATE TABLE Info
(
InfoID smallint IDENTITY NOT NULL,
Married char(10) NOT NULL,
BirthDate date NULL,
)
GO 

