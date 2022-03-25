function hostname(){
    return window.location.protocol + "//" + window.location.hostname;
}

async function postData(url = '', data = {}) {
    // Default options are marked with *
    const response = await fetch(url, {
        method: 'POST', // *GET, POST, PUT, DELETE, etc.
        mode: 'cors', // no-cors, *cors, same-origin
        cache: 'no-cache', // *default, no-cache, reload, force-cache, only-if-cached
        credentials: 'include', // include, *same-origin, omit
        headers: {
            'Content-Type': 'application/json'
            // 'Content-Type': 'application/x-www-form-urlencoded',
        },
        redirect: 'follow', // manual, *follow, error
        referrerPolicy: 'no-referrer', // no-referrer, *client
        body: JSON.stringify(data) // body data type must match "Content-Type" header
    });
    const result = await response.json(); // parses JSON response into native JavaScript objects
    return [response.status, result];
}

function isSuccessful(data){
    const firstDigitStr = String(data[0])[0];
    if (firstDigitStr == '4' || firstDigitStr == '5'){
        alert(data[1].errorType +': ' + data[1].description);
        return false;
    }
    return true;
}

