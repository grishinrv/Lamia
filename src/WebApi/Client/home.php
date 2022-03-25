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
            <div class="container">
            </div>
        </div>
    </div>
</div>

<!--form>
    <div class="form-group">
        <label for="exampleInputEmail1">Email address</label>
        <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Enter email">
        <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
    </div>
    <div class="form-group">
        <label for="exampleInputPassword1">Password</label>
        <input type="password" class="form-control" id="exampleInputPassword1" placeholder="Password">
    </div>
    <div class="form-check">
        <input type="checkbox" class="form-check-input" id="exampleCheck1">
        <label class="form-check-label" for="exampleCheck1">Check me out</label>
    </div>
    <button type="submit" class="btn btn-primary">Submit</button>
</form-->
<?php include 'common_footer_assets.php'; ?>