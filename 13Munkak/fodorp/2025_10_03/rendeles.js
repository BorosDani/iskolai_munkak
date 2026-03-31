let prices = [300, 600, 1000, 800];

function szamol()
{
    let index = document.getElementById("fruits").options.selectedIndex;
    let db = Number(document.getElementById("quantity").value);

    result.innerHTML = "Egységár: " + prices[index] + " - Ft/kg<br>Összesen: " + db * prices[index] + " - Ft";
}

document.getElementById("fruits").onchange = szamol;
document.getElementById("quantity").onchange = szamol;