-- Display matching records from Employ and LeaveHistory table 

select * from Employ where Empno = ANY(select Empno from LeaveHistory)
GO

-- Display matching records from Agent and AgentPolicy Tables 

select * from Agent WHERE AgentId = ANY(select AgentId from AgentPolicy) 

-- Display Matching records from Policy and AgentPolicy Tables 

select * from Policy WHERE PolicyId = ANY (select PolicyId from AgentPolicy) 
GO

-- Display Employ Details who are not taken Leave (Means records which are in Employ table, but not in
-- LeaveHistory Table)

select * from Employ WHERE Empno <> ALL(select Empno from LeaveHistory) 
GO

-- Display Idle Agents (AgentId Exists in Agent Table, but not in AgentPolicy Table) 

select * from Agent where AgentId <> ALL(select AgentId from AgentPolicy) 
GO

-- Display Idle Policies (PolicyId exists in Policy Table, but not in AgentPolicy Table) 

select * from Policy WHERE PolicyId <> ALL(select PolicyId from AgentPolicy) 
GO

