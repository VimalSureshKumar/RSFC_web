SELECT
  p.Player_Name,
  ps.Position_Name,
  t.Team_Name
FROM
  Player p
INNER JOIN Position ps ON p.PositionId = ps.PositionId
INNER JOIN Team t ON p.TeamId = t.TeamId;
