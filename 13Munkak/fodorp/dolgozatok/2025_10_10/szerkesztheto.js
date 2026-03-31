function szerkesztheto()
{
    let a = Number(document.getElementById("a").value);
    let b = Number(document.getElementById("b").value);
    let c = Number(document.getElementById("c").value);

    if(a + b < c || a + c < b || b + c < a || a <= 0 || b <= 0 || c <= 0)
    {
        return "Nem szerkeszthető!";
    }

    else
    {
        return "Szerkeszthető!";
    }
}

document.getElementById("gomb").onclick = function()
{
    document.getElementById("eredmeny").value = szerkesztheto();
}