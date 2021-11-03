CREATE TABLE [dbo].[Partner]  
      (
            Id integer primary key identity(1,1),
            FirstName nvarchar(255) not null,
            LastName nvarchar(255) not null,
            Adress nvarchar,
            PartnerNumber int(20) not null,
            CroatianPIN int,
            PartnerTypeId int(1) not null,
            CreatedAtUtc datetime default current_timestamp,
            CreateByUser nvarchar(255),
            IsForeign bool not null,
            ExternalCode nvarchar(20) unique,
            Gender int(1) not null
      )