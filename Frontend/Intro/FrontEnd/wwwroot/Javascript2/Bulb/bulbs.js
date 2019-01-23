
backgroundColor();

function backgroundColor() {
    document.body.style.backgroundColor = "black";
}


let lamp = document.getElementById("lamp");

let lightBulb = false;

let button1 = document.getElementById("button1");
let button2 = document.getElementById("button2");
let button3 = document.getElementById("button3");
let button4 = document.getElementById("button4");


function lightSwitch() {

    lightBulb = !lightBulb;

    if (lightBulb) {
        lamp.innerHTML = "<img src='bulb-off.jpg' alt='Trulli' width='320' height='400'> " +
            "<img src='bulb-off.jpg' alt='Trulli' width='320' height='400'> " +
            "<img src='bulb-off.jpg' alt='Trulli' width='320' height='400'> " +
            "<img src='bulb-off.jpg' alt='Trulli' width='320' height='400'> ";
    }
    else {
        lamp.innerHTML = "<img src='bulb-on.jpg' alt='Trulli' width='320' height='400'> " +
            "<img src='bulb-on.jpg' alt='Trulli' width='320' height='400'> " +
            "<img src='bulb-on.jpg' alt='Trulli' width='320' height='400'> " +
            "<img src='bulb-on.jpg' alt='Trulli' width='320' height='400'> ";
    }
}









































































//let bulb2 = document.getElementById("theBulb2");
//let button2 = document.getElementById("button2");
//let lightBulb2 = false;

//function lightSwitch2() {
//    lightBulb2 = !lightBulb2;
//    if (lightBulb2) {
//        bulb2.innerHTML = "<img src='bulb-off.jpg' alt='Trulli' width='320' height='400'>";
//    }
//    else {
//        bulb2.innerHTML = "<img src='bulb-on.jpg' alt='Trulli' width='320' height='400'>";
//    }
//}



//lightBulb = !lightBulb;
//if (lightBulb) {
//    document.getElementById("button").addEventListener("click", () => { button.innerHTML = "<img src='bulb-off.jpg' alt='Trulli' width='320' height='400'>" })
//}
//else {
//    document.getElementById("button").addEventListener("click", () => { button.innerHTML = "<img src='bulb-on.jpg' alt='Trulli' width='320' height='400'>" })
//}





//let knapp1 = document.getElementById("knapp1");
//let rubbe = document.getElementById("rubbe");
//let writeInGreen = false;
//function toggleGreenColor() {
//    writeInGreen = !writeInGreen;
//    if (writeInGreen) {
//        rubbe.style.color = "green";
//    } else {
//        rubbe.style.color = "black";
//    }
//}



























