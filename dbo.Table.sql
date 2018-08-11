CREATE TABLE [dbo].[Student]
(
	[First Name] VARCHAR(50) NOT NULL , 
    [Middle Name] VARCHAR(50) NOT NULL, 
    [Last Name] VARBINARY(50) NOT NULL, 
    [Enrollment No] VARCHAR(50) NOT NULL, 
    [Branch] VARCHAR(50) NOT NULL, 
    [Semester] VARCHAR(50) NOT NULL, 
    [CPI] VARBINARY(50) NOT NULL, 
    [SPI] VARCHAR(50) NOT NULL, 
    [Percentage] VARCHAR(50) NOT NULL, 
    [Contect] VARCHAR(50) NOT NULL, 
    [Address] VARBINARY(100) NOT NULL, 
    [Pic] IMAGE NOT NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([Enrollment No])
)
