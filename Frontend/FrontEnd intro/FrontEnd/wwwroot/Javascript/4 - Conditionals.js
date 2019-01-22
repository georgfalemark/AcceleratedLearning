

//cond1();
//cond2();
//cond3();
//cond4();
//cond5();
//cond6();
//cond7();
//cond8();
//cond9();







function cond1() {

    /*
	    Skapa en variabel shoeMaria och sätt till 36
	    Skapa en variabel shoeAli och sätt till 42
	    Skriv en if-sats som kollar om de har samma skostorlek (skriv ut olika texter)
	    Experimentera med att ändra värden på "shoeMaria" och "shoeAli"
    */

    let shoeMaria = 42;
    let shoeAli = 19;

    if (shoeMaria < 20 || shoeAli < 20) {
        console.log("Nån av de har pyttesmå skor ");
    }

    if (shoeAli == shoeMaria) {
        console.log("De har samma skostorlek! ");
    }
    else {
        console.log("Amen de har olika skostorlekar");
    }

}

function cond2() {

    /*
	    Kolla om Ali har större skostolek än Maria
	    Skriv ut lämpligt meddelande
    */

    let shoeMaria = 42;
    let shoeAli = 44;

    if (shoeAli > shoeMaria) {
        console.log("Ali har störst skostorlek");
    }
    else if (shoeAli < shoeMaria) {
        console.log("Maria har störst skostorlek");
    }
    else {
        console.log("De har lika stora skor... ");
    }

}

function cond3() {

    /*
	    Samma som sist, men kolla även om de har samma skostorlek
    */

    let shoeMaria = 44;
    let shoeAli = 44;

    if (shoeAli > shoeMaria) {
        console.log("Ali har störst skostorlek");
    }
    else if (shoeAli < shoeMaria) {
        console.log("Maria har störst skostorlek");
    }
    else {
        console.log("De har lika stora skor... ");
    }

}

function cond4() {

    /*
	    Lägg till en till variabel "bigFoot" med skostorlek 52
	    Skriv en if-sats som kolla om bigFoot har större skostorlek än både Ali och Maria
    */

    let shoeMaria = 44;
    let shoeAli = 42;
    let shoeBig = 52;

    if (shoeBig > shoeMaria && shoeBig > shoeAli) {
        console.log("BigFoot har riktigt stora fötter");
    }
    else {
        console.log("Maria eller Ali har större fötter än bigfoot... ");
    }
}

function cond5() {

    /*
	    Skriv en ifsats som kollar om någon av de tre har en skostorlek som är större än 50
    */

    let shoeMaria = 44;
    let shoeAli = 42;
    let shoeBig = 52;

    if (shoeMaria > 50 || shoeAli > 50 || shoeBig > 50) {
        console.log("Någon av de har större skostorlek än 50");
    }
    else {
        console.log("Ingen av dem har skostorlek större än 50 ");
    }

}

function cond6() {

    /*
	    Skapa en variabel "favoriteVegetable" och sätt den till "kålrot"
	    Använd en switch-sats för att kolla värdet på "favoriteVegetable" och svara på olika sätt
	    Om t.ex värdet av "favoriteVegetable" är "majrova" skriv "Passar till falafel"
    */

    let favoriteVegetable = "kålrot";

    switch (favoriteVegetable) {
        case "kålrot":
            console.log("Passar till gurka! ");
            break;
        case "majrova":
            console.log("Passar till falafel! ");
            break;
        case "morot":
            console.log("Passar till dipp! ");
            break;
    }

}

function cond7() {

    /*
	    Samma som sist men skapa först en variabel "answer"
	    Istället för att använda "console.log" inuti switch-satsen så sätt variabel "answer"
	    Använd tillslut "console.log" för att skriva ut värdet av "answer"
    */

    let favoriteVegetable = "kålrot";
    let answer;

    switch (favoriteVegetable) {
        case "kålrot":
            answer = "Passar till gurka!";
            break;
        case "majrova":
            answer = "Passar till falafel!";
            break;
        case "morot":
            answer = "Passar till dipp!";
            break;
    }

    console.log(answer);
}

function cond8() {


    /*
        Jämför == och === i en ifsats
        Testa med en ifsats om 3=="3" är sant
        Testa med en ifsats om 3==="3" är sant
    */

    if (3 == "3") {
        console.log("Sant med == ");
    }
    if (3 === "3") {
        console.log("Sant med === ");
    }
    else {
        console.log("Inte sant med === ");
    }

}

function cond9() {

    /*
        Övning i "ternary operator"
        Skapa en variabel a och sätt den till 13*13
        Skapa en variabel b och sätt den till 169
        Använd "ternary operator" för att kolla om de är lika. Lägg svaret (strängen "lika" eller "olika") i en variabel "result"
        Skriv ut result
    */

    let a = 13 * 13;
    let b = 169;
    let result = (a === b) ? "Lika" : "Olika";
    console.log(result);

}