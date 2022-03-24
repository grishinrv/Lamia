function login() {
    let user = $("#user").val();
    let password = $("#password").val();
    postData('http://localhost:4000/api/home/login', { UserName: user, Password: password })
        .then((data) => {
            console.log(data); // JSON data parsed by `response.json()` call
        });

}