FROM php:7.4-fpm-alpine as base

WORKDIR /app

COPY php.ini /usr/local/etc/php/conf.d/php.override.ini
COPY www.conf /usr/local/etc/php-fpm.d/www.conf

CMD ["php-fpm", "--nodaemonize"]
