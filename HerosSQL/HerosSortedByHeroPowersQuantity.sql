SELECT hp.HeroPowersID, hp.AbilityToUse, Heros.*, sp.SuperPower
FROM HeroPowers AS hp
JOIN Heros ON hp.HeroID = Heros.HeroID
JOIN SuperPowers AS sp ON hp.PowerID = sp.PowerID
WHERE hp.AbilityToUse > 5
ORDER BY (SELECT COUNT(*) FROM HeroPowers AS hp2 WHERE hp2.HeroID = hp.HeroID) ASC