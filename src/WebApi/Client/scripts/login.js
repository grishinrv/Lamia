function login() {
    let user = $("#user").val();
    let password = $("#password").val();
    postData(  hostname() + ':4000/api/Home/Login', { UserName: user, Password: password })
        .then((response) => {
            if (isSuccessful(response)){
                console.log(data[1]); // JSON data parsed by `response.json()` call
            }
        });

}