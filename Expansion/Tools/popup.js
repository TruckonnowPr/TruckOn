let clicker = document.querySelector('#keyBtn');
clicker.addEventListener("click", sinIn);
function sinIn() {
    let key = document.querySelector('#key').value;
    let body = encodeURIComponent(key);
    chrome.tabs.query({ active: true, currentWindow: true }, function (tabs) {
        chrome.tabs.sendMessage(tabs[0].id, { body: body }, function (response) {
            
        });
    });
}