<!DOCTYPE html>
<html>
<head>
	<title></title>
</head>
<body>

<?php
$Q = $_REQUEST['Q'];
$D = $_REQUEST['D'];
$H = $_REQUEST['H'];

$pi = 3.14;
$R = $D / 2;
$V = $pi * ($R * 2) * $H;
$Vlitros = $V * 1000;
$tminutos = $Vlitros / $Q;

echo "El tiempo que transcurrira hasta el llenado del deposito es de "."$tminutos"." minutos";

?>

</body>
</html>