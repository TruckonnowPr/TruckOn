function SelectAssining(idOrderAndIdDriver, baseUrl) {
    let statusResponse;
    console.log('')
    if (idOrderAndIdDriver != "") {
        let idOrder = idOrderAndIdDriver.split(',')[0];
        let idDriver = idOrderAndIdDriver.split(',')[1];
        let url = baseUrl+"/Dashbord/Assign";
        let xmlHttp = new XMLHttpRequest();
        var body = 'idOrder=' + encodeURIComponent(idOrder) +
            '&idDriver=' + encodeURIComponent(idDriver);
        xmlHttp.open("POST", url, false);
        xmlHttp.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');
        xmlHttp.setRequestHeader('Accept-Encoding', 'br');
        xmlHttp.send(body);
        statusResponse = xmlHttp.responseText;
    }
    if (statusResponse == "True") {
        window.location.reload();
    }
}