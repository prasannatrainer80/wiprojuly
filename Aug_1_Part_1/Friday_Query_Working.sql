
	select dateadd(dd,
	6-datepart(dw,dateadd(dd,1,dateadd(mm,-1,DATEADD(SS,-1,DATEADD(mm, DATEDIFF(mm,0,DATEADD(MM,1,GETDATE())),0)))))
	,
	dateadd(dd,1,dateadd(mm,-1,DATEADD(SS,-1,DATEADD(mm, DATEDIFF(mm,0,DATEADD(MM,1,GETDATE())),0)))))
	'First Friday',
	DATEADD(DD,7,
	dateadd(dd,
	6-datepart(dw,dateadd(dd,1,dateadd(mm,-1,DATEADD(SS,-1,DATEADD(mm, DATEDIFF(mm,0,DATEADD(MM,1,GETDATE())),0)))))
	,
	dateadd(dd,1,dateadd(mm,-1,DATEADD(SS,-1,DATEADD(mm, DATEDIFF(mm,0,DATEADD(MM,1,GETDATE())),0))))))
	'Second Friday',
	DateAdd(dd,7, 
	DATEADD(DD,7,
	dateadd(dd,
	6-datepart(dw,dateadd(dd,1,dateadd(mm,-1,DATEADD(SS,-1,DATEADD(mm, DATEDIFF(mm,0,DATEADD(MM,1,GETDATE())),0)))))
	,
	dateadd(dd,1,dateadd(mm,-1,DATEADD(SS,-1,DATEADD(mm, DATEDIFF(mm,0,DATEADD(MM,1,GETDATE())),0)))))))
	'Third Friday',
	DATEADD(dd,7,
	DateAdd(dd,7, 
	DATEADD(DD,7,
	dateadd(dd,
	6-datepart(dw,dateadd(dd,1,dateadd(mm,-1,DATEADD(SS,-1,DATEADD(mm, DATEDIFF(mm,0,DATEADD(MM,1,GETDATE())),0)))))
	,
	dateadd(dd,1,dateadd(mm,-1,DATEADD(SS,-1,DATEADD(mm, DATEDIFF(mm,0,DATEADD(MM,1,GETDATE())),0)))))))) 
	'Fourth Friday', 
	DateAdd(dd,7, 
	DATEADD(dd,7,
	DateAdd(dd,7, 
	DATEADD(DD,7,
	dateadd(dd,
	6-datepart(dw,dateadd(dd,1,dateadd(mm,-1,DATEADD(SS,-1,DATEADD(mm, DATEDIFF(mm,0,DATEADD(MM,1,GETDATE())),0)))))
	,
	dateadd(dd,1,dateadd(mm,-1,DATEADD(SS,-1,DATEADD(mm, DATEDIFF(mm,0,DATEADD(MM,1,GETDATE())),0))))))))) 
	'Fifth Friday'