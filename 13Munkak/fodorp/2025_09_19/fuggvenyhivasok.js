function kiir()
{
    document.getElementById("eredmeny").innerText = "Kakaós csiga";
}
//1. lehetőség
document.getElementById("gomb").onclick = kiir;

//2. lehetőség
document.getElementById("gomb2").onclick = function()
{
    eredmeny.innerText += " Névtelen függvény";
}

//3. lehetőség
document.getElementById("gomb3").addEventListener("click", kiir);

//4. lehetőség
document.getElementById("gomb4").addEventListener("click", function()
{
    eredmeny.innerText += " Névtelen fg. 2";
});

//Paraméteres fg.
function terulet(a, b)
{
    return a * b
}

document.getElementById("gomb5").onclick = function()
{
    eredmeny.innerText = terulet(3,4);
}

//Nyílfg.
document.getElementById("gomb6").addEventListener("click", () => 
{
    eredmeny.innerText = terulet(4,5);
})