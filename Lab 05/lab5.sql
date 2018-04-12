create table student3110
	(
		regno int ,
		name varchar(10),
		major varchar(10),
		dob date,
		primary key(regno)
	);


create table curs3110
	(
		courseid int ,
		cname varchar(10),
		dept varchar(15),
		primary key(courseid)
	);
create table text3110
	(
		bookid int,
		title varchar(10),
		publisher varchar(10),
		author varchar(10),
		primary key(bookid)
	);
create table enroll3110
	(
		regno int,
		courseid int,
		sem int,
		bookid int,
		foreign key (regno) references student3110(regno),
		foreign key (courseid) references curs3110(courseid),
		foreign key (bookid) references text3110(bookid),
		primary key(regno , courseid)
	);

create table bok3110
	(
		courseid int, 
		sem int , 
		bookid int,
		foreign key(bookid) references text3110(bookid),
		foreign key (courseid) references curs3110(courseid),
		primary key(bookid , courseid)
	);

commit;