
function getId(id) {
    return document.getElementById(id)
}

let wrongPrename = getId("validationPrename");

function validatePreName() {
    let preName = getId("InputPrename").value;
    if (preName == "") {
        wrongPrename.innerText = "Du måste fylla i ett förnamn";
        return false;
    }
    else {
        return true;
    }
}


let wrongLastname = getId("validationLastname");

function validateLastName() {
    let lastName = getId("InputLastname").value;
    if (lastName == "") {
        wrongLastname.innerText = "Du måste fylla i ett efternamn";
        return false;
    }
    else {
        return true;
    }
}


let wrongMessage = getId("validationMessage");

function validateMessage() {
    let message = getId("FormControlTextarea1").value;
    if (message == "") {
        wrongMessage.innerText = "Du måste fylla i ett meddelande";
        return false;
    }
    else {
        return true;
    }
}

let wrongEmail = getId("validationEmail");

function validateEmail() {
    let email = getId("InputEmail").value;
    if (email == "") {
        wrongEmail.innerText = "Du måste fylla i en email";
        return false;
    }
    else {
        return true;
    }
}

let wrongTelephonenumber = getId("validationTelephoneNumber")

function validateTelephonenumber() {
    let telephoneNumber = getId("InputTelephoneNumber").value;
    let theValueEnteredIsAnumber = telephoneNumber == parseInt(telephoneNumber);

    if (theValueEnteredIsAnumber == true) {
        return true;
    }
    else {
        wrongTelephonenumber.innerText = "Du måste ange en siffra";
        return false;
    }
}

function validate() {
    let trueNumber = validateTelephonenumber();
    let truePreName = validatePreName();
    let trueLastName = validateLastName();
    let trueMessage = validateMessage();
    let trueEmail = validateEmail();

    if (trueNumber && truePreName && trueLastName && trueMessage && trueEmail) {
        location.href = 'thankyou.html';
    }
}


document.getElementById("submit").addEventListener("click", validate);




