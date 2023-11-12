<!DOCTYPE html>
<html>
<head>
	<title></title>
</head>
<body>

<?php
$Q = $_POST['Q'];
$D = $_POST['D'];
$H = $_POST['H'];

$pi = 3.14;
$R = $D / 2;
$V = $pi * ($R * 2) * $H;
$Vlitros = $V * 1000;
$tminutos = $Vlitros / $Q;

echo "El tiempo que transcurrira hasta el llenado del deposito es de "."$tminutos"." minutos";

?>

</body>
</html>