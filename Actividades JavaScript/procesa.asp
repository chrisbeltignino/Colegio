<% 
	dim conexion,registro,objRS

	set conexion = server.createobject("ADOB.connection")
	conexion.Open("DRIVER={Microsoft Access Driver (*.mdb)}; DBQ=" & Server.MapPath("datos.mdb"))
	registro = "INSERT INTO prueba (Nombre, Apellido) values (" & Request.Form("Nombre") & "," & Request.Form("Apellido") & ")"
	conexion.Execute(registro)
	conexion.Close
	set conexion = nothing

	response.Redirect("ejeme.asp")
%>
