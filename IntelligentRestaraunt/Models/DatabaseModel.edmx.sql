
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/07/2021 14:26:26
-- Generated from EDMX file: C:\Users\Eric\RiderProjects\IntelligentRestaraunt\IntelligentRestaraunt\Models\DatabaseModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Restaurant];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CategoryProduct]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Products] DROP CONSTRAINT [FK_CategoryProduct];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemOrderProduct]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Products] DROP CONSTRAINT [FK_ItemOrderProduct];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Products];
GO
IF OBJECT_ID(N'[dbo].[Categories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categories];
GO
IF OBJECT_ID(N'[dbo].[ItemOrders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItemOrders];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [productID] int IDENTITY(1,1) NOT NULL,
    [productName] nvarchar(50)  NOT NULL,
    [productDescription] nvarchar(150)  NULL,
    [productPrice] int  NOT NULL,
    [categoryID] int  NOT NULL,
    [ItemOrderId] int  NOT NULL
);
GO

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
    [categoryID] int IDENTITY(1,1) NOT NULL,
    [categoryName] nvarchar(50)  NULL
);
GO

-- Creating table 'ItemOrders'
CREATE TABLE [dbo].[ItemOrders] (
    [ItemOrderId] int IDENTITY(1,1) NOT NULL,
    [productID] int  NOT NULL,
    [productName] nvarchar(max)  NOT NULL,
    [productPrice] int  NOT NULL,
    [categoryID] int  NOT NULL,
    [quantity] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [productID] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([productID] ASC);
GO

-- Creating primary key on [categoryID] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([categoryID] ASC);
GO

-- Creating primary key on [ItemOrderId] in table 'ItemOrders'
ALTER TABLE [dbo].[ItemOrders]
ADD CONSTRAINT [PK_ItemOrders]
    PRIMARY KEY CLUSTERED ([ItemOrderId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [categoryID] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_CategoryProduct]
    FOREIGN KEY ([categoryID])
    REFERENCES [dbo].[Categories]
        ([categoryID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoryProduct'
CREATE INDEX [IX_FK_CategoryProduct]
ON [dbo].[Products]
    ([categoryID]);
GO

-- Creating foreign key on [ItemOrderId] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_ItemOrderProduct]
    FOREIGN KEY ([ItemOrderId])
    REFERENCES [dbo].[ItemOrders]
        ([ItemOrderId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemOrderProduct'
CREATE INDEX [IX_FK_ItemOrderProduct]
ON [dbo].[Products]
    ([ItemOrderId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------