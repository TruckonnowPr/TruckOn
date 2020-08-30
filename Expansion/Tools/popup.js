let clicker = document.querySelector('#loginBtn');
clicker.addEventListener("click", sinIn);
function sinIn() {
    let login = document.querySelector('#login').value;
    let password = document.querySelector('#password').value;
    let body = "Email=" + encodeURIComponent(login) + "&password=" + encodeURIComponent(password)
    //var xhttp = new XMLHttpRequest();
    //xhttp.onreadystatechange = function () {
    //    if (this.readyState == 4 && this.status == 200) {

    //    }
    //    else if (this.readyState == 4 && this.status != 200) {

    //    }
    //};
    //xhttp.open("POST", "https://172.20.10.4/Avthorization/Exst", true);
    //xhttp.send(body);
    chrome.tabs.query({ active: true, currentWindow: true }, function (tabs) {
        chrome.tabs.sendMessage(tabs[0].id, { body: body }, function (response) {
            
        });
    });
}