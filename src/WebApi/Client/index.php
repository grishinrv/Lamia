<?php
// routes
$routes = [
// for root or /index.php
    '/' => 'login',
// root client
    '/client' => 'login'
];

function getRequestPath() {
    $path = parse_url($_SERVER['REQUEST_URI'], PHP_URL_PATH);

    return '/' . ltrim(str_replace('index.php', '', $path), '/');
}

function getMethod(array $routes, $path) {
    // search for route
    foreach ($routes as $route => $method) {
        if ($path === $route) {
            return $method;
        }
    }

    return 'notFound';
}


function login() {
    include('login_form.php');
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
