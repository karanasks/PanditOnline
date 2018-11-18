Create Database [EPandit]
GO

USE [EPandit];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'MeasurementUnitMaster'
CREATE TABLE [dbo].[MeasurementUnitMaster] (
    [MeasurementUnitMasterId] int IDENTITY(1,1) NOT NULL,
    [MeasuementUnit] nvarchar(30)  NOT NULL,
    [CreatedBy] int  NULL,
    [CreatedDate] datetime  NULL,
    [ModifiedBy] int  NULL,
    [ModifiedDate] datetime  NULL
);
GO

-- Creating table 'PanditDetail'
CREATE TABLE [dbo].[PanditDetail] (
    [PanditDetailId] int IDENTITY(1,1) NOT NULL,
    [UserMasterId] int  NOT NULL,
    [YearOfExperience] int  NULL,
    [PanditDescription] nvarchar(300)  NULL,
    [OrganisationName] nvarchar(30)  NULL,
    [CreatedBy] int  NULL,
    [CreatedDate] datetime  NULL,
    [ModifiedBy] int  NULL,
    [ModifiedDate] datetime  NULL
);
GO

-- Creating table 'PanditPoojaMapping'
CREATE TABLE [dbo].[PanditPoojaMapping] (
    [PanditPoojaMappingId] int IDENTITY(1,1) NOT NULL,
    [UserRoleId] int  NOT NULL,
    [PoojaMasterId] int  NOT NULL,
    [CreatedBy] int  NULL,
    [CreatedDate] datetime  NULL,
    [ModifiedBy] int  NULL,
    [ModifiedDate] datetime  NULL
);
GO

-- Creating table 'PoojaMaster'
CREATE TABLE [dbo].[PoojaMaster] (
    [PoojaMasterId] int IDENTITY(1,1) NOT NULL,
    [PoojaName] nvarchar(50)  NOT NULL,
    [PoojaDescription] nvarchar(300)  NULL,
    [CreatedBy] int  NULL,
    [CreatedDate] datetime  NULL,
    [ModifiedBy] int  NULL,
    [ModifiedDate] datetime  NULL
);
GO

-- Creating table 'PoojaSamagriMapping'
CREATE TABLE [dbo].[PoojaSamagriMapping] (
    [PoojaSamagriMappingId] int IDENTITY(1,1) NOT NULL,
    [PoojaMasterId] int  NOT NULL,
    [SamagriMasterId] int  NOT NULL,
    [Quantity] int  NOT NULL,
    [MeasurementUnitMasterId] int  NOT NULL,
    [CreatedBy] int  NULL,
    [CreatedDate] datetime  NULL,
    [ModifiedBy] int  NULL,
    [ModifiedDate] datetime  NULL
);
GO

-- Creating table 'SamagriMaster'
CREATE TABLE [dbo].[SamagriMaster] (
    [SamagriMasterId] int IDENTITY(1,1) NOT NULL,
    [SamagriName] nvarchar(50)  NOT NULL,
    [SamagriDescription] nvarchar(300)  NULL,
    [CreatedBy] int  NULL,
    [CreatedDate] datetime  NULL,
    [ModifiedBy] int  NULL,
    [ModifiedDate] datetime  NULL
);
GO

-- Creating table 'UserMaster'
CREATE TABLE [dbo].[UserMaster] (
    [UserMasterId] int IDENTITY(1,1) NOT NULL,
    [UserRoleId] int  NOT NULL,
    [FirstName] nvarchar(30)  NOT NULL,
    [LastName] nvarchar(30)  NULL,
    [LoginId] nvarchar(30)  NOT NULL,
    [EmailId] nvarchar(30)  NOT NULL,
    [MobileNumber] nvarchar(10)  NOT NULL,
    [WhatsappMobileNumber] nvarchar(10)  NULL,
    [AlternateMobileNumber1] nvarchar(10)  NULL,
    [AlternateMobileNumber2] nvarchar(10)  NULL,
    [AlternateMobileNumber3] nvarchar(10)  NULL,
    [Address] nvarchar(200)  NOT NULL,
    [HomeLongitude] nvarchar(20)  NOT NULL,
    [HomeLatitude] nvarchar(20)  NOT NULL,
    [DateOfBirth] datetime  NULL,
    [Password] nvarchar(20)  NOT NULL,
    [Image] nvarchar(max)  NULL,
    [City] nvarchar(50)  NULL,
    [State] nvarchar(50)  NULL,
    [PinCode] int  NOT NULL,
    [CreatedBy] int  NULL,
    [CreatedDate] datetime  NULL,
    [ModifiedBy] int  NULL,
    [ModifiedDate] datetime  NULL
);
GO

-- Creating table 'UserRole'
CREATE TABLE [dbo].[UserRole] (
    [UserRoleId] int IDENTITY(1,1) NOT NULL,
    [RoleName] nvarchar(20)  NOT NULL,
    [CreatedBy] int  NULL,
    [CreatedDate] datetime  NULL,
    [ModifiedBy] int  NULL,
    [ModifiedDate] datetime  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [MeasurementUnitMasterId] in table 'MeasurementUnitMaster'
ALTER TABLE [dbo].[MeasurementUnitMaster]
ADD CONSTRAINT [PK_MeasurementUnitMaster]
    PRIMARY KEY CLUSTERED ([MeasurementUnitMasterId] ASC);
GO

-- Creating primary key on [PanditDetailId] in table 'PanditDetail'
ALTER TABLE [dbo].[PanditDetail]
ADD CONSTRAINT [PK_PanditDetail]
    PRIMARY KEY CLUSTERED ([PanditDetailId] ASC);
GO

-- Creating primary key on [PanditPoojaMappingId] in table 'PanditPoojaMapping'
ALTER TABLE [dbo].[PanditPoojaMapping]
ADD CONSTRAINT [PK_PanditPoojaMapping]
    PRIMARY KEY CLUSTERED ([PanditPoojaMappingId] ASC);
GO

-- Creating primary key on [PoojaMasterId] in table 'PoojaMaster'
ALTER TABLE [dbo].[PoojaMaster]
ADD CONSTRAINT [PK_PoojaMaster]
    PRIMARY KEY CLUSTERED ([PoojaMasterId] ASC);
GO

-- Creating primary key on [PoojaSamagriMappingId] in table 'PoojaSamagriMapping'
ALTER TABLE [dbo].[PoojaSamagriMapping]
ADD CONSTRAINT [PK_PoojaSamagriMapping]
    PRIMARY KEY CLUSTERED ([PoojaSamagriMappingId] ASC);
GO

-- Creating primary key on [SamagriMasterId] in table 'SamagriMaster'
ALTER TABLE [dbo].[SamagriMaster]
ADD CONSTRAINT [PK_SamagriMaster]
    PRIMARY KEY CLUSTERED ([SamagriMasterId] ASC);
GO

-- Creating primary key on [UserMasterId] in table 'UserMaster'
ALTER TABLE [dbo].[UserMaster]
ADD CONSTRAINT [PK_UserMaster]
    PRIMARY KEY CLUSTERED ([UserMasterId] ASC);
GO

-- Creating primary key on [UserRoleId] in table 'UserRole'
ALTER TABLE [dbo].[UserRole]
ADD CONSTRAINT [PK_UserRole]
    PRIMARY KEY CLUSTERED ([UserRoleId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserRoleId] in table 'UserMaster'
ALTER TABLE [dbo].[UserMaster]
ADD CONSTRAINT [FK_RoleUser]
    FOREIGN KEY ([UserRoleId])
    REFERENCES [dbo].[UserRole]
        ([UserRoleId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RoleUser'
CREATE INDEX [IX_FK_RoleUser]
ON [dbo].[UserMaster]
    ([UserRoleId]);
GO