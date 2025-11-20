create database Library

create table NewBook(
bid int NOT NULL IDENTITY(1,1) primary key,
bName varchar(250) not null,
bAuthor varchar(250) not null,
bPubl varchar(250) not null,
bDate varchar(250) not null,
bPrice bigint not null,
bQuen bigint not null
)

bName,bAuthor,bPubl,bDate,bPrice,bQuen

select * from NewBook

create table AddStudent(
sid int NOT NULL IDENTITY (1,1) primary key,
sName varchar(150) not null,
dob varchar(150) not null,
RegNo varchar(150) not null,
pNum bigint not null,
email varchar(150) not null,
course varchar(150) not null
)

sName,dob,RegNo,pNum,email,course

select * from AddStudent

create table IssueBooks(
id int NOT NULL IDENTITY(1,1) primary key,
Rerister_no varchar(250) not null,
stu_name varchar(250) not null,
diploma varchar(250) not null,
phone_no bigint not null,
email varchar(250) not null,
book_name varchar(250) not null,
book_issue_date varchar(250) not null,
book_return_date varchar,
);

select * from IssueBooks

select * from IssueBooks where Rerister_no='1234' and book_return_date IS NULL