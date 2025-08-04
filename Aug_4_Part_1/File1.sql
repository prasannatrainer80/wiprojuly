Create proc prcDivision 
	@a INT,
	@b INT
AS
BEGIN
	BEGIN TRY
		Set @a = 5;
		Set @b = @a / 0
		Print @b 
	END TRY
	BEGIN CATCH
		Print 'Error is '
		Print ERROR_MESSAGE()
	END CATCH
END
GO

Exec prcDivision 12,0
GO

Create proc prcEvenChek
				@n INT
AS
BEGIN
	Declare 
		@res INT
	BEGIN TRY
		SET @Res = @n%2 
		if (@res = 0) 
		BEGIN
			PRINT 'NO ERROR'
			PRINT 'Even Number'
		END
		ELSE
		BEGIN;
			print 'Error Occurred'
			Throw [ 70000, Error occured, 5]
		END
	END TRY
	BEGIN CATCH
		Print Error_Message()
	END CATCH
END