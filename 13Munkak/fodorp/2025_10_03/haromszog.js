//Gomb megnyomással
function kerulet(a, b, c)
{
    if(a + b < c || a + c < b || b + c < a)
    {
        return "Ez a háromszög nem létezik!";
    }

    else
    {
        return a + b + c;
    }
}

document.getElementById("gomb").onclick = function()
{
    let a = Number(document.getElementById("a").value);
    let b = Number(document.getElementById("b").value);
    let c = Number(document.getElementById("c").value);

    document.getElementById("eredmeny").innerText = "Kerület: " + kerulet(a, b, c);
}


//Gomb megnyomás nélkül
function terulet()
{
    let a = Number(document.getElementById("a").value);
    let b = Number(document.getElementById("b").value);
    let c = Number(document.getElementById("c").value);
    let s = (a + b + c) / 2;

    let terulet = Math.sqrt(s * (s - a) * (s - b) * (s - c));

    document.getElementById("eredmeny2").innerHTML = "Terület: " + terulet.toFixed(0);
}

document.getElementById("a").onchange = terulet;
document.getElementById("b").onchange = terulet;
document.getElementById("c").onchange = terulet;