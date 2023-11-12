<!DOCTYPE html>
<html>
<head>
	<title>Ejemplo de ASP</title>
</head>
<body>
<h1>Ejemplo de uso de bases de datos con ASP y ADO</h1>
<form action="procesa.ASP" method="post">
	<table>
		<tr>
			<td>Nombre:</td>
			<td><input type="text" name="nombre" size="20" maxlength="30"></td>
		</tr>
		<tr>
			<td>Apellidos:</td>
			<td><input type="text" name="apellido" size="20" maxlength="30"></td>
		</tr>
	</table>
	<input type="submit" name="accion" value="Grabar">
</form>
<hr>
<%
	Dim conexion, registro, objRS

	set conexion = Server.CreateObject("ADODB.Connection")
	conexion.Open("DRIVER = {Microsoft Acces Driver(*.mdb)}; DBQ = " & Server.MapPath("datos.mdb"))
	registro = "SELECT Nombre, Apellido FROM prueba"
	set objRS = conexion.Execute(registro)
%>
<table border="1" cellspacing="1" cellpadding="1">
	<tr>
		<td>&nbsp;Nombre</td>
		<td>&nbsp;Apellido&nbsp;</td>
	</tr>
</table>
<%
	while (not objRS.Eof)
		Response.Write("<tr><td>&nbsp;" & objRS("Nombre") & "</td><td>&nbsp;" & objRS("Apellido") & "&nbsp;</td></tr>")
		objRS.MoveNext
	wend
		conexion.Close
		set objRS = nothing
		set conexion = nothing
%>
</body>
</html>