<?php include 'common_header_assets.php'; ?>

<div class="container">
    <div class="row">
        <div class="col form-control">
            <p>Books</p>
        </div>
        <div class="col form-control">
            <p>Movies</p>
        </div>
    </div>
    <div class="row h-75" >
        <div class="col form-group">
            <div class="container" >
                <div class="form-group cellmargin">
                    <input type="text" class="form-control" placeholder="ISBN" id="isbn">
                </div>
                <div class="form-group cellmargin">
                    <input type="button" class="btn btn-outline-warning" value="Search book" onclick="searchBook()">
                </div>
            </div>
        </div>
        <div class="col form-group">
            <div class="container" >
                <div class="form-group cellmargin">
                    <input type="text" class="form-control" placeholder="Title" id="title">
                </div>
                <div class="form-group cellmargin">
                    <input type="text" class="form-control" placeholder="Year" id="year">
                </div>
                <div class="form-group cellmargin">
                    <input type="text" class="form-control" placeholder="Plot version" id="plot">
                </div>
                <div class="form-group cellmargin">
                    <input type="button" class="btn btn-outline-warning" value="Search movie" onclick="searchMovie()">
                </div>
            </div>
        </div>
    </div>
    <div class="row h-75" >
        <div class="form-group cellmargin" height="300">
            <label for="name" class="col-lg-4">Fetched data:</label>
            <div class="col-lg-8" >
                <p id="data"> <p/>
            </div>
        </div>
    </div>
</div>

<?php include 'common_footer_assets.php'; ?>