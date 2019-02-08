
let eggCounter1 = 1;
let egg1 = document.getElementById("egg1");
function openEgg1() {

    if (eggCounter1 == 1) {
        egg1.src = "egg2-open.png";
    }
    if (eggCounter1 == 2) {
        egg1.src = "egg3-double.png";
    }
    if (eggCounter1 == 3) {
        egg1.src = "egg1-closed.png";
    }
    eggCounter1++;

    if (eggCounter1 > 3) {
        eggCounter1 = 1;
    }
}

let eggCounter2 = 1;
let egg2 = document.getElementById("egg2");
function openEgg2() {

    if (eggCounter2 == 1) {
        egg2.src = "egg2-open.png";
    }
    if (eggCounter2 == 2) {
        egg2.src = "egg3-double.png";
    }
    if (eggCounter2 == 3) {
        egg2.src = "egg1-closed.png";
    }
    eggCounter2++;

    if (eggCounter2 > 3) {
        eggCounter2 = 1;
    }
}

let eggCounter3 = 1;
let egg3 = document.getElementById("egg3");
function openEgg3() {

    if (eggCounter3 == 1) {
        egg3.src = "egg2-open.png";
    }
    if (eggCounter3 == 2) {
        egg3.src = "egg3-double.png";
    }
    if (eggCounter3 == 3) {
        egg3.src = "egg1-closed.png";
    }
    eggCounter3++;

    if (eggCounter3 > 3) {
        eggCounter3 = 1;
    }
}

