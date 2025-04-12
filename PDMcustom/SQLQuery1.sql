CREATE PROCEDURE userLogin
	@username NVARCHAR(50),
	@password NVARCHAR(50)
AS
BEGIN
	-- Check if the user exists
	IF EXISTS (SELECT 1 FROM [User] WHERE UserEmail = @username AND UserPassword COLLATE Latin1_General_BIN = @password)
	BEGIN
		-- User exists, return success message
		SELECT 'Login successful' AS Message;
	END
	ELSE
	BEGIN
		-- User does not exist, return error message
		SELECT 'Invalid username or password' AS Message;
	END
END;
GO

	--RecordID INT IDENTITY(1, 1) PRIMARY KEY,
	--RecordTypeID INT NOT NULL,
	--ProjectID INT NOT NULL,
	--UserID INT NOT NULL, --Author
    --RecordCode VARCHAR(50) NOT NULL UNIQUE,
    --RecordName NVARCHAR(100) NOT NULL,
	--RecordStatus NVARCHAR(50) NOT NULL, -- Chờ phê duyệt, Đã phê duyệt, Đã lưu hành, Hết hiệu lực, Đã lưu trữ
    --RecordDescription NVARCHAR(255) NULL,
    --RecordVersion INT NOT NULL,
    --RecordCreationDate DATETIME NOT NULL DEFAULT GETDATE(), -- Ngày tạo bản ghi, mặc định là ngày hiện tại
    --RecordReleaseDate DATETIME NULL, -- Ngày phát hành bản ghi
    --RecordNote NVARCHAR(255) NULL,
    --RecordProcessingDeadline DATETIME NULL -- Hạn xử lý bản ghi

CREATE PROCEDURE addRecord
	@id INT,
	@type INT,
	@project INT,
	@user INT,
	@code VARCHAR(50),
	@name NVARCHAR(100),
	@status NVARCHAR(50),
	@description NVARCHAR(255),
	@version INT,
	@creationDate DATETIME,
	@releaseDate DATETIME,
	@note NVARCHAR(255),
	@processingDeadline DATETIME
AS
BEGIN
	-- Check if the record code already exists
	
	-- Insert a new record into the Records table
	INSERT INTO Records (RecordID, RecordTypeID, ProjectID, UserID, RecordCode, RecordName, RecordStatus, RecordDescription, RecordVersion, RecordCreationDate, RecordReleaseDate, RecordNote, RecordProcessingDeadline)
	VALUES (@id, @type, @project, @user, @code, @name, @status, @description, @version, @creationDate, @releaseDate, @note, @processingDeadline);
END;
GO

CREATE PROCEDURE updateRecord
	@id INT,
	@type INT,
	@project INT,
	@user INT,
	@code VARCHAR(50),
	@name NVARCHAR(100),
	@status NVARCHAR(50),
	@description NVARCHAR(255),
	@version INT,
	@creationDate DATETIME,
	@releaseDate DATETIME,
	@note NVARCHAR(255),
	@processingDeadline DATETIME
AS
BEGIN
	-- Check if the record code already exists
	
	-- Update the record in the Records table
	UPDATE Records
	SET RecordTypeID = @type,
		ProjectID = @project,
		UserID = @user,
		RecordCode = @code,
		RecordName = @name,
		RecordStatus = @status,
		RecordDescription = @description,
		RecordVersion = @version,
		RecordCreationDate = @creationDate,
		RecordReleaseDate = @releaseDate,
		RecordNote = @note,
		RecordProcessingDeadline = @processingDeadline
	WHERE RecordID = @id;
END;
GO

CREATE PROCEDURE deleteRecord
	@id INT,
	@code VARCHAR(50),
	@name NVARCHAR(100),
	@status NVARCHAR(50),
	@description NVARCHAR(255),
	@version INT,
	@creationDate DATETIME,
	@releaseDate DATETIME,
	@note NVARCHAR(255),
	@processingDeadline DATETIME
	AS
	BEGIN
	-- Check if the record code already exists
	
	-- Delete the record from the Records table
	DELETE FROM Records
	WHERE RecordID = @id;
	END;
	GO

CREATE PROCEDURE getRecordByID
	@id INT
AS
	BEGIN
	-- Check if the record code already exists
	
	-- Get the record from the Records table
	SELECT * FROM Records
	WHERE RecordID = @id;
	END;
GO

CREATE PROCEDURE getAllRecords
AS
BEGIN
	-- Get all records from the Records table
	SELECT * FROM Records;
END;
GO

CREATE PROCEDURE getRecordsByProjectID
	@projectID INT
AS
	BEGIN
	-- Check if the record code already exists
	
	-- Get the records from the Records table
	SELECT * FROM Records
	WHERE ProjectID = @projectID;
	END;
GO

CREATE PROCEDURE getRecordsByUserID
	@userID INT
	AS
	BEGIN
	-- Check if the record code already exists
	
	-- Get the records from the Records table
	SELECT * FROM Records
	WHERE UserID = @userID;
	END;
GO
CREATE PROCEDURE getRecordsByStatus
	@status NVARCHAR(50)
	AS
	BEGIN
	-- Check if the record code already exists
	
	-- Get the records from the Records table
	SELECT * FROM Records
	WHERE RecordStatus = @status;
	END;
GO

CREATE PROCEDURE getRecordsByType
	@typeID INT
	AS
	BEGIN
	-- Check if the record code already exists
	
	-- Get the records from the Records table
	SELECT * FROM Records
	WHERE RecordTypeID = @typeID;
	END;
GO
CREATE PROCEDURE getRecordsByDateRange
	@startDate DATETIME,
	@endDate DATETIME
	AS
	BEGIN
	-- Check if the record code already exists
	
	-- Get the records from the Records table
	SELECT * FROM Records
	WHERE RecordCreationDate BETWEEN @startDate AND @endDate;
	END;
GO
CREATE PROCEDURE getRecordsByKeyword
	@keyword NVARCHAR(100)
	AS
	BEGIN
	-- Check if the record code already exists
	
	-- Get the records from the Records table
	SELECT * FROM Records
	WHERE RecordName LIKE '%' + @keyword + '%'
	   OR RecordDescription LIKE '%' + @keyword + '%';
	END;
GO
CREATE PROCEDURE getRecordsByUserAndProject
	@userID INT,
	@projectID INT
	AS
	BEGIN
	-- Check if the record code already exists
	
	-- Get the records from the Records table
	SELECT * FROM Records
	WHERE UserID = @userID AND ProjectID = @projectID;
	END;
GO

CREATE PROCEDURE getRecordsByUserAndStatus
	@userID INT,
	@status NVARCHAR(50)
	AS
	BEGIN
	-- Check if the record code already exists
	
	-- Get the records from the Records table
	SELECT * FROM Records
	WHERE UserID = @userID AND RecordStatus = @status;
	END;
GO

CREATE PROCEDURE getRecordsByProjectAndStatus
	@projectID INT,
	@status NVARCHAR(50)
	AS
	BEGIN
	-- Check if the record code already exists
	
	-- Get the records from the Records table
	SELECT * FROM Records
	WHERE ProjectID = @projectID AND RecordStatus = @status;
	END;
GO

CREATE PROCEDURE getRecordsByUserAndType
	@userID INT,
	@typeID INT
	AS
	BEGIN
	-- Check if the record code already exists
	
	-- Get the records from the Records table
	SELECT * FROM Records
	WHERE UserID = @userID AND RecordTypeID = @typeID;
	END;
GO

CREATE PROCEDURE getRecordsByProjectAndType
	@projectID INT,
	@typeID INT
	AS
	BEGIN
	-- Check if the record code already exists
	
	-- Get the records from the Records table
	SELECT * FROM Records
	WHERE ProjectID = @projectID AND RecordTypeID = @typeID;
	END;
GO

CREATE PROCEDURE getRecordsByUserAndDateRange
	@userID INT,
	@startDate DATETIME,
	@endDate DATETIME
	AS
	BEGIN
	-- Check if the record code already exists
	
	-- Get the records from the Records table
	SELECT * FROM Records
	WHERE UserID = @userID AND RecordCreationDate BETWEEN @startDate AND @endDate;
	END;
GO

CREATE PROCEDURE getRecordsByProjectAndDateRange
	@projectID INT,
	@startDate DATETIME,
	@endDate DATETIME
	AS
	BEGIN
	-- Check if the record code already exists
	
	-- Get the records from the Records table
	SELECT * FROM Records
	WHERE ProjectID = @projectID AND RecordCreationDate BETWEEN @startDate AND @endDate;
	END;
GO

CREATE PROCEDURE getRecordsByStatusAndDateRange
	@status NVARCHAR(50),
	@startDate DATETIME,
	@endDate DATETIME
	AS
	BEGIN
	-- Check if the record code already exists
	
	-- Get the records from the Records table
	SELECT * FROM Records
	WHERE RecordStatus = @status AND RecordCreationDate BETWEEN @startDate AND @endDate;
	END;
GO

CREATE PROCEDURE getRecordsByTypeAndDateRange
	@typeID INT,
	@startDate DATETIME,
	@endDate DATETIME
	AS
	BEGIN
	-- Check if the record code already exists
	
	-- Get the records from the Records table
	SELECT * FROM Records
	WHERE RecordTypeID = @typeID AND RecordCreationDate BETWEEN @startDate AND @endDate;
	END;
GO

CREATE PROCEDURE getRecordsByKeywordAndDateRange
	@keyword NVARCHAR(100),
	@startDate DATETIME,
	@endDate DATETIME
	AS
	BEGIN
	-- Check if the record code already exists
	
	-- Get the records from the Records table
	SELECT * FROM Records
	WHERE (RecordName LIKE '%' + @keyword + '%'
	   OR RecordDescription LIKE '%' + @keyword + '%')
	   AND RecordCreationDate BETWEEN @startDate AND @endDate;
	END;
GO

CREATE PROCEDURE getRecordsByUserAndKeyword
	@userID INT,
	@keyword NVARCHAR(100)
	AS
	BEGIN
	-- Check if the record code already exists
	
	-- Get the records from the Records table
	SELECT * FROM Records
	WHERE UserID = @userID AND (RecordName LIKE '%' + @keyword + '%'
	   OR RecordDescription LIKE '%' + @keyword + '%');
	END;
GO

CREATE PROCEDURE getRecordsByProjectAndKeyword
	@projectID INT,
	@keyword NVARCHAR(100)
	AS
	BEGIN
	-- Check if the record code already exists
	
	-- Get the records from the Records table
	SELECT * FROM Records
	WHERE ProjectID = @projectID AND (RecordName LIKE '%' + @keyword + '%'
	   OR RecordDescription LIKE '%' + @keyword + '%');
	END;
GO

CREATE PROCEDURE getRecordsByStatusAndKeyword
	@status NVARCHAR(50),
	@keyword NVARCHAR(100)
	AS
	BEGIN
	-- Check if the record code already exists
	
	-- Get the records from the Records table
	SELECT * FROM Records
	WHERE RecordStatus = @status AND (RecordName LIKE '%' + @keyword + '%'
	   OR RecordDescription LIKE '%' + @keyword + '%');
	END;
GO

CREATE PROCEDURE getRecordsByTypeAndKeyword
	@typeID INT,
	@keyword NVARCHAR(100)
	AS
	BEGIN
	-- Check if the record code already exists
	
	-- Get the records from the Records table
	SELECT * FROM Records
	WHERE RecordTypeID = @typeID AND (RecordName LIKE '%' + @keyword + '%'
	   OR RecordDescription LIKE '%' + @keyword + '%');
	END;
GO

CREATE PROCEDURE getRecordsByUserAndProjectAndStatus
	@userID INT,
	@projectID INT,
	@status NVARCHAR(50)
	AS
	BEGIN
	-- Check if the record code already exists
	
	-- Get the records from the Records table
	SELECT * FROM Records
	WHERE UserID = @userID AND ProjectID = @projectID AND RecordStatus = @status;
	END;
GO

CREATE PROCEDURE getRecordsByUserAndProjectAndType
	@userID INT,
	@projectID INT,
	@typeID INT
	AS
	BEGIN
	-- Check if the record code already exists
	
	-- Get the records from the Records table
	SELECT * FROM Records
	WHERE UserID = @userID AND ProjectID = @projectID AND RecordTypeID = @typeID;
	END;
GO

CREATE PROCEDURE getRecordsByUserAndProjectAndDateRange
	@userID INT,
	@projectID INT,
	@startDate DATETIME,
	@endDate DATETIME
	AS
	BEGIN
	-- Check if the record code already exists
	
	-- Get the records from the Records table
	SELECT * FROM Records
	WHERE UserID = @userID AND ProjectID = @projectID AND RecordCreationDate BETWEEN @startDate AND @endDate;
	END;
GO

CREATE PROCEDURE getRecordsByUserAndProjectAndKeyword
	@userID INT,
	@projectID INT,
	@keyword NVARCHAR(100)
	AS
	BEGIN
	-- Check if the record code already exists
	
	-- Get the records from the Records table
	SELECT * FROM Records
	WHERE UserID = @userID AND ProjectID = @projectID AND (RecordName LIKE '%' + @keyword + '%'
	   OR RecordDescription LIKE '%' + @keyword + '%');
	END;
GO

CREATE PROCEDURE getRecordsByUserAndStatusAndDateRange
	@userID INT,
	@status NVARCHAR(50),
	@startDate DATETIME,
	@endDate DATETIME
	AS
	BEGIN
	-- Check if the record code already exists
	
	-- Get the records from the Records table
	SELECT * FROM Records
	WHERE UserID = @userID AND RecordStatus = @status AND RecordCreationDate BETWEEN @startDate AND @endDate;
	END;
GO

CREATE PROCEDURE getRecordsByUserAndStatusAndKeyword
	@userID INT,
	@status NVARCHAR(50),
	@keyword NVARCHAR(100)
	AS
	BEGIN
	-- Check if the record code already exists
	
	-- Get the records from the Records table
	SELECT * FROM Records
	WHERE UserID = @userID AND RecordStatus = @status AND (RecordName LIKE '%' + @keyword + '%'
	   OR RecordDescription LIKE '%' + @keyword + '%');
	END;
GO

CREATE PROCEDURE getRecordsByProjectAndStatusAndDateRange
	@projectID INT,
	@status NVARCHAR(50),
	@startDate DATETIME,
	@endDate DATETIME
	AS
	BEGIN
	-- Check if the record code already exists
	
	-- Get the records from the Records table
	SELECT * FROM Records
	WHERE ProjectID = @projectID AND RecordStatus = @status AND RecordCreationDate BETWEEN @startDate AND @endDate;
	END;
GO

CREATE PROCEDURE getRecordsByProjectAndStatusAndKeyword
	@projectID INT,
	@status NVARCHAR(50),
	@keyword NVARCHAR(100)
	AS
	BEGIN
	-- Check if the record code already exists
	
	-- Get the records from the Records table
	SELECT * FROM Records
	WHERE ProjectID = @projectID AND RecordStatus = @status AND (RecordName LIKE '%' + @keyword + '%'
	   OR RecordDescription LIKE '%' + @keyword + '%');
	END;
GO

CREATE PROCEDURE getRecordsByTypeAndStatus
	@typeID INT,
	@status NVARCHAR(50)
	AS
	BEGIN
	-- Check if the record code already exists
	
	-- Get the records from the Records table
	SELECT * FROM Records
	WHERE RecordTypeID = @typeID AND RecordStatus = @status;
	END;
GO

CREATE PROCEDURE getRecordsByTypeAndKeyword
	@typeID INT,
	@keyword NVARCHAR(100)
	AS
	BEGIN
	-- Check if the record code already exists
	
	-- Get the records from the Records table
	SELECT * FROM Records
	WHERE RecordTypeID = @typeID AND (RecordName LIKE '%' + @keyword + '%'
	   OR RecordDescription LIKE '%' + @keyword + '%');
	END;
GO

CREATE PROCEDURE getRecordsByTypeAndProject
	@typeID INT,
	@projectID INT
	AS
	BEGIN
	-- Check if the record code already exists
	
	-- Get the records from the Records table
	SELECT * FROM Records
	WHERE RecordTypeID = @typeID AND ProjectID = @projectID;
	END;
GO

CREATE PROCEDURE getRecordsByTypeAndUser
	@typeID INT,
	@userID INT
	AS
	BEGIN
	-- Check if the record code already exists
	
	-- Get the records from the Records table
	SELECT * FROM Records
	WHERE RecordTypeID = @typeID AND UserID = @userID;
	END;
GO

CREATE PROCEDURE getRecordsByTypeAndDateRange
	@typeID INT,
	@startDate DATETIME,
	@endDate DATETIME
	AS
	BEGIN
	-- Check if the record code already exists
	
	-- Get the records from the Records table
	SELECT * FROM Records
	WHERE RecordTypeID = @typeID AND RecordCreationDate BETWEEN @startDate AND @endDate;
	END;
GO

CREATE PROCEDURE getRecordsByTypeAndUserAndDateRange
	@typeID INT,
	@userID INT,
	@startDate DATETIME,
	@endDate DATETIME
	AS
	BEGIN
	-- Check if the record code already exists
	
	-- Get the records from the Records table
	SELECT * FROM Records
	WHERE RecordTypeID = @typeID AND UserID = @userID AND RecordCreationDate BETWEEN @startDate AND @endDate;
	END;
GO

--TO BE CONTINUED 💀

