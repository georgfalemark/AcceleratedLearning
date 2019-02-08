

//let buttons = document.getElementById("buttons");
//let eggs = ["egg 1", "egg 2", "egg 3"];
//let eggSpace = document.getElementById("eggSpace");

//for (const eggNumber of eggs) {

//    let egg = document.createElement("img");
//    eggSpace.appendChild(egg);
//    egg.src = "egg1-closed.png";

//    let button = document.createElement("button");
//    button.innerText = "Nr " + eggNumber;
//    button.addEventListener("click", () => eggChanger(egg));
//    buttons.appendChild(button);
//}

//function eggChanger(egg) {
//    if (egg.src.match("egg2-open.png")) {
//        lamp.src = "egg1-closed.png";
//    }
//    else {
//        lamp.src = "egg2-open.png"
//    }
//}






//document.getElementById("egget").addEventListener("click", () => { test.innerHTML = "<img src='egg2-open.png'>"; })



//let egg1 = document.getElementById("egget");
//let test = document.getElementById("test");
//let index = 2;


//function changeEgg() {

//    //test.innerHTML = "<img src='egg1-closed.png'>";

//    if (index == 1) {
//        test.innerHTML = "<img src='egg1-closed.png'>";
//    }
//    if (index = 2) {
//        test.innerHTML = "<img src='egg2-open.png'>";
//        index++;
//    }
//    if (index == 3) {
//        test.innerHTML = "<img src='egg3-double.png'>";
//    }

//    index++;

//    if (index > 3) {
//        index = 1;
//    }
//}










//function changeImage() {

//    if (document.getElementById("imgClickAndChange").src == "egg1-closed.png") {
//        document.getElementById("imgClickAndChange").src = "egg2-open.png";
//    }
//    if (document.getElementById("imgClickAndChange").src == "egg2-open.png") {
//        document.getElementById("imgClickAndChange").src = "egg3-double.png";
//    }
//    else {
//        document.getElementById("imgClickAndChange").src = "egg1-closed.png";
//    }
//}













let index = 1;
let egg1 = document.getElementById("egg1").src;
//let egg2 = document.getElementById("egg2");
//let egg3 = document.getElementById("egg3");

function changePicture() {

    if (index == 1) {
        egg1.src = "<img src='egg2-open.png'>";
    }
    if (index = 2) {
        egg1.src = "<img src='egg3-double.png'>";
    }
    if (index == 3) {
        egg1.src = "<img src='egg1-closed.png'>";
    }

    index++;

    if (index > 3) {
        index = 1;
    }
}













//let index = 1;

//let egg1 = document.getElementById("egg1")

//function changeEgg1() {

//    egg1.innerHTML = "<img src='egg1-closed.png'>";

//    if (index == 1) {
//        egg1.innerHTML = "<img src='egg2-open.png'>";
//    }
//    if (index == 2) {
//        egg1.innerHTML = "<img src='egg3-double.png'>";
//    }
//    if (index == 3) {
//        egg1.innerHTML = "<img src='egg1-closed.png'>";
//    }
//    index++;

//    if (index > 3) {
//        index = 1;
//    }
//}

//let egg2 = document.getElementById("egg2")

//function changeEgg2() {

//    egg2.innerHTML = "<img src='egg1-closed.png'>";

//    if (index == 1) {
//        egg2.innerHTML = "<img src='egg2-open.png'>";
//    }
//    if (index == 2) {
//        egg2.innerHTML = "<img src='egg3-double.png'>";
//    }
//    if (index == 3) {
//        egg2.innerHTML = "<img src='egg1-closed.png'>";
//    }

//    index++;

//    if (index > 3) {
//        index = 1;
//    }
//}

//let egg3 = document.getElementById("egg3")

//function changeEgg3() {

//    egg3.innerHTML = "<img src='egg1-closed.png'>";

//    if (index == 1) {
//        egg3.innerHTML = "<img src='egg2-open.png'>";
//    }
//    if (index == 2) {
//        egg3.innerHTML = "<img src='egg3-double.png'>";
//    }
//    if (index == 3) {
//        egg3.innerHTML = "<img src='egg1-closed.png'>";
//    }

//    index++;

//    if (index > 3) {
//        index = 1;
//    }
//}





















