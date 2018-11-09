var validateName = /^[a-zA-Z]{2,}$/;
var validatePhone = /^[(]{0,1}[0-9]{3}[)]{0,1}[-\s\.]{0,1}[0-9]{3}[-\s\.]{0,1}[0-9]{4}$/;
var validateEmail = /[A-z0-9]{4,}@[A-z0-9]{2,}\.[A-z0-9]{1,}$/;
var validatePW = /^(([A-z]*[0-9]+)|([0-9]*[A-z]+)|([A-z]*[0-9]+[A-z]+)){8,}$/;

var validFirst = function () {
    if (document.getElementById("FirstName").value.match(validateName)) {
        document.getElementById("message").innerHTML = "Valid"; 
    }
    else
    {
        document.getElementById("message").innerHTML = "Please use a valid name";

    }
}

var validLast = function () {
    if (document.getElementById("LastName").value.match(validateName)) {
        document.getElementById("message1").innerHTML = "Valid";
    }
    else {
        document.getElementById("message1").innerHTML = "Please use a valid name";
    }
}

var validPhone = function () {
    if (document.getElementById("PhoneNumber").value.match(validatePhone)) {
        document.getElementById("message2").innerHTML = "Valid";
    }
    else {
        document.getElementById("message2").innerHTML = "Please use a valid phone number";
    }
}

var validEmail = function () {
    if (document.getElementById("Email").value.match(validateEmail)){
        document.getElementById("message3").innerHTML = "Valid";
    }
    else {
        document.getElementById("message3").innerHTML = "Please use a valid Email";
    }
}

var validPW = function () {
    if (document.getElementById("Password").value.match(validatePW))
        {
        document.getElementById("message4").innerHTML = "Valid";
    }
    else {
        document.getElementById("message4").innerHTML = "Password must be 8 characters and must have atleast 1 Number";
    }
}