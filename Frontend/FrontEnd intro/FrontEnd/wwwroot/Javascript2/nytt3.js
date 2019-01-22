






let element1 = document.getElementById("knapp1");

function showPicture() {
    let katten = document.getElementById("katten")
    katten.innerHTML = "<img src='olof.jpg'/>";
}


function outputName() {
    let x = document.getElementById("form1");
    let y = x.elements["name"].value;

    document.getElementById("output").innerHTML = y;
}














