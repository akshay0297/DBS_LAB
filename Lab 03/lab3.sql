create table person
	(
		driverid int,
		name varchar(20),
		address varchar(20),
		primary key(driverid)
		
	);


create table car
	(
		regno int ,
		model varchar(20),
		year int,
		primary key(regno)
	);
create table accident
	(
		report_num int,
		acci_date date,
		location varchar(20),
		primary key(report_num)
	);
create table owns
	(
		driverid int,
		regno int,
		foreign key (regno) references car(regno) on delete cascade,
		foreign key (driverid) references person(driverid) on delete cascade,
		primary key (driverid , regno) 
		
	);

create table parti
	(
		driverid int, 
		regno int , 
		report_num int,
		dam_amt int,
		foreign key(driverid) references person(driverid) on delete cascade,  
		foreign key (regno) references car(regno) on delete cascade ,
		foreign key (report_num) references accident(report_num) on delete cascade,
		primary key(driverid , regno , report_num)  

	);

commit;