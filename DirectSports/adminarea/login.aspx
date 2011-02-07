<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="DirectSports.adminarea.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Direct Sports - Login</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Login ID="lgnAdminArea" runat="server" OnAuthenticate="lgnAdminArea_Authenticate" OnLoggedIn="lgnAdminArea_LoggedIn" RememberMeText="Remember Me" TitleText="">
        </asp:Login>
    </div>
    </form>
</body>
</html>
