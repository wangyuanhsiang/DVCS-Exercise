﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebPage.aspx.cs" Inherits="WebPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtInput" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Button"  />
        <br />
        <br />
        <asp:Label ID="lblStatus" runat="server" ></asp:Label>
    </div>
    </form>
</body>
</html>
