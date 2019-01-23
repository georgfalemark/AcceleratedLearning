
backgroundColor();

function backgroundColor() {
    document.body.style.backgroundColor = "black";
}


let lamp = document.getElementById("lamp");

let lightBulb = false;


function lightSwitch() {

    lightBulb = !lightBulb;

    if (lightBulb) {
        lamp.innerHTML = "<img src='bulb-off.jpg' alt='Trulli' width='320' height='400'> " +
            "<img src='bulb-off.jpg' alt='Trulli' width='320' height='400'> " +
            "<img src='bulb-off.jpg' alt='Trulli' width='320' height='400'> ";
    }
    else {
        lamp.innerHTML = "<img src='bulb-on.jpg' alt='Trulli' width='320' height='400'> " +
            "<img src='bulb-on.jpg' alt='Trulli' width='320' height='400'> " +
            "<img src='bulb-on.jpg' alt='Trulli' width='320' height='400'> ";
    }
}