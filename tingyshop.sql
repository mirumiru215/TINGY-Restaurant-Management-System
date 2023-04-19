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
