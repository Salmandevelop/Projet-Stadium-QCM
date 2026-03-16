<?php
session_start();
session_destroy(); //  efface la session
header('Location: login.php'); //  renvoie vers le login
exit();
?>