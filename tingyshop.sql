create database tingyshop

create table newTingy(
mid int NOT NULL IDENTITY(1,1) primary key,
cname varchar(250) not null,
ntype varchar(250) not null,
ingredient varchar(250) not null,
stime varchar(250) not null,
sdishes varchar(250) not null,
price bigint not null
);

select * from newTingy
GO
