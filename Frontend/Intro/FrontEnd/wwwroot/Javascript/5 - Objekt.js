


//obj1();
//obj2();
obj3();
//obj4();








function obj1() {

    /*
        Skapa ett objekt "person" med uppgifter om Johan Rheborg: förnamn, efternamn, födelseår
        Skriv ut förnamnet
        Skriv ut hans fullständiga namn
    */

    var person = { firstName: "Johan", lastName: "Rheborg", Born: 1950 };
    console.log(person.firstName);
    console.log(`${person.firstName} ${person.lastName}`);

}

function obj2() {

    /*
       Fortsätt bygg vidare på "person"
       Lägg till ett par rollkaraktärer (Percy Nilegård, Farbror Barbro...)
       Lägg till adressuppgifter (street, city, country)
       Skriv ut info om Johan utifrån objektet "person":
            Johan är född år 1963
            Johan bor på gatan Kammakargatan 38 lgh 1401
            Johan har spelat 3 roller, bland annat Percy Nilegård
    */

    var person = {
        firstName: "Johan",
        lastName: "Rheborg",
        Born: 1950,
        Roles: ["Morran", "Percy Nilegård", "Farbror Barbro"],
        Address: { street: "Kammakargatan 38 lgh 1401", city: "Stockholm", country: "Sweden" }
    };

    console.log(`Johan är född år ${person.Born}`);
    console.log(`Johan bor på gatan ${person.Address.street}`);
    console.log(`Johan har spelat ${person.Roles.length} roller, bland annat ${person.Roles[1]}`);
}


function obj3() {

    /*
       Skapa en array "paintings" med tre målningar (tre element)
       För varje målning finns info: namn, konstnär och året den blev målad
       Skriv ut antalet målningar: "Det finns XXXst målningar"
       Skriv ut den tredje målningen t.ex: "Pablo Picasso målade Guernica år 1937"
       Loopa igenom alla målningar med "for of" och skriv ut all info i tabellform
       Tips: använd "padEnd" för att skriva ut tabellen snyggt
    */

    let paintings = [
        { name: "Skriet", artist: "Edward Munch", paintYear: 1893 },
        { name: "Goe tavlan", artist: "Picasso", paintYear: 1933 },
        { name: "The women and roses", artist: "Chagalle", paintYear: 1929 }
    ];

    console.log(`Det finns ${paintings.length} st målningar`);
    console.log(`${paintings[2].artist} målade ${paintings[2].name} år ${paintings[2].paintYear}`);

    let count = 0;
    for (let x of paintings) {
        console.log(`${paintings[count].name} ${paintings[count].artist} ${paintings[count].paintYear}`);
        count++;
    }

    for (var i = 0; i <= paintings.length; i++) {
        console.log(paintings[i].name + paintings[i].artist + paintings[i].paintYear);
    }

}

function obj4() {

    /*
       Skapa ett objekt "skriet" (av Edvard Munch 1893). Lägg till den i paintingsarrayen mha "push".
       Skriv ut dess år mha variablen "paintings" 
       Använd "pop" för att plocka bort de tre sista målningarna
       Skriv ut antalet målningar i arrayen 
    */









}

// -------- EXTRA UPPGIFTER -----------------------------------------

function objExtra1() {

    /*
       Fortsätt bygg vidare på "person"
       Lägg till en metod "fullName" till person
       Lägg till en metod "numberOfRoles" till person

       Används sedan dessa för att skriva ut:
            Johan Rheborg
            Johan Rheborg har spelat i 3 roller
    */
}