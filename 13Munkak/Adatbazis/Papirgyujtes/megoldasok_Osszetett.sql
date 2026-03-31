A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!

1. feladat:
SELECT DISTINCT(nev), osztaly
	FROM tanulok
    WHERE nev LIKE "A%" OR nev LIKE "D%" OR nev LIKE "J%"
    ORDER BY nev

2. feladat:
/*Egyik megoldás*/
SELECT DISTINCT(nev), osztaly
	FROM tanulok
    WHERE osztaly LIKE "2A" OR nev LIKE "3B" OR nev LIKE "7A"
    ORDER BY osztaly

/*Másik Megoldás*/
SELECT DISTINCT(nev), osztaly
	FROM tanulok
    WHERE osztaly IN("2A", "3B", "7A")
    ORDER BY osztaly

3. feladat:
/*Egyik megoldás*/
SELECT idopont, SUM(mennyiseg) AS "dkg"
	FROM leadasok
    WHERE idopont = "2016-10-10" OR idopont = "2016-10-28"
    GROUP BY idopont

/*Másik Megoldás*/
SELECT idopont, SUM(mennyiseg) AS "dkg"
	FROM leadasok
    WHERE idopont IN("2016-10-10", "2016-10-28")
    GROUP BY idopont

4. feladat:
/*Egyik megoldás*/
SELECT SUM(mennyiseg) / COUNT(*) AS "Átlag"
	FROM leadasok
    WHERE idopont > "2016-10-12" || idopont < "2016-10-07"

/*Másik Megoldás*/
SELECT SUM(mennyiseg) / COUNT(*) AS "Átlag"
	FROM leadasok
    WHERE idopont NOT IN(SELECT idopont FROM leadasok WHERE idopont BETWEEN "2016-10-07" AND "2016-10-12")
5. feladat:
/*Első megoldás*/
SELECT DISTINCT(osztaly)
	FROM tanulok
    WHERE osztaly != "2A"

/*Második megoldás*/
SELECT DISTINCT(osztaly)
	FROM tanulok
    WHERE osztaly NOT IN("2A")

/*Harmadik megoldás*/
SELECT DISTINCT(osztaly)
	FROM tanulok
    WHERE osztaly NOT LIKE("2A")

6. feladat
/*Első megoldás*/
SELECT DISTINCT(osztaly)
	FROM tanulok
    WHERE osztaly != "2A" && osztaly != "3A" && osztaly != "5B"

/*Második megoldás*/
SELECT DISTINCT(osztaly)
	FROM tanulok
    WHERE osztaly NOT IN("2A", "3A", "5B")

/*Harmadik megoldás*/
SELECT DISTINCT(osztaly)
	FROM tanulok
    WHERE osztaly NOT LIKE("2A") && osztaly NOT LIKE("3A") && osztaly NOT LIKE("5B")