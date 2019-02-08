
function getId(x) {
    return document.getElementById(x);
}

function clickHideObservation() {
    observationListArea.style.display = "none";
}



async function clickAddObservation() {

    let specie = getId("addAreaSpecie").value;

    let response = await fetch("observation", {
        method: "POST",
        body: JSON.stringify(
            {
                specie: specie
            }),
        headers: {
            "Content-Type": "application/json"
        }
    });

    if (response.status === 200) {
        alert("Added! ");
    }
    else {
        alert("Funkar ej :( ");
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

        for (const x of allObservations) {
            html = `<tr><td>${x.specie}</td></tr>`;
            tableRows.push(html);
        }

        let tableEnd = "</table>";

        let finalHTML = header + tableStart + tableRows.join('') + tableEnd;
        observationListArea.innerHTML = finalHTML;

        observationListArea.style.display = "inline";
    }
    else {
        alert("Funkar ej att visa alla observationer :(");
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
