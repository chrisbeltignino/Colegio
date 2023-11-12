<?php
if (isset($_POST["id"])) {
   $id = $_POST["id"];
   $nombre = $_POST["nombre"];
   $apellido = $_POST["apellido"];
   $dni = $_POST["dni"];
   $marca = $_POST["marca"];
   $condicion = $_POST["condicion"];
   $tarjeta = $_POST["tarjeta"];
   $cuotas = $_POST["cuotas"];

   $link = mysql_connect("localhost", "root");
   mysql_select_db("mybd",$link);
   mysql_query("INSERT INTO mybd (id, nombre, apellido, dni, marca, condicion, tarjeta, cuotas) VALUES ('{$_POST['id']}',
                                                                                                        '{$_POST['nombre']}',
                                                                                                        '{$_POST['apellido']}',
                                                                                                        '{$_POST['dni']}',
                                                                                                        '{$_POST['marca']}',
                                                                                                        '{$_POST['condicion']}',
                                                                                                        '{$_POST['tarjeta']}',
                                                                                                        '{$_POST['cuotas']}')",$link);
   echo "Gracias perreke, te agradecemos tu aporte y te recordamos que marta esta interesada en ti.\n";
}
?>
