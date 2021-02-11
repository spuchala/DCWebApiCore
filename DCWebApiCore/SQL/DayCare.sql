
-- day care table
create table 
DayCare 
(DayCareId uniqueidentifier default newsequentialid() not null,
 DayCareName nvarchar(200) not null,
 [Address] nvarchar(500) not null,
 Phone nvarchar(20) not null,
 AdminName nvarchar(100) not null,
 Email nvarchar(200) not null,
 [Password] nvarchar(20) not null,
 DateCreated datetime not null,
 DateModified datetime null default null,
 Source varchar(20) null default null,
 DayCareUniqueName nvarchar(400) not null,
 CONSTRAINT DayCare_Id PRIMARY KEY (DayCareId)
 )