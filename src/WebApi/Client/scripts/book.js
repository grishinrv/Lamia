function searchBook() {
    let isbn = $("#isbn").val();
    getData(  api() + '/Book/GetByIsbn?isbn=' +isbn )
        .then((response) => {
            if (isSuccessful(response)){
                alert(response[1])
            }
        });
}