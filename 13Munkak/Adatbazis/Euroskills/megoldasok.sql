-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


-- 1. feladat:								2/2
CREATE DATABASE bd_euroskills
	DEFAULT CHARACTER SET utf8
    	DEFAULT COLLATE utf8_hungarian_ci

-- 3. feladat:								3/3
SELECT COUNT(*) AS "ermek" FROM versenyzo
	WHERE pont >= 700

-- 4. feladat:								4/4
SELECT orszagNev FROM orszag
	INNER JOIN versenyzo ON orszag.id = versenyzo.orszagId
    	GROUP BY orszagNev
    	ORDER BY orszagNev

-- 5. feladat:								5/5
SELECT szakmaNev, COUNT(*) AS "versenyzok szama" FROM szakma
	INNER JOIN versenyzo ON szakma.id = versenyzo.szakmaId
    	GROUP BY szakmaNev
    	ORDER BY COUNT(*) DESC

-- 6. feladat:								5/5
SELECT nev, orszagNev, szakmaNev, pont FROM szakma
	INNER JOIN versenyzo ON szakma.id = versenyzo.szakmaId
    	INNER JOIN orszag ON versenyzo.orszagId = orszag.id
    	ORDER BY pont DESC, nev ASC
	LIMIT 25

+1 Pont ALIAS beállítása miatt.

-----------------------
	20/20
-----------------------