#!/bin/bash

apt-get update
apt-get install  build-essential -y
apt-get install openjdk-8-jdk -y

apt-get install apache2 php mysql-server php-mysql -y

service apache2 start
service mysql start

cp -r gameServer /var/www/html/


db='menagerie'
echo "CREATE DATABASE $db" | mysql --user=root --password=abcde
mysql $db --user=root --password=abcde < gameserver.sql
