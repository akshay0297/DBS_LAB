/* Q1 */
select 'Q1';
select cname from curs3110 
where courseid in (select courseid from bok3110 group by (courseid) having count(courseid) > 1);

/* Q2 */
select 'Q2';
select distinct dept from curs3110 where courseid in (select courseid from bok3110 where 
bookid in (select bookid from text3110 where publisher = 'ee'));

/* Q3 */
select 'Q3';
select name from student3110 natural join enroll3110 natural join curs3110 group by regno having count(*)>1; 


/* Q4 */
select 'Q4';
select regno from student3110 where student3110.regno not in (select regno from enroll3110);

/* Q5 */
select 'Q5';
 select cname from curs3110 natural join bok3110 natural join text3110 group by courseid having count(publisher) > 1;

 /* Q6 */
select 'Q6';
 select bookid from enroll3110 natural join bok3110 where bookid in (select bookid from bok3110);

 /* Q7 */
select 'Q7';
 /* Q8 */
select 'Q8';
  select name from student3110 natural join enroll3110 group by regno having count(*) in (select max(y.n) from (select count(*) as n from enroll3110 group by (bookid)) y);

 /* Q9 */
select 'Q9';
 select publisher , count(bookid) from  text3110 group by publisher ; 

 /* Q10 */
select 'Q10';
 select distinct name from student3110 natural join enroll3110 natural join bok3110 where enroll3110.courseid = bok3110.courseid ; 

 /* */