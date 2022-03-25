<html lang="en"><head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <title>Lamia login</title>
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Roboto|Varela+Round">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">
    <link rel="stylesheet" href="/styles/common.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js"></script>
    <script src="/scripts/login.js"></script>
    <script src="/scripts/http_queries.js"></script>
    <script src="/scripts/book.js"></script>
    <style>
        body {
            font-family: 'Varela Round', sans-serif;
        }
        .modal-login {
            color: #636363;
            width: 350px;
        }
        .modal-login .modal-content {
            padding: 20px;
            border-radius: 5px;
            border: none;
        }
        .modal-login .modal-header {
            border-bottom: none;
            position: relative;
            justify-content: center;
        }
        .modal-login h4 {
            text-align: center;
            font-size: 26px;
        }
        .modal-login  .form-group {
            position: relative;
        }
        .modal-login i {
            position: absolute;
            left: 13px;
            top: 11px;
            font-size: 18px;
        }
        .modal-login .form-control {
            padding-left: 40px;
        }
        .modal-login .form-control:focus {
            border-color: #00ce81;
        }
        .modal-login .form-control, .modal-login .btn {
            min-height: 40px;
            border-radius: 3px;
        }
        .modal-login .hint-text {
            text-align: center;
            padding-top: 10px;
        }
        .modal-login .close {
            position: absolute;
            top: -5px;
            right: -5px;
        }
        .modal-login .btn, .modal-login .btn:active {
            border: none;
            background: #00ce81 !important;
            line-height: normal;
        }
        .modal-login .btn:hover, .modal-login .btn:focus {
            background: #00bf78 !important;
        }
        .modal-login .modal-footer {
            background: #ecf0f1;
            border-color: #dee4e7;
            text-align: center;
            margin: 0 -20px -20px;
            border-radius: 5px;
            font-size: 13px;
            justify-content: center;
        }
        .modal-login .modal-footer a {
            color: #999;
        }
        .trigger-btn {
            display: inline-block;
            margin: 100px auto;
        }
    </style>
</head>
<body class="modal-open">