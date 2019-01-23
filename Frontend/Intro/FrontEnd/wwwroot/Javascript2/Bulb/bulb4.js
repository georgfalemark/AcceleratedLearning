backgroundColor();

function backgroundColor() {
    document.body.style.backgroundColor = "black";
}


let lamp1 = document.getElementById("lamp1")
let lamp2 = document.getElementById("lamp2")
let lamp3 = document.getElementById("lamp3")
let lamp4 = document.getElementById("lamp4")
let lamp5 = document.getElementById("lamp5")

let index = 1;

function lightSwitch() {

    lamp1.innerHTML = "<img src='bulb-off.jpg' alt='Trulli' width='200' height='240'>";
    lamp2.innerHTML = "<img src='bulb-off.jpg' alt='Trulli' width='200' height='240'>";
    lamp3.innerHTML = "<img src='bulb-off.jpg' alt='Trulli' width='200' height='240'>";
    lamp4.innerHTML = "<img src='bulb-off.jpg' alt='Trulli' width='200' height='240'>";
    lamp5.innerHTML = "<img src='bulb-off.jpg' alt='Trulli' width='200' height='240'>";

    if (index == 1) {
        lamp1.innerHTML = "<img src='bulb-on.jpg' alt='Trulli' width='200' height='240'>";
    }
    if (index == 2) {
        lamp2.innerHTML = "<img src='bulb-on.jpg' alt='Trulli' width='200' height='240'>";
    }
    if (index == 3) {
        lamp3.innerHTML = "<img src='bulb-on.jpg' alt='Trulli' width='200' height='240'>";
    }
    if (index == 4) {
        lamp4.innerHTML = "<img src='bulb-on.jpg' alt='Trulli' width='200' height='240'>";
    }
    if (index == 5) {
        lamp5.innerHTML = "<img src='bulb-on.jpg' alt='Trulli' width='200' height='240'>";
    }

    let text = document.getElementById("text");
    text.innerText = `Current bulb: ${index}`;

    index++;

    if (index > 5) {
        index = 1;
    }
}
































