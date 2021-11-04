CREATE DATABASE PHARMACY

CREATE TABLE users(
id int identity(1,1) primary key,
userrole varchar(50) not null,
fullname varchar(50) not null,
phno bigint unique not null,
emailid varchar(50),
username varchar(50) unique not null,
pass varchar(50) not null
)

select userrole,fullname,phno,emailid,username from users
select * from users
desc users

userrole, fullname, phno, emailid, username, pass


delete  from users

drop table users

CREATE TABLE meds(
id int identity(1,1) primary key,
medid varchar(50) not null,
medname varchar(50) not null,
compname varchar(50) not null,
mfgdate date not null, 
expdate date not null,
quantity bigint not null,
priceperunit decimal(10,2) not null
)

select * from meds



drop table meds

medid,medname,compname,mfgdate,expdate,quantity,priceperunit

create table patients(
id int identity(1,1) primary key,
consultantname varchar(50),
patientname varchar(50) not null,
phnno bigint,
totalprice decimal(10,2) not null,
discount decimal(3,0),
netamount decimal(10,2),
purchasedate varchar(50) not null,
purchasetime varchar(50) not null
)

select * from patients

drop table patients

consultantname,patientname,phnno,medname,quantity,totalprice,purchasedate,purchasetime


create table sellmed(
id int identity(1,1) not null,
medid varchar(50) not null,
medname varchar(50) not null,
priceperunit decimal(10,2) not null,
quantity varchar(10) not null,
totalprice decimal(10,2) not null
)


select * from sellmed

drop table sellmed

medid,medname,expdate,quantity,priceperunit,totalprice