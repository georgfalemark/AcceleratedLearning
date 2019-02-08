

ShowAllObservations();


function getId(x) {
    return document.getElementById(x);
}


async function clickAddObservation() {

    let specie = getId("addAreaSpecie").value;
    let date = getId("addAreaDate").value;
    let location = getId("addAreaLocation").value;
    let notes = getId("addAreaNotes").value;


    let responseValidate = await fetch(`observation/unique?date=${date}&location=${location}&specie=${specie}`, { method: "GET" });

    if (responseValidate.status === 200) {

        let allObservations = await responseValidate.json();

        if (allObservations == true) {
            var conf = window.confirm("En fågel med detta namn har redan lagts till på samma dag och plats. Vill du lägga till observationen ändå? ");
            if (conf == true) {

                let response = await fetch("observation", {
                    method: "POST",
                    body: JSON.stringify(
                        {
                            specie: specie,
                            date: date,
                            location: location,
                            notes: notes
                        }),
                    headers: {
                        "Content-Type": "application/json"
                    }
                });

                if (response.status === 200) {
                    ShowAllObservations();
                }
                else {
                    alert("Funkar ej :( ");
                }

            } else {
                return;
            }
        }
        else {

            let response = await fetch("observation", {
                method: "POST",
                body: JSON.stringify(
                    {
                        specie: specie,
                        date: date,
                        location: location,
                        notes: notes
                    }),
                headers: {
                    "Content-Type": "application/json"
                }
            });

            if (response.status === 200) {
                ShowAllObservations();
            }
            else {
                alert("Funkar ej :( ");
            }
        }
    }
}




async function recreateDatabase() {
    document.getElementById("recreateButton").style.display = "none";
    document.body.style.backgroundColor = "blue";
    let response = await fetch("/observation/recreate", {
        method: "POST"
    });

    if (response.status === 200) {
        document.getElementById("recreateButton").style.display = "block";
        document.body.style.backgroundColor = "green";

    } else {
        document.getElementById("recreateButton").style.display = "block";
        document.body.style.backgroundColor = "red";

    }

}





let observationListArea = getId("observationList");
async function ShowAllObservations() {

    let response = await fetch(`observation/`, { method: "GET" });

    if (response.status === 200) {

        let allObservations = await response.json();

        let html = "";
        var tableRows = [];
        let header = "<h3>All observations</h3>";
        let tableStart = "<table>";
        let tableTitles = "<tr><th>Date</th><th>Species</th><th>Location</th><th>Notes</th></tr>";

        for (const x of allObservations) {

            html = `<tr><td>${x.date}</td><td>${x.specie}</td><td>${x.location}</td><td>${x.notes}</td></tr>`;
            tableRows.push(html);
        }

        let tableEnd = "</table>";
        let finalHTML = header + tableStart + tableTitles + tableRows.join('') + tableEnd;

        let html2 = "";
        var tableRows2 = [];
        let header2 = "<h3>Species</h3>";
        let tableStart2 = "<table>";

        var sortSpecies = [];
        for (const y of allObservations) {
            sortSpecies.indexOf(y.specie) === -1 ? sortSpecies.push(y.specie) : console.log("This item already exists");
        }

        sortSpecies.sort();
        for (const sp of sortSpecies) {
            html2 = `<tr><td>${sp}</td></tr>`;
            tableRows2.push(html2);
        }

        let tableEnd2 = "</table>";
        let finalHTML2 = header2 + tableStart2 + tableRows2.join('') + tableEnd2;


        let divStart = "<div>";
        let divEnd = "</div>";
        let superHTML = divStart + finalHTML + finalHTML2 + divEnd;

        observationListArea.innerHTML = superHTML;
    }
    else {
        alert("Funkar ej att visa alla observationer :(");
    }
}












