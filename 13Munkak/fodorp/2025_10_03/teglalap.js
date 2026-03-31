function terulet(a, b)
{
    if (a <= 0 || b <= 0)
    {
        return "Nullánál nagyobb számot adj meg!";
    } 
    else 
    {
        return "A terület: " + a * b;
    }
}

function kerulet(a,b)
{
    if (a <= 0 || b <= 0)
    {
        return "Nullánál nagyobb számot adj meg!";
    }
    else
    {
        return "A kerület: " + ((2*a) + (2*b));
    }
}

document.querySelector("input[type='button']").addEventListener("click", function()
{
    let oldal1 = document.getElementById("a").value;
    let oldal2 = document.getElementById("b").value;
    eredmeny.innerHTML = "<br>" + terulet(oldal1, oldal2);
    eredmeny2.innerHTML = "<br>" + kerulet(oldal1, oldal2);
})