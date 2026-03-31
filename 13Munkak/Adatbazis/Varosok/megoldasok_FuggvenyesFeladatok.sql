A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!

1. feladat:
SELECT mnev, SUM(nepesseg) AS Fő, AVG(nepesseg) AS Átlag
	FROM varos INNER JOIN megye ON megyeid = megye.id
    GROUP BY mnev
    HAVING Átlag > 20000 && mnev <> "Budapest"
    ORDER BY Átlag DESC

2. feladat:
SELECT mnev, ROUND(AVG(nepesseg), 0) AS Átlag
	FROM varos INNER JOIN megye ON megyeid = megye.id
    GROUP BY mnev
    ORDER BY Átlag

3. feladat:
SELECT mnev, CONCAT(ROUND(AVG(nepesseg), 0)," Fő") AS Átlag
	FROM varos INNER JOIN megye ON megyeid = megye.id
    GROUP BY mnev
    ORDER BY Átlag

4. feladat:
SELECT mnev, COUNT(*) AS "Településszám"
	FROM varos INNER JOIN megye ON megyeid = megye.id
    GROUP BY mnev
    HAVING mnev <> "Budapest" && CHAR_LENGTH(mnev) = 5

5. feladat:
SELECT mnev, CONCAT("~",ROUND(SUM(terulet), -2), " km2") AS Terület
	FROM varos INNER JOIN megye ON megyeid = megye.id
    WHERE mnev <> "Budapest"
    GROUP BY mnev
    ORDER BY SUM(terulet) DESC

6. feladat:
SELECT CONCAT(CHAR_LENGTH(vnev), " kar.") AS "Névhossz",COUNT(*) AS "Városszám"
	FROM varos INNER JOIN megye ON megyeid = megye.id
    GROUP BY CHAR_LENGTH(vnev)
    HAVING COUNT(*) > 20

7. feladat:
SELECT LEFT(vnev, 1) AS Kezdőbetű, COUNT(*) AS DB
    FROM varos INNER JOIN megye ON megyeid = megye.id
    WHERE mnev <> "Budapest"
    GROUP BY LEFT(vnev, 1)
    ORDER BY Kezdőbetű;