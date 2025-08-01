select * from Agent
GO

select AgentID, FirstName, LastName, City,MaritalStatus
from Agent 
GO

-- Write a query ensure, if MaritalStatus is 0 THEN 'Unmarried' if MartialStatus is '1' then Married 

select AgentID, FirstName, LastName, City, MaritalStatus,
Case MaritalStatus 
	WHEN 0 THEN 'Unmarried'
	WHEN 1 THEN 'Married'
END 'Marital Status'
from Agent
GO

select * from Policy
GO

select PolicyID, AppNumber, PolicyNumber, AnnualPremium, PaymentModeID,
CASE PaymentModeID
	WHEN 1 THEN 'Yearly'
	WHEN 2 THEN 'Half-Yearly'
	WHEN 3 THEN 'Quarterly'
END 'PayMode'
from Policy
GO
