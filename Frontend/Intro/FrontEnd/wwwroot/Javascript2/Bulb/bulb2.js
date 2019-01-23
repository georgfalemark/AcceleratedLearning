
backgroundColor();

function backgroundColor() {
    document.body.style.backgroundColor = "black";
}


let lamp1 = document.getElementById("lamp1");
let lamp2 = document.getElementById("lamp2");
let lamp3 = document.getElementById("lamp3");



document.getElementById("button1").addEventListener("click", () => { lamp1.innerHTML = "<img src='bulb-on.jpg' alt='Trulli' width='320' height='400'>" })
document.getElementById("button2").addEventListener("click", () => { lamp2.innerHTML = "<img src='bulb-on.jpg' alt='Trulli' width='320' height='400'>" })
document.getElementById("button3").addEventListener("click", () => { lamp3.innerHTML = "<img src='bulb-on.jpg' alt='Trulli' width='320' height='400'>" })





