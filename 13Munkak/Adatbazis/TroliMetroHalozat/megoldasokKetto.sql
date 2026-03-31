-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


-- 10. feladat:
CREATE DATABASE bd_halozat
	DEFAULT CHARACTER SET utf8                                          2p
	DEFAULT COLLATE utf8_hungarian_ci

-- 12. feladat:
INSERT INTO megallok VALUES(198, "Kőbányai garázs")                     1p

-- 13. feladat:
UPDATE jaratok SET elsoAjtos = 0                                        1p
	WHERE id = 20

-- 14. feladat:
SELECT jaratSzam                                                        2p
	FROM jaratok
    WHERE elsoAjtos = 1

-- 15. feladat:
SELECT nev                                                              3p
	FROM megallok
    WHERE nev LIKE ("% sétány")
    ORDER BY nev

-- 16. feladat:
SELECT sorszam, nev AS "megallo"                                        5p
	FROM megallok INNER JOIN halozat ON megallok.id = megallo
    INNER JOIN jaratok ON jaratok.id = jarat
    WHERE jaratSzam = "CITY" AND irany = "A"
    GROUP BY nev
    ORDER BY sorszam

-- 17. feladat:
SELECT nev AS "megallo", COUNT(*) AS "jaratokSzama"                     4p
	FROM megallok INNER JOIN halozat ON megallok.id = megallo
    INNER JOIN jaratok ON jaratok.id = jarat
    GROUP BY nev
    HAVING COUNT(*) > 3
    ORDER BY COUNT(*), megallo

+1p

----------------------------
	   19/20
----------------------------