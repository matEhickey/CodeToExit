# Code To Exit

> CodeToExit is a game made during the "24h du code" ("24 hours of coding") 2017 with a small team of 4 persons, and continued (not finished, it will never be haha) by me like 2 or 3 weeks later.  
You play as a coder, who need to solve easy programming problems to get out.  

## How to install the server
Steps to install the game server only on Unix systems (so use VirtualBox to emulate one, or use another machine on a network you are allowed to access):

~~~
git clone https://github.com/matEhickey/codeToExit
cd codeToExit
./installGameServer.sh
~~~

Maybe I forget some package cause I don’t use the exact same distribution as you. Try to figure out which one, and maybe email me these :)  
By default, set the usernames to root, and the passwords to abcde, change it you want, but remember to report the change to: /var/www/html/gameServer/paramBDD.php

## See your IP
~~~
ifconfig
And probably get that one which begin with 192.168., you’ll have to put it in the change IP panel in the game.
~~~

## Launch the server next times:
./launchGameServer.sh

## Security
By Default, the server run without sandbox protection, that mean **don’t use it for real users**, cause they could corrupt your filesystem.  
You should install Mbox and set the mbox variable in /var/www/html/gameServer/Execution/createExecution.php to true, and probably take a look at the java execution, so far I remember mbox crashed with it.