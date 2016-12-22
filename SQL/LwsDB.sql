CREATE DATABASE LwsDB ON							  
(
	NAME = 'LwsDB',            
	FILENAME = 'C:\Database\DATA\LwsDB.mdf', 
	SIZE = 10MB,                    
	MAXSIZE = 200MB,				
	FILEGROWTH = 10MB				
)
LOG ON						  
( 
	NAME = 'LogLwsDB',            
	FILENAME = 'C:\Database\LOG\LWS.ldf', 
	SIZE = 5MB,                        
	MAXSIZE = 50MB,                    
	FILEGROWTH = 5MB                   
)   
COLLATE Cyrillic_General_CI_AS
GO

USE LwsDB

--SELECT CURRENT_TIMESTAMP
--SELECT DATEADD(HOUR,12,CURRENT_TIMESTAMP)