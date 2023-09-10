SELECT * FROM Categories

SELECT * FROM Expenses

SELECT a.Email FROM Users a
INNER JOIN Expenses b ON a.UserId = b.User_Id
WHERE b.Category_Id = 3

UPDATE Expenses
SET Amount = 10
WHERE ExpensesId = 1

INSERT INTO Expenses 
VALUES ('1', '2', '100', '2023-03-08', 'compras')

DELETE FROM Expenses
WHERE ExpensesId = 3