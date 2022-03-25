<?php include 'common_header_assets.php'; ?>

<div id="myModal" class="modal fade show" aria-modal="true" style="display: block;">
    <div class="modal-dialog modal-login">
        <div class="modal-content">
            <div class="modal-header">
                <h4 class="modal-title">Member Login</h4>
            </div>
            <div class="modal-body">
                <form>
                    <div class="form-group">
                        <i class="fa fa-user"></i>
                        <input type="text" class="form-control" placeholder="Username" required="required" id="user">
                    </div>
                    <div class="form-group">
                        <i class="fa fa-lock"></i>
                        <input type="password" class="form-control" placeholder="Password" required="required" id="password">
                    </div>
                    <div class="form-group">
                        <input type="button" class="btn btn-primary btn-block btn-lg" value="Login" onclick="login()">
                    </div>
                </form>
            </div>
            <div class="modal-footer">
            </div>
        </div>
    </div>
</div>

<div class="modal-backdrop fade show"></div>
<?php include 'common_footer_assets.php'; ?>