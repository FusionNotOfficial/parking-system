CREATE TABLE ExitTbl
(
	ExitCode INT PRIMARY KEY IDENTITY,
	Entries INT FOREIGN KEY REFERENCES EntryTbl(EntCode),
	ExitDate date,
	DHours INT,
	Amount INT
);
