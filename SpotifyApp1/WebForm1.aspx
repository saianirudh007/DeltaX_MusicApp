<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SpotifyApp1.WebForm1" %>

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
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <asp:DropDownList ID="dd_country" runat="server">
                    <asp:ListItem Value="">Please Select Country</asp:ListItem>
                    <asp:ListItem>India</asp:ListItem>
                    <asp:ListItem>USA</asp:ListItem>
                     </asp:DropDownList>
            <asp:Button ID="Button1" runat="server" Text="ADD Artist" OnClick="Button1_Click" />
            <asp:Image ID="Image1" runat="server"/>       
            <asp:Button ID="Button2" runat="server" Text="Submit" OnClick="Button2_Click" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>

            <asp:DropDownList ID="DropDownList1" runat="server"> 
                
            </asp:DropDownList>

            <asp:ListBox ID="listbox1" runat="server" SelectionMode="Multiple" >
        
            </asp:ListBox>

            <asp:Button ID="Button3" runat="server" Text="OK" OnClick="Button3_Click" />
           
        </div>
        
    </form>
</body>
</html>
