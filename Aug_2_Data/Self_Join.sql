SELECT TOP (1000) [EmpId]
      ,[EmployName]
      ,[MgrId]
      ,[LeaveAvail]
      ,[DateOfBirth]
      ,[Email]
      ,[Mobile]
  FROM [wiprojuly].[dbo].[Employee]


select E1.EmpId 'Manager Id',E1.EmployName 'Manager Name',
E2.EmpId 'Employee Id',E2.EmployName 'Employee Name'
from Employee E1 INNER JOIN Employee E2 ON 
E1.EmpId = E2.MgrId
GO


select E1.EmpId 'Manager Id',E1.EmployName 'Manager Name',
E2.EmpId 'Employee Id',E2.EmployName 'Employee Name'
from Employee E1 RIGHT JOIN Employee E2 ON 
E1.EmpId = E2.MgrId
GO

