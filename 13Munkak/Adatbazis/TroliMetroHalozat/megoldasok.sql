-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


-- 10. feladat:
CREATE DATABASE bd_halozat
	DEFAULT CHARACTER SET utf8
	DEFAULT COLLATE utf8_hungarian_ci						2/2

-- 12. feladat:
INSERT INTO megallok VALUES(198, "Kőbányai garázs")					1/1

-- 13. feladat:										1/1
UPDATE jaratok SET elsoAjtos = False
	WHERE id = 20

-- 14. feladat:										1/1
SELECT jaratSzam FROM jaratok
	WHERE elsoAjtos = True

-- 15. feladat:										3/3
SELECT nev FROM megallok
	WHERE nev LIKE "%sétány"
    	ORDER BY nev ASC

-- 16. feladat:										5/5
SELECT sorszam, nev AS "megallo" FROM megallok
	INNER JOIN halozat ON megallok.id = halozat.megallo
    	INNER JOIN jaratok ON halozat.jarat = jaratok.id
    	WHERE jaratok.jaratSzam = "CITY" AND halozat.irany = "A"
    	ORDER BY halozat.sorszam

-- 17. feladat:										5/5							
SELECT nev AS "megallo", COUNT(*) AS "jaratokSzama" FROM megallok
	INNER JOIN halozat ON megallok.id = halozat.megallo
    	GROUP BY nev
    	HAVING COUNT(*) >= 3


JAVÍTVA: (Viszont jól működött szóval max pont)

SELECT nev AS "megallo", COUNT(jaratok.id) AS "jaratokSzama" FROM megallok
	INNER JOIN halozat ON megallok.id = halozat.megallo
	INNER JOIN jaratok ON halozat.id = halozat.id
    	GROUP BY nev
    	HAVING COUNT(*) >= 3

----------------------------
	   20/20
----------------------------