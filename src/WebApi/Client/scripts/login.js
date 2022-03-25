function login() {
    let user = $("#user").val();
    let password = $("#password").val();
    postData(  api() + '/Home/Login', { UserName: user, Password: password })
        .then((response) => {
            if (isSuccessful(response)){
                loadUrl(client()+'/Home');
                return false;
            }
        });

}