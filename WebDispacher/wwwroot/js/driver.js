function SendRemindInspection(idDriver, url) {
    let urlBase = url+"/Driver/Remind/Inspection";
    let xmlHttp = new XMLHttpRequest();
    var body = 'idDriver=' + encodeURIComponent(idDriver);
    xmlHttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            if (this.responseText == "true") {
                alert("Reminder sent");
            }
            else if (this.responseText == "false") {
                alert("Today's inspection was already passed");
            }
            else if (this.responseText == "notlogin") {

            }
            else if (this.responseText == "error") {
                alert("Server error, try again later");
            }
            else {
                alert("Server error, try again later");
            }
        }
        else if (this.readyState == 4 && this.status != 200) {
            alert("Server error, try again later");
        }
    };
    xmlHttp.open("POST", urlBase, true);
    xmlHttp.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');
    xmlHttp.send(body);
}

function ShowAlert(idDriver) {
    IdDriver = idDriver;
    let dialog = document.querySelector('dialog');
    dialog.hidden = '';
}

function HiddenDialog() {
    let dialog = document.querySelector('dialog');
    console.log('hidden')
    dialog.hidden = 'hidden';
}

function SelectExperience(value, Checked) {
    if (Checked) {
        if (experienceInp.value == undefined) {
            experienceInp.value = "";
        }
        experienceInp.value += value + ", ";
    }
    else {
        experienceInp.value = experienceInp.value.replace(value + ", ", "");
    }
}