function searchBook() {
    let isbn = $("#isbn").val();
    getData(  api() + '/books/getByIsbn?isbn=' +isbn )
        .then((response) => {
            if (isSuccessful(response)){
                alert(response[1])
            }
        });
}