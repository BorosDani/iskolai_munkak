A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!

1. feladat:
SELECT nev
	FROM tanulok LEFT JOIN leadasok ON leadasok.tanulo = tanulok.tazon
    WHERE tanulo IS NULL

2. feladat:
SELECT COUNT(*) AS "Inaktív tanulók"
	FROM leadasok RIGHT JOIN tanulok ON leadasok.tanulo = tanulok.tazon
    WHERE tanulo IS NULL

3. feladat:
SELECT nev
	FROM leadasok INNER JOIN tanulok ON leadasok.tanulo = tanulok.tazon
    WHERE tanulo IS NOT NULL
    GROUP BY tanulo
    
4. feladat:
SELECT COUNT(DISTINCT(nev)) AS "Aktívak"
	FROM leadasok INNER JOIN tanulok ON leadasok.tanulo = tanulok.tazon

5. feladat:
SELECT COUNT(DISTINCT(nev)) AS "összlétszám"
	FROM leadasok RIGHT JOIN tanulok ON leadasok.tanulo = tanulok.tazon




--- SAJÁT FELADATOK ---

SELECT nev, SUM(mennyiseg) AS "Leadott mennyiség", COUNT(*) AS "DB"
	FROM leadasok INNER JOIN tanulok ON tazon = tanulo
    GROUP BY tanulo
    ORDER BY SUM(mennyiseg) DESC

SELECT osztaly, nev, idopont, COUNT(*) AS "Leadott mennyiség (db)" 
    FROM leadasok RIGHT JOIN tanulok ON tazon = tanulo
    WHERE idopont BETWEEN "2016-10-15" AND "2016-10-25" 
    GROUP BY tanulo 
    ORDER BY idopont

SELECT IF(mennyiseg > 5000, "5000-nél nagyobb leadások száma", "5000-nél kisebb leadások száma") AS "Leadás", COUNT(*) AS "DB"
    FROM leadasok LEFT JOIN tanulok ON tazon = tanulo
    GROUP BY mennyiseg > 5000
    ORDER BY COUNT(*)

SELECT DISTINCT(tazon), osztaly, nev, COUNT(*) AS ""
    FROM tanulok
    WHERE osztaly LIKE("2_")
    GROUP BY tazon
    ORDER BY osztaly, tazon