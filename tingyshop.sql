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