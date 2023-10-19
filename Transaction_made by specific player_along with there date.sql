SELECT
  t.TransactionId,
  t.Transaction_Fee,
  t.Transaction_Date
FROM
  [Transaction] t
INNER JOIN Player p ON t.PlayerId = p.PlayerId
WHERE
  p.Player_Name = 'Tobie Little'; -- Replace 'Tobie Little' with the desired player's name
