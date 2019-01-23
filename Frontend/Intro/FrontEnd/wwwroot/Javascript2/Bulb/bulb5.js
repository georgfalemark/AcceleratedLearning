
backgroundColor();

function backgroundColor() {
    document.body.style.backgroundColor = "black";
}




let buttons = document.getElementById("buttons");
let bulbs = ["bulb 1", "bulb 2", "bulb 3", "bulb 4"];
let lampSpace = document.getElementById("lampSpace");

for (const lampLabel of bulbs) {

    let lamp = document.createElement("img");
    lampSpace.appendChild(lamp);
    lamp.src = "bulb-off.jpg";

    let button = document.createElement("button");
    button.innerText = "Nr " + lampLabel;
    button.addEventListener("click", () => lightSwitch(lamp));
    buttons.appendChild(button);

}



function lightSwitch(lamp) {
    if (lamp.src.match("bulb-on.jpg")) {
        lamp.src = "bulb-off.jpg";
    }
    else {
        lamp.src = "bulb-on.jpg"
    }
}














