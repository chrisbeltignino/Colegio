<!DOCTYPE html>
<html>
<head>
	<title></title>
</head>
<body>

<%

dim sql, con, rs, color set con = server.createObject("ADODB.Connection")
con.open "Provider = Microsoft.Jet.OLEDB.4.0; Data source =" & server.MapPath("bd.mdb")
set rs = server.createObject ("ADODB.Recordset")

if request.form ("txtnombre") = "" then
	response.write ("<center><b>Debes Ingresar el Nombre del Usuario</b></center>")
else
	sql= "SELECT * FROM Tabla1 WHERE (Nombre LIKE " & request.form ("txtnombre") & ")" 
	rs.open sql,con

	if rs.eof and rs.bof then
		response.write("<center><b>El Usuario NO EXISTE</b></center>")
	else
		if request.form ("txtpass") = "" then
			response.write ("<center><b>Debes ingresar la Contraseña</b></center>")
		else
			rs.close
			sql = "SELECT * FROM Tabla1 WHERE (Password LIKE " & request.form ("txtpass") & ")"
			rs.open sql,con

			if rs.eof and rs.bof then
				response.write("<center><b>Esta Contraseña no corresponde a este usuario</b></center>")
			else
				response.write("<center><b>Bienvenido..:") & rs.fields ("Nombre") & response.write("</b></center>")
				color = rs.fields ("Color")
			end if
		end if
	end if
end if

%>

</body>
</html>