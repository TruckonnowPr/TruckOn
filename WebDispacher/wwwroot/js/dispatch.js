function RefreshToken(idDispatch, s, url) {
    let body = "idDispatch=" + encodeURIComponent(idDispatch);
    fetch(url+'/Settings/Extension/RefreshToken', {
        method: 'post',
        body: body,
        headers: {
            'Content-type': 'application/x-www-form-urlencoded',
            'Access-Control-Allow-Origin': '*',
        },
        withCredentials: true
    }).then(async function (response) {
        if (response.status == 200) {
            s.innerText = await response.text();
        }
    });
}