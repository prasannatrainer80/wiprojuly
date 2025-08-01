-- Group By : Display summary result w.r.t field specified 

select dept, sum(basic) from Emp 
group by dept;

select gender,count(*)
from Agent  group by gender;

select dept, avg(basic) from Emp 
Group by Dept; 

select dept, sum(basic) 'Total',avg(basic) 'Average',
max(basic) 'Max Basic', min(basic) 'Min Basic', count(*) 'Total Records'
from Emp 
group by Dept; 

-- Having clause : Used to display aggregate conditions 

select dept, sum(basic) 'Total',avg(basic) 'Average',
max(basic) 'Max Basic', min(basic) 'Min Basic', count(*) 'Total Records'
from Emp 
group by Dept having count(*) > 1; 

select dept, sum(basic) from Emp 
group by dept 
having sum(basic) > 50000;

