<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="SpotifyApp1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:Button ID="Button2" runat="server" Text="Display" OnClick="Button2_Click" />
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>  
            <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>         
        </div>
    </form>
</body>
</html>
