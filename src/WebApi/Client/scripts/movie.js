function searchMovie() {
    const title = $("#title").val();
    const year = $("#year").val();
    const plot = $("#plot").val();
    const jsonData = {};
    jsonData['Title'] = title;
    jsonData['Year'] = year;
    jsonData['PlotVersion'] = plot;
    postData(  api() + '/Movies/GetByParams', jsonData )
        .then((response) => {
            if (isSuccessful(response)){
                const txt = document.getElementById("data");
                txt.innerHTML = JSON.stringify(response[1]);
            }
        });
}