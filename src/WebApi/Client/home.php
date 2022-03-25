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
                <!--div class="form-group cellmargin">
                    <label for="name" class="col-lg-4">Name:</label>
                    <div class="col-lg-8">
                        <input type="text" class="form-control classname" readonly id="bookname" />
                    </div>
                </div-->
            </div>
        </div>
        <div class="col form-group">
            <div class="container">
            </div>
        </div>
    </div>
</div>

<?php include 'common_footer_assets.php'; ?>