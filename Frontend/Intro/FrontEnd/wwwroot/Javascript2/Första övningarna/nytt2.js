


function changeColor() {


    document.getElementById("knapp1").style.color == 'red';

    if (knapp1.style.color == 'red') {
    document.getElementById("knapp1").style.color = 'black';
    }
    else if (knapp1.style.color == 'black') {
        document.getElementById("knapp1").style.color = 'red';
    }

    //if (document.getElementById("knapp1").style.color = 'black') {
    //}
    //if (document.getElementById("knapp1").style.color = 'red') {
    //document.getElementById("knapp1").style.color = 'black';
    //}


    //document.getElementById("knapp1").style.color = 'red';


}


let x = 25;
let y = 25;

function makeButtonBigger() {
    document.getElementById("knapp2").style.width = x + 'px';
    document.getElementById("knapp2").style.height = y + 'px';

    x = x + 5;
    y = y + 5;
}

function redWhenHold() {
    let knapp3 = document.getElementById("knapp3");

    knapp3.addEventListener("mouseover", () => { knapp3.style.color = "red"; })



}




















