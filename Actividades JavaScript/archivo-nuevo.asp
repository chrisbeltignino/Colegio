<!DOCTYPE html>
<html>
<head>
	<title></title>
</head>
<body>

<%
  dim con,sql,rs
  set con= server.CreateObjects("ADODB.Connection")
con.open"Provider=Microsoft.Jet.OLEDB.4.0;Data source="& server.MapPath("bd.mdb")
ser rs=Server.CreateObjects("ADODB.Recorset")
  if request.form("txtnombre")=""then
  	response.write("<center><b>Debes rellenar el campo</b></center>")
    else

      if request.form("txtpass")=""then
      	response.write("<center><b>Debes ingresar la contraseña</b></center>")
      	 else 


    sql="select*from tabla 1 where (Nombre Like""& request.form )"

%>

</body>
</html>