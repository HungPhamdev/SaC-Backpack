USE SaCDatabase
GO
-- 
CREATE TRIGGER trg_TrangThaiKhiTao ON Vouchers AFTER INSERT AS
BEGIN 
	DECLARE @EndDate DATETIME, @VouId INT;
	SET @EndDate = (Select v.EndDate from Inserted v inner join Vouchers on v.VoucherId = Vouchers.VoucherId where v.VoucherId = Vouchers.VoucherId)
	SET @VouId = (Select v.VoucherId from Inserted v inner join Vouchers on v.VoucherId = Vouchers.VoucherId where v.VoucherId = Vouchers.VoucherId)
	IF(@EndDate < GETDATE())
		BEGIN
			UPDATE Vouchers SET Status = 'FALSE'
			WHERE EndDate < GETDATE() AND VoucherId = @VouId
		END
	ELSE
		BEGIN
			UPDATE Vouchers SET Status = 'TRUE'
			WHERE EndDate > GETDATE() AND VoucherId = @VouId
		END
END
GO


CREATE TRIGGER trg_TrangThaiKhiSua ON Vouchers AFTER UPDATE AS
BEGIN 
	DECLARE @EndDate DATETIME, @VouId INT;
	SET @EndDate = (Select v.EndDate from Inserted v inner join Vouchers on v.VoucherId = Vouchers.VoucherId where v.VoucherId = Vouchers.VoucherId)
	SET @VouId = (Select v.VoucherId from Inserted v inner join Vouchers on v.VoucherId = Vouchers.VoucherId where v.VoucherId = Vouchers.VoucherId)
	IF(@EndDate < GETDATE())
		BEGIN
			UPDATE Vouchers SET Status = 'FALSE'
			WHERE EndDate < GETDATE() AND VoucherId = @VouId
		END
	ELSE
		BEGIN
			UPDATE Vouchers SET Status = 'TRUE'
			WHERE EndDate > GETDATE() AND VoucherId = @VouId
		END
END
GO