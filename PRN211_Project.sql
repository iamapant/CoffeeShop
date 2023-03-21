create database CoffeeShop;

--drop database CoffeeShop

use CoffeeShop;

create table Users(
	id int identity(1,1) primary key,
	[name] nvarchar(40) not null unique,
	email nvarchar(40) not null unique,
	pass nvarchar(40) not null
);

create table Item(
	id int identity(1,1) primary key,
	[name] nvarchar(40) not null unique,
	descr nvarchar(200),
	[type] nvarchar(40),
	price money default 0 not null,
	stock int default 1 not null
);

create table Cart(
	[uid] int references Users(id) on delete cascade,
	iid int references Item(id) on delete cascade,
	amount int default 1 not null,
	added_price money default 0,
	note nvarchar(500) default ''
);

create table Orders(
	oid int identity(1,1) primary key,
	[uid] int references Users(id) on delete cascade,
	phone int check (phone between 0 and 9999999999),
	[address] nvarchar(100),
	odate date default getdate(),
	total money default 0 not null
);

create table OrderDetails(
	oid int references Orders(oid) on delete cascade,
	iid int references Item(id),
	amount int default 1 not null,
	note nvarchar(500) default '',
	OrderDate Datetime default getdate()
);

create table ShippingInfo(
	id int primary key references Users(id) on delete cascade,
	phone int check (phone between 0 and 9999999999),
	address1 nvarchar(100),
	address2 nvarchar(100)
);

------------------------------DELETE STUFFS-------------------------------------------------------------------


/*
drop table ShippingInfo,OrderDetails,Orders,Cart,Item,Users

drop proc delete_Cart,changeStock_Item,insert_Order,insert_Cart

delete from Users
delete from Item
delete from Cart
delete from Orders
delete from OrderDetails
*/



------------------------------VIEW TABLES----------------------------------------------------------------------


select * from Users
select * from Item
select * from Cart
select * from Orders
select * from OrderDetails



-------------------TEST VALUES---------------------------------------------------------------------------------


insert into Users([name],email,pass) values
	('a','a','a'),('b','b','b')
insert into Item(name,stock,price) values
	('a',999,2),('b',999,3),('c',999,4)
exec insert_Cart @uid = 1,@iid = 2
exec insert_Cart @uid = 1,@iid = 3,@add = 4
exec insert_Cart @uid = 2,@iid = 1
exec insert_Cart @uid = 2,@iid = 1, @price = -3


exec insert_Order @uid = 2,@phone = 0111111111, @address = 'a'

exec delete_Cart @uid = 1,@iid = 3

select sum(price*amount) from Item, Cart where uid = 1 and id = iid

--3 16 8 = 21
select * from cart where uid = 2


-------------------------------STORED PROCEDURES------------------------------------------------------------

--     INSERT ORDER    ------------

go
create proc insert_Order @uid int,@phone int, @address nvarchar(100)
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
go

--drop proc insert_Order

--      INSERT CART     ----------------

go
create proc insert_Cart @uid int, @iid int, @add int = null,@note nvarchar(500) = null, @price money = null
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
go

--drop proc insert_Cart

--      DELETE CART            --------------------------

go
create proc delete_Cart @uid int, @iid int, @sub int = null, @note nvarchar(500) = null
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
go


--        CHANGE STOCK      ------------------------------

go
create proc changeStock_Item @iid int, @amount int, @isAdd bit = 1
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
go

--drop proc changeStock_Item



-------------------------------------------------------------------
/*
------------- TEST INSERT CART---------------------

exec insert_Order @uid = 1

select * from Cart

select * from Orders

select * from OrderDetails

drop proc insert_Order

-----------TEST INSERT CART-------------------------

exec insert_Cart @x = 1, @y = 1
exec insert_Cart @x = 1, @y = 1,@v = 'allon-y'


exec insert_Cart @x = 1, @y = 1,@z = 999,@v = 'allon-y'

select * from Cart

drop proc insert_Cart

-----------------TEST DELETE CART---------------------------------

exec delete_Cart @x = 1, @y = 1,@z = 1

select * from Item

drop proc delete_Cart

------------------TEST CHANGE STOCK----------------------------

exec changeStock_Item @x = 1, @y = 9999, @z = 0

drop proc changeStock_Item
*/



-----------------------------TRIGGERS--------------------------------------------------------------------










