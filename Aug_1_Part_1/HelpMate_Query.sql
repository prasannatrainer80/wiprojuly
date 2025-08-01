	select 
	dateadd(dd,1,dateadd(mm,-1,DATEADD(SS,-1,DATEADD(mm, DATEDIFF(mm,0,DATEADD(MM,1,GETDATE())),0)))) 

	select datepart(dw,dateadd(dd,1,dateadd(mm,-1,DATEADD(SS,-1,DATEADD(mm, DATEDIFF(mm,0,DATEADD(MM,1,GETDATE())),0))))) 

	select dateadd(dd,
	6-datepart(dw,dateadd(dd,1,dateadd(mm,-1,DATEADD(SS,-1,DATEADD(mm, DATEDIFF(mm,0,DATEADD(MM,1,GETDATE())),0)))))
	,
	dateadd(dd,1,dateadd(mm,-1,DATEADD(SS,-1,DATEADD(mm, DATEDIFF(mm,0,DATEADD(MM,1,GETDATE())),0)))))