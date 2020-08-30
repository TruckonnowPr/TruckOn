function Init() {
    if (location.href.includes("https://www.centraldispatch.com/protected/dispatch/view")) {
        AddButon();
    }
}

function AddButon() {

    let elm = document.getElementsByClassName("pull-right col-xs-12 col-sm-5 col-md-4 text-right")[0];
    var button = document.createElement('button');
    button.onclick = GetOreder1;
    button.style.marginTop = "50px";
    button.style.background = "orange";
    button.style.border = "none";
    button.style.color = "white";


    var br = document.createElement('br');
    button.textContent = "Export Order";
    elm.appendChild(br);
    elm.appendChild(button);
}



function GetOreder1(event) {
    let link = location.href.replace("https://www.centraldispatch.com", "");
    let key = localStorage.getItem("key");
    if (key != undefined && key != "" && key != null) {
        let body = "linck=" + "('" + link + "')" + "&key=" + key;
        fetch('https://172.20.10.4/New', {
            method: 'post',
            body: body,
            //mode: 'no-cors',
            headers: {
                'Content-type': 'application/x-www-form-urlencoded',
                'Access-Control-Allow-Origin': '*',
                'Access-Control-Allow-Credentials': 'true'
            },
            withCredentials: true
        }).then(function (response) {
            if (response.status === 200) {
                alert("Successfully");
            }
            else {
                alert("Unsuccessfully");
            }
        });
    }
    else {
        alert("You are not logged in");
    }
}

chrome.runtime.onMessage.addListener(
    function (req, sender, response) {
        var xhttp = new XMLHttpRequest();
        xhttp.onreadystatechange = function () {
            if (this.readyState == 4 && this.status == 200) {
                if (this.responseText != "") {
                    alert("Authorization was successful");
                    localStorage.setItem("key", this.responseText);
                }
                else {

                    alert("Authorization was not successful");
                }
            }
            else if (this.readyState == 4 && this.status != 200) {

            }
        };
        xhttp.open("GET", "https://172.20.10.4/Avthorization/Exst?" + req.body, true);
        xhttp.send();
    }
);