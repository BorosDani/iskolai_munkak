--1. Feladat--
SELECT SUM(karton*6) AS "Legtobb kiszalitott doboz"
    FROM kiszallitasok
    GROUP BY sorsz
    ORDER by SUM(karton*6) DESC
    LIMIT 1

--2. Feladat--
SELECT gynev, COUNT(*) AS "Kiszállítások"
    FROM kiszallitasok INNER JOIN gyumolcslevek ON gyumleid=id
    GROUP BY gynev
    ORDER by COUNT(*) DESC

--3. Feladat--
SELECT gynev, SUM(karton) AS "Kiszállítások mennyiség"
    FROM kiszallitasok INNER JOIN gyumolcslevek ON gyumleid=id
    GROUP BY gynev
    ORDER by SUM(karton) DESC
    LIMIT 3

--4. Feladat--
SELECT gynev, SUM(karton) AS "Kiszállítások mennyiség"
    FROM kiszallitasok INNER JOIN gyumolcslevek ON gyumleid=id
    GROUP BY gynev
    HAVING SUM(karton) >= 1000
    ORDER by SUM(karton) DESC

--5. Feladat--
SELECT telepules,COUNT(*) AS "Partnerek száma"
	FROM partnerek
    GROUP BY telepules
    ORDER BY COUNT(*) DESC