<!DOCTYPE html>
<html>
<head>
	<title></title>
</head>
<body>

<?php
if (isset($_POST["id"])) {
   $id = $_POST["id"];
   $ciudad = $_POST["ciudad"];
   $pais = $_POST["pais"];
   $habitantes = $_POST["habitantes"];
   $superficie = $_POST["superficie"];
   $tieneMetro = $_POST["tieneMetro"];

   $link = mysql_connect("localhost", "root");
   mysql_select_db("paisesbarraza",$link);
   mysql_query("INSERT INTO paises1 (id, ciudad, pais, habitantes, superficie, tieneMetro) VALUES ('{$_POST['id']}','{$_POST['ciudad']}','{$_POST['pais']}','{$_POST['habitantes']}','{$_POST['superficie']}','{$_POST['tieneMetro']}')",$link);
   echo "Gracias perreke, te agradecemos tu aporte y te recordamos que marta esta interesada en ti.\n";
}
?> 


</body>
</html>