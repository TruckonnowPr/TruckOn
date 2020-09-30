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
        fetch('https://truckonnow.com/New', {
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
        fetch('https://truckonnow.com/Avthorization/Exst?' + req.body, {
            method: 'get',
            //mode: 'no-cors',

            headers: {
                'Content-type': 'application/x-www-form-urlencoded',
                'Access-Control-Allow-Origin': '*',
                'Access-Control-Allow-Credentials': 'true'
            },
            withCredentials: true
        }).then(function (response) {
            if (response.status == 200 && response.responseText != "") {
                alert("Authorization was successful");
                localStorage.setItem("key", this.responseText);
            }
            else {

                alert("Authorization was not successful");
            }
        });
    }
);