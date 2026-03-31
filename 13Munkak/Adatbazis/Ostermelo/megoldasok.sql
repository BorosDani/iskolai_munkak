A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!

--1. Feladat--
CREATE DATABASE kg_ostermelo
DEFAULT CHARACTER SET utf8
DEFAULT COLLATE utf8_hungarian_ci

--3. Feladat--
SELECT DISTINCT(telepules)
	FROM partnerek
    ORDER BY telepules

--4. Feladat--
SELECT COUNT(*) AS alkalmak
	FROM partnerek INNER JOIN kiszallitasok ON id=partnerid
    WHERE telepules = "Vác"

--5. Feladat--
    SELECT partnerid,datum, SUM(karton) AS legtobb
	FROM kiszallitasok
    WHERE datum LIKE("2016-05%")
    GROUP by partnerid
    ORDER BY legtobb DESC
    LIMIT 1

--6. Feladat--
SELECT telepules
	FROM partnerek
    GROUP BY telepules
    HAVING COUNT(*) > 1
    ORDER BY telepules

--7. Feladat--
SELECT gynev AS ital, SUM(karton*6) AS doboz
    FROM kiszallitasok INNER JOIN gyumolcslevek ON gyumleid=id
    GROUP BY ital
    ORDER by doboz DESC