//Please ignore this entire script. I was trying to test something out but it wasn't working. So going with my other code.
function validateName()
{
    var firstName = document.getElementById(fname).value;
    var lastName = document.getElementById(lname).value;
    var phonenum = document.getElementById(pnum).value;
    var email = document.getElementById(maile).value;
    var password = document.getElementById(pw).value;

    var fnameREGEX = /^[a-zA-Z]{2,}$/;
    var lnameREGEX = /^[a-zA-Z]{2,}$/;
    var phoneREGEX = /^[(]{0,1}[0-9]{3}[)]{0,1}[-\s\.]{0,1}[0-9]{3}[-\s\.]{0,1}[0-9]{4}$/;
    var emailREGEX = /[A-z0-9]{4,}@[A-z0-9]{2,}\.[A-z0-9]{1,}$/;
    var pwREGEX = /^(([A-z]*[0-9]+)|([0-9]*[A-z]+)|([A-z]*[0-9]+[A-z]+)){8,}$/;

    var fnameResults = fnameREGEX.test(firstName);
    var lnameResults = lnameREGEX.test(lastName);
    var phoneResults = phoneREGEX.test(phonenum);
    var emailResults = emailREGEX.test(email);
    var pwResults = pwREGEX.test(password);
    if (fnameResults === false) {
        alert("Please enter a porper first name")
        return false;
    }
    else if (lnameResults === false) {
        alert(["Please enter a proper first name"])
        return false;
    }
    else if (phoneResults === false) {
        alert("Please confirm to fill out all 9 numbers")
        return false;
    }
    else if (emailResults === false) {
        alert("Please provide a valid email")
        return false;
    }
    else if (pwResults === false) {
        alert("Please provide a proper password")
        return false;
    }
    else
    {
        return true;
    }
}