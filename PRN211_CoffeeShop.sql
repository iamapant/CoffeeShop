USE [master]
GO
/****** Object:  Database [CoffeeShop]    Script Date: 22/3/2023 12:40:14 am ******/
CREATE DATABASE [CoffeeShop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CoffeeShop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLSERVER\MSSQL\DATA\CoffeeShop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CoffeeShop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLSERVER\MSSQL\DATA\CoffeeShop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [CoffeeShop] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CoffeeShop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CoffeeShop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CoffeeShop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CoffeeShop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CoffeeShop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CoffeeShop] SET ARITHABORT OFF 
GO
ALTER DATABASE [CoffeeShop] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [CoffeeShop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CoffeeShop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CoffeeShop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CoffeeShop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CoffeeShop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CoffeeShop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CoffeeShop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CoffeeShop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CoffeeShop] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CoffeeShop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CoffeeShop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CoffeeShop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CoffeeShop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CoffeeShop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CoffeeShop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CoffeeShop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CoffeeShop] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CoffeeShop] SET  MULTI_USER 
GO
ALTER DATABASE [CoffeeShop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CoffeeShop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CoffeeShop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CoffeeShop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CoffeeShop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CoffeeShop] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CoffeeShop] SET QUERY_STORE = ON
GO
ALTER DATABASE [CoffeeShop] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [CoffeeShop]
GO
/****** Object:  Table [dbo].[Cart]    Script Date: 22/3/2023 12:40:14 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cart](
	[uid] [int] NULL,
	[iid] [int] NULL,
	[amount] [int] NOT NULL,
	[added_price] [money] NULL,
	[note] [nvarchar](500) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 22/3/2023 12:40:14 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](40) NOT NULL,
	[descr] [nvarchar](200) NULL,
	[type] [nvarchar](40) NULL,
	[price] [money] NOT NULL,
	[stock] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 22/3/2023 12:40:14 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[oid] [int] NULL,
	[iid] [int] NULL,
	[amount] [int] NOT NULL,
	[note] [nvarchar](500) NULL,
	[OrderDate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 22/3/2023 12:40:14 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[oid] [int] IDENTITY(1,1) NOT NULL,
	[uid] [int] NULL,
	[phone] [int] NULL,
	[address] [nvarchar](100) NULL,
	[odate] [date] NULL,
	[total] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[oid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShippingInfo]    Script Date: 22/3/2023 12:40:14 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShippingInfo](
	[id] [int] NOT NULL,
	[phone] [int] NULL,
	[address1] [nvarchar](100) NULL,
	[address2] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 22/3/2023 12:40:14 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](40) NOT NULL,
	[email] [nvarchar](40) NOT NULL,
	[pass] [nvarchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cart] ADD  DEFAULT ((1)) FOR [amount]
GO
ALTER TABLE [dbo].[Cart] ADD  DEFAULT ((0)) FOR [added_price]
GO
ALTER TABLE [dbo].[Cart] ADD  DEFAULT ('') FOR [note]
GO
ALTER TABLE [dbo].[Item] ADD  DEFAULT ((0)) FOR [price]
GO
ALTER TABLE [dbo].[Item] ADD  DEFAULT ((1)) FOR [stock]
GO
ALTER TABLE [dbo].[OrderDetails] ADD  DEFAULT ((1)) FOR [amount]
GO
ALTER TABLE [dbo].[OrderDetails] ADD  DEFAULT ('') FOR [note]
GO
ALTER TABLE [dbo].[OrderDetails] ADD  DEFAULT (getdate()) FOR [OrderDate]
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT (getdate()) FOR [odate]
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT ((0)) FOR [total]
GO
ALTER TABLE [dbo].[Cart]  WITH CHECK ADD FOREIGN KEY([iid])
REFERENCES [dbo].[Item] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cart]  WITH CHECK ADD FOREIGN KEY([uid])
REFERENCES [dbo].[Users] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD FOREIGN KEY([iid])
REFERENCES [dbo].[Item] ([id])
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD FOREIGN KEY([oid])
REFERENCES [dbo].[Orders] ([oid])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([uid])
REFERENCES [dbo].[Users] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ShippingInfo]  WITH CHECK ADD FOREIGN KEY([id])
REFERENCES [dbo].[Users] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD CHECK  (([phone]>=(0) AND [phone]<=(9999999999.)))
GO
ALTER TABLE [dbo].[ShippingInfo]  WITH CHECK ADD CHECK  (([phone]>=(0) AND [phone]<=(9999999999.)))
GO
/****** Object:  StoredProcedure [dbo].[changeStock_Item]    Script Date: 22/3/2023 12:40:14 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[changeStock_Item] @iid int, @amount int, @isAdd bit = 1
as
	if exists (select * from Item where id = @iid)
		begin
		if @isAdd = 1
			begin
			update Item set stock = stock + @amount where id = @iid
				select @iid
			end
		else
			begin
			if (select sum(stock) from Item where id = @iid ) < @amount
			return
			else
				begin
				update Item set stock = stock - @amount where id = @iid
				select @iid
				end
			end
		end
GO
/****** Object:  StoredProcedure [dbo].[delete_Cart]    Script Date: 22/3/2023 12:40:14 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[delete_Cart] @uid int, @iid int, @sub int = null, @note nvarchar(500) = null
as
	if @sub is null begin set @sub = 1 end
	if @note is null begin set @note = '' end
	if exists (select * from Cart where uid = @uid and iid = @iid and (note = @note) )
		begin
		if (select sum(amount) from Cart where uid = @uid and iid = @iid and (note = @note) ) <= @sub
			begin
			delete from Cart where uid = @uid and iid = @iid and (note = @note) 
			update Item set stock = stock + @sub where id = @iid
			select @iid
			end
		else 
			begin
			update Cart set amount = amount - @sub where uid = @uid and iid = @iid and (note = @note) 
			update Item set stock = stock + @sub where id = @iid
			select @iid
			end
		end
GO
/****** Object:  StoredProcedure [dbo].[insert_Cart]    Script Date: 22/3/2023 12:40:14 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insert_Cart] @uid int, @iid int, @add int = null,@note nvarchar(500) = null, @price money = null
as
	if @add is null begin set @add = 1 end
	if @price is null begin set @price = 0 end
	if @note is null begin set @note = '' end
	declare @stock int
	set @stock = (select isnull(sum(stock),0) from Item where id = @iid)
	--set @amount = (select isnull(sum(amount),0) from Cart where uid = @uid and iid = @iid and (note = @note))
	if exists (select * from Cart where uid = @uid and iid = @iid and (note = @note) )
		begin
		if (@add) <= @stock
			begin
			update Item set stock = stock - @add where id = @iid
			update Cart set amount = amount+@add where uid = @uid and iid = @iid and(note = @note)
			if (@price is not null)
				begin
				update Cart set added_price = added_price + @price where uid = @uid and iid = @iid and(note = @note)
				end
			select @iid
			end
		end
	else
		begin
		if (@add) <= @stock
			begin
			update Item set stock = stock - @add where id = @iid
			if (@price is not null)
				begin
				insert into Cart(uid,iid,amount,added_price,note) values (@uid,@iid,@add,@price,@note)
				end
			select @iid
			end
		end
GO
/****** Object:  StoredProcedure [dbo].[insert_Order]    Script Date: 22/3/2023 12:40:14 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insert_Order] @uid int,@phone int, @address nvarchar(100)
as
	declare @temp table(oid int, uid int, iid int, amount int ,note nvarchar(500),od Datetime)
	declare @total money = (select sum(Item.price*amount) + sum(added_price*amount) from Item, Cart where uid = @uid and id = iid)
	declare @oid int
	insert into @temp(uid,iid,amount,note) select [uid],iid,amount,note from Cart where Cart.[uid] = @uid
	update @temp set od = getdate() from Cart where Cart.[uid] = @uid
	if (select count(*) from @temp) != 0
		insert into Orders(uid,total,phone,[address]) select @uid,@total,@phone,@address
		set @oid = (select isnull(max(Orders.oid),0) from Orders where Orders.uid = @uid) 
		update @temp set oid = @oid where uid = @uid
		insert into OrderDetails (oid,iid,amount,note,OrderDate) 
			select oid,iid,amount,note,od from @temp
		update Orders set total = @total where oid = @oid
		delete from Cart where Cart.[uid] = @uid
		select @oid
GO
USE [master]
GO
ALTER DATABASE [CoffeeShop] SET  READ_WRITE 
GO
