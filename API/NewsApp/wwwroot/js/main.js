console.log("Moi Mukulat!");

let addArea = getId("addArea");
addArea.style.display = "none";

let deleteArea = getId("deleteArea");
deleteArea.style.display = "none";

let updateArea = getId("updateArea");
updateArea.style.display = "none";

GetAllCategories()
ShowAllNews()

function getId(x) {
    return document.getElementById(x);
}

async function clickDeleteNews(id) {

    let response = await fetch(`api/news/${id}`, { method: "DELETE" });

    if (response.status === 204) {
        alert("Borttagen! ");
    }
    else {
        alert("Funkar tyvärr inte att ta bort din fillidutt! :(");
    }
}

async function clickSeed() {
    let response = await fetch(`api/news/seed`, { method: "POST" });

    if (response.status === 204) {
        alert("funkar! ");
    }
    else {
        alert("Funkar inte, filibunk!");
    }
}

async function clickRecreate() {
    let response = await fetch(`api/news/recreate`, { method: "POST" });

    if (response.status === 204) {
        alert("Funkar! ");
    }
    else {
        alert("INTE! :(");
    }
}

async function GetAllCategories() {
    let response = await fetch(`api/categories/`, { method: "GET" });

    let Category = getId("addAreaCategory");
    let CategoryForUpdate = getId("updateAreaCategory");

    if (response.status === 200) {

        let allCategories = await response.json();
        let html = "";
        var optionRows = [];


        for (const x of allCategories) {
            html = `<option>${x.name}</option>`;
            optionRows.push(html);
        }

        Category.innerHTML = optionRows.join('');
        CategoryForUpdate.innerHTML = optionRows.join('');
    }
}

let newsList = document.getElementById("newsList");
async function ShowAllNews() {
    let response = await fetch(`api/news/`, { method: "GET" });

    if (response.status === 200) {

        let allNews = await response.json();
        let html = "";
        var tableRows = [];

        let tableStart = "<table>";
        let tableTitles = "<tr><th>ID</th><th>Header</th><th>Intro</th><th>Body</th><th>Created</th><th>Updated</th><th>Update</th><th>Delete</th></tr>";

        for (const x of allNews) {
            html = `<tr><td>${x.id}</td><td>${x.header}</td><td>${x.intro}</td><td>${x.body}</td><td>${x.updatedDate}</td><td>${x.createdDate}</td><td><button onclick="clickShowUpdateNews(${x.id})">update</button></td><td><button onclick="clickDeleteNews(${x.id})">delete</button></td></tr>`;
            tableRows.push(html);
        }
        let tableEnd = "</table>";

        let finalHTML = tableStart + tableTitles + tableRows.join('') + tableEnd;
        newsList.innerHTML = finalHTML;
    }
    else {
        alert("Funkar ej");
    }
}

let nrOfNews = document.getElementById("nrOfNews");
async function clickStatArea() {
    let response = await fetch(`api/news/count`, { method: "GET" });

    if (response.status === 200) {
        let statistics = await response.json();
        nrOfNews.innerText = statistics;
    }
    else {
        alert("Funkar inte :( ");
    }
}

async function clickAddNews() {

    let header = getId("addAreaHeader").value;
    let category = getId("addAreaCategory").value;
    let intro = getId("addAreaIntro").value;
    let body = getId("addAreaBody").value;

    let response = await fetch("api/News", {
        method: "POST",
        body: JSON.stringify(
            {
                header: header,
                intro: intro,
                body: body,
                category: {
                    name: category
                }
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

async function clickUpdateNews() {

    let id = getId("updateAreaId").value;
    let header = getId("updateAreaHeader").value;
    let category = getId("updateAreaCategory").value;
    let intro = getId("updateAreaIntro").value;
    let body = getId("updateAreaBody").value;

    let response = await fetch("api/News", {
        method: "PUT",
        body: JSON.stringify(
            {
                id: id,
                header: header,
                intro: intro,
                body: body,
                category: {
                    name: category
                }
            }),
        headers: {
            "Content-Type": "application/json"
        }
    });

    if (response.status === 204) {
        alert("Updated! ");
    }
    else {
        alert("Funkar ej att uppdatera! :( ");
    }
}

function clickShowAddNews() {
    addArea.style.display = "inline";
}

function clickShowUpdateNews(id) {
    updateArea.style.display = "inline";
    document.getElementById("updateAreaId").value = id;
}

function clickHideAddNews() {
    addArea.style.display = "none";
}

function clickHideUpdateNews() {
    updateArea.style.display = "none";
}






































