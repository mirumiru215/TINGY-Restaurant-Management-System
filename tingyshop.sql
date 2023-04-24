create database tingyshop

create table dishDetails(
mid int NOT NULL IDENTITY(1,1) primary key,
cname varchar(250) not null,
ntype varchar(250) not null,
ingredient varchar(250) not null,
stime varchar(250) not null,
price bigint not null,
picture image not null
);

select * from dishDetails
GO

create table TableBill1(
table1id int NOT NULL IDENTITY(1,1) primary key,
dname varchar(250) not null,
amount bigint not null,
price bigint not null,
dprice bigint not null
);

select * from TableBill1
GO

create table TableBill2(
table2id int NOT NULL IDENTITY(1,1) primary key,
dname varchar(250) not null,
amount bigint not null,
price bigint not null,
dprice bigint not null
);

select * from TableBill2
GO

create table TableBill3(
table3id int NOT NULL IDENTITY(1,1) primary key,
dname varchar(250) not null,
amount bigint not null,
price bigint not null,
dprice bigint not null
);

select * from TableBill3
GO

create table TableBill4(
table4id int NOT NULL IDENTITY(1,1) primary key,
dname varchar(250) not null,
amount bigint not null,
price bigint not null,
dprice bigint not null
);

select * from TableBill4
GO

create table TableBill5(
table5id int NOT NULL IDENTITY(1,1) primary key,
dname varchar(250) not null,
amount bigint not null,
price bigint not null,
dprice bigint not null
);

select * from TableBill5
GO

create table TableBill6(
table6id int NOT NULL IDENTITY(1,1) primary key,
dname varchar(250) not null,
amount bigint not null,
price bigint not null,
dprice bigint not null
);

select * from TableBill6
GO

create table staffDetails(
staffid int NOT NULL IDENTITY(1,1) primary key,
sname varchar(250) not null,
dom varchar(250) not null,
phonenum varchar(250) not null,
position varchar(250) not null,
workcount bigint not null,
salary bigint not null,
picture image not null
);

create table statisticBill(
billid int NOT NULL IDENTITY(1,1) primary key,
tablenumber bigint not null,
totalprice bigint not null,
ngay bigint not null,
thang bigint not null,
nam bigint not null
);

select * from statisticBill
GO