<?php
// routes
$routes = [
// for root or /index.php
    '/' => 'login',
// root client
    '/client' => 'login',
// home page (books and movies querying)
    '/home' => 'home'
];

function getRequestPath() {
    $path = parse_url($_SERVER['REQUEST_URI'], PHP_URL_PATH);

    return '/' . ltrim(str_replace('index.php', '', $path), '/');
}

function getMethod(array $routes, $path) {
    // search for route
    foreach ($routes as $route => $method) {
        if (strcasecmp($path, $route) == 0) {
            return $method;
        }
    }

    return 'notFound';
}


function login() {
    include('login_form.php');
}

function home() {
    include('home.php');
}

function notFound() {
    header("HTTP/1.0 404 Not Found");

    return 'Page not found';
}

// routing
$path = getRequestPath();
// get handler function
$method = getMethod($routes, $path);
// response
echo $method();
