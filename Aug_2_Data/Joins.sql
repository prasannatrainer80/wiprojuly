select Employ.Empno, Name, Dept, Basic, 
LeaveHistory.LeaveId, LeaveStartDate, LeaveEndDate
from Employ INNER JOIN LeaveHistory 
ON Employ.Empno = LeaveHistory.EmpNo

select E.Empno, Name, Dept, Basic, 
LH.LeaveId, LeaveStartDate, LeaveEndDate
from Employ E INNER JOIN LeaveHistory LH 
ON E.Empno = Lh.EmpNo

select A.AgentId, FirstName, LastName, City, State,
P.PolicyId, AppNumber, ModalPremium, AnnualPremium, PaymentModeId
from Agent A INNER JOIN AgentPolicy AP ON 
A.AgentId = AP.AgentID 
INNER JOIN Policy P ON P.PolicyId = AP.PolicyID

-- Example for Left-Outer Join 


select E.Empno, Name, Dept, Basic, 
LH.LeaveId, LeaveStartDate, LeaveEndDate
from Employ E LEFT JOIN LeaveHistory LH 
ON E.Empno = Lh.EmpNo

select A.AgentId, FirstName, LastName, City, State,
P.PolicyId, AppNumber, ModalPremium, AnnualPremium, PaymentModeId
from Agent A LEFT JOIN AgentPolicy AP ON 
A.AgentId = AP.AgentID 
LEFT JOIN Policy P ON P.PolicyId = AP.PolicyID

-- Example for Right-Outer Join

select E.Empno, Name, Dept, Basic, 
LH.LeaveId, LeaveStartDate, LeaveEndDate
from Employ E RIGHT JOIN LeaveHistory LH 
ON E.Empno = Lh.EmpNo

select A.AgentId, FirstName, LastName, City, State,
P.PolicyId, AppNumber, ModalPremium, AnnualPremium, PaymentModeId
from Agent A RIGHT JOIN AgentPolicy AP ON 
A.AgentId = AP.AgentID 
RIGHT JOIN Policy P ON P.PolicyId = AP.PolicyID

-- Example for Full outer Join

select A.AgentId, FirstName, LastName, City, State,
P.PolicyId, AppNumber, ModalPremium, AnnualPremium, PaymentModeId
from Agent A FULL JOIN AgentPolicy AP ON 
A.AgentId = AP.AgentID 
FULL JOIN Policy P ON P.PolicyId = AP.PolicyID


-- Cross Join 

select * from Agent cross join AgentPolicy

select * from Policy Cross Join AgentPolicy

