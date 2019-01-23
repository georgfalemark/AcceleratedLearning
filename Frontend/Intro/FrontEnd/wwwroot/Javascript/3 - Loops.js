

//loop1();
//loop2();
//loop3();
//loop4();
//loop5();
//loop6();
//loop7();











function loop1() {

    /*
        Använd en for-loop för att skriva ut alla siffror mellan 5 och 18
    */

    for (var i = 5; i <= 18; i++) {
        console.log(i);
    }

}

function loop2() {

    /*
        Använd en for-loop för att skriva ut alla siffror mellan 0 och 9
    */

    for (var i = 0; i <= 9; i++) {
        console.log(i);
    }

}

function loop3() {

    /*
        Använd en forloop för att skriva ut:
            "Siffran 4 är tjusig". 
            "Siffran 5 är tjusig"
            "Siffran 6 är tjusig"
            "Siffran 7 är tjusig"
            "Siffran 8 är tjusig"
    */


    for (var i = 4; i <= 8; i++) {
        console.log(`Siffran ${i} är tjusig`);
    }
}

function loop4() {

    /*
        Lös föregående uppgift men använd en while-loop
    */

    let x = 4;
    while (x <= 8) {
        console.log(`Siffran ${x} är tjusig`)
        x++;
    }

}

function loop5() {

    /*
	    Skapa en array "importantYears" med årtalen 1492, 1789, 1859, 1929
        Använd "for of" för att skriva ut alla årtal
    */

    var importantYears = [1492, 1789, 1859, 1929];
    for (var year of importantYears) {
        console.log(year);
    }
    for (var year in importantYears) {
        console.log(year);
    }

}

function loop6() {

    /*
	    Skapa en array "importantYears" med årtalen 1492, 1789, 1859, 1929
	    Använd "for of" för att skriva ut alla årtal med en siffra till vänster:
	    1) 1492
	    2) 1789
	    3) 1859
	    4) 1929
    */

    var importantYears = [1492, 1789, 1859, 1929];
    let count = 1;
    for (var year of importantYears) {
        console.log(`${count}) ${year}`)
        count++;
    }

}

function loop7() {

    /*
	    Samma som sist men avbryt loopen om årtalet är högre än 1800. Ska alltså ge:
	    1) 1492
	    2) 1789
    */

    var importantYears = [1492, 1789, 1859, 1929];
    let count = 1;
    for (var year of importantYears) {
        if (year < 1800) {
            console.log(`${count}) ${year}`)
            count++;
        }
    }

}
