A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!

1. feladat:
CREATE DATABASE bd_papirgyujtes
    DEFAULT CHARACTER SET utf8
    DEFAULT COLLATE utf8_hungarian_ci

2. feladat:
SELECT nev AS "Név", osztaly AS "Osztály", SUM(leadasok.mennyiseg) / 100 AS "Kg"
	FROM tanulok
    INNER JOIN leadasok ON leadasok.tanulo = tanulok.tazon
    GROUP BY tazon
    ORDER BY SUM(leadasok.mennyiseg) / 100 DESC

3. feladat:
SELECT nev, COUNT(*) AS "Leadások száma"
	FROM tanulok
    INNER JOIN leadasok ON leadasok.tanulo = tanulok.tazon
    GROUP BY tazon
    HAVING COUNT(*) >= 6
    ORDER BY COUNT(*) DESC, nev ASC

4. feladat:
SELECT DISTINCT(nev)
	FROM tanulok
    INNER JOIN leadasok ON leadasok.tanulo = tanulok.tazon
    GROUP BY sorsz
    ORDER BY nev

5. feladat:
SELECT osztaly, SUM(leadasok.mennyiseg) AS "Eredmény"
	FROM tanulok
    INNER JOIN leadasok ON leadasok.tanulo = tanulok.tazon
    GROUP BY osztaly
    HAVING SUM(leadasok.mennyiseg) > 120000
    ORDER BY SUM(leadasok.mennyiseg) DESC

6. feladat:
SELECT idopont, SUM(leadasok.mennyiseg) / 10000 AS "Eredmény"
	FROM leadasok
    GROUP BY idopont
    ORDER BY SUM(leadasok.mennyiseg) / 10000 DESC
    LIMIT 5