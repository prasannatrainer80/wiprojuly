SELECT TOP (1000) [Empno]
      ,[Name]
      ,[Gender]
      ,[Dept]
      ,[Desig]
      ,[Basic]
  FROM [wiprojuly].[dbo].[Employ]

  select max(basic) from Employ;

  select name from Employ where basic = (select max(basic) from Employ) 
  GO

  -- Dispaly second max. salary 

  select max(basic) from Employ where basic < 
  (select Max(basic) from Employ)

  -- Display Name of employ who is getting 2nd max. salary

  select Name from Employ where basic = (
    select max(basic) from Employ where basic < 
  (select Max(basic) from Employ))
  GO

  select * from Policy;


  select PolicyId, AppNumber, ModalPremium, AnnualPremium,
  ROW_NUMBER() OVER(Order By AnnualPremium desc) 'Rno'
  from Policy
  GO

  select PolicyId, AppNumber, ModalPremium, AnnualPremium,
  RANK() OVER(Order By AnnualPremium desc) 'Rno'
  from Policy
  GO

  select PolicyId, AppNumber, ModalPremium, AnnualPremium,
  DENSE_RANK() OVER(Order By AnnualPremium desc) 'Rno'
  from Policy
  GO

  select * from Policy
  GO

  select max(annualpremium) from Policy 
  GO

  -- Display PolicyID of max. annualpremium 

  select PolicyId from Policy WHERE AnnualPremium = 
  (select MAX(annualpremium) from  Policy)

  -- Display 2nd max AnnualPremium 

  select max(annualpremium) from Policy WHERE AnnualPremium < 
  (select max(annualpremium) from Policy)

