function searchBook() {
    let isbn = $("#isbn").val();
    getData(  api() + '/books/getByIsbn?isbn=' +isbn )
        .then((response) => {
            if (isSuccessful(response)){
                const txt = document.getElementById("data");
                txt.innerHTML = JSON.stringify(response[1]);
            }
        });
}