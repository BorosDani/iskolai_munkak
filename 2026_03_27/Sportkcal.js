sportokKcal = 
[
    { sportf: "Sport, mozgás", kcalf: "Kcal/óra", percf: "Perc", kcalf: "kcal"},
    { sport: "Futás", kcal: 680 },
    { sport: "Focizás", kcal: 550 },
    { sport: "Bringázás", kcal: 480 },
    { sport: "Hegymászás", kcal: 420 },
    { sport: "Lovaglás", kcal: 370 },
    { sport: "Túrázás", kcal: 360 },
    { sport: "Kajakozás", kcal: 340 },
    { sport: "Súlyzós edzés", kcal: 320 },
    { sport: "Pingpongozás", kcal: 270 },
    { sport: "Kutyasétáltatás", kcal: 200 }
]

document.addEventListener("DOMContentLoaded", function()
{
    addTabla(sportokKcal);
})

function addTabla(adatok)
{
    const sportkcal_tabla = document.getElementById("sportkcal_tabla");
    const tabla = document.createElement("table");
    const tdcim = document.createElement("td");

    for (let i = 1; i < adatok.length; i++) 
    {
        const tr = document.createElement("tr");
        const td = document.createElement("td");
        const td2 = document.createElement("td");

        td.innerText = adatok[i].sport;
        td2.innerText = adatok[i].kcal;

        sportkcal_tabla.appendChild(tabla);
        tabla.appendChild(tr);
        tr.appendChild(td);
        tr.appendChild(td2);
    }
}