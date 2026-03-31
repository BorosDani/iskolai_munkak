
function kerulet()
{
    let r = Number(document.getElementById("r").value);

    if(r <= 0)
    {
        return "Nem kör!";
    }

    else
    {
        return Number((r * 2) * 3.14);
    }
}

function terulet()
{
    let r = Number(document.getElementById("r").value);

    if(r <= 0)
    {
        return "Nem kör!";
    }

    else
    {
        return Number((r * r) * 3.14);
    }
}

document.getElementById("gomb").onclick = function()
{
    document.getElementById("kerulet").value = kerulet();
    document.getElementById("terulet").value = terulet();
}