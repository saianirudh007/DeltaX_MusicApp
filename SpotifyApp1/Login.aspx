<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SpotifyApp1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous"/>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.3.0/font/bootstrap-icons.css"/>
    <style>
        body{
                background-image: url('SongImages/mbg.jpg');
                background-repeat: no-repeat;
                background-attachment: fixed;
                background-size: 100% 100%;
            }
            #div1{
            display: flex;
            justify-content: center;
            align-items: center;
            height: 600px;
        }
        #div2
        {
            width: 600px;
            text-align: center;
            color: white;
            background-color: rgba(38, 207, 117, 0.988);
            padding: 20px;
        }
    </style>
</head>
<body>
    
    <form id="form1" runat="server">
    <div id="div1">
            <div id="div2">
                <h2>Login Form</h2>
                <br/>
                 <asp:TextBox ID="TextBox1" runat="server" placeholder="Enter your username" class="form-control w-50 m-auto mb-3"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Username is Required" ForeColor="Red" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
                <br />
                 <asp:TextBox ID="TextBox2" TextMode="Password"  runat="server" placeholder="Enter your Password" class="form-control p-2 w-50 m-auto mt-3"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Password is Required" ForeColor="Red" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
               
                
                  <br /> <asp:Button ID="Button1" runat="server" class="btn btn-success m-3" OnClick="Button1_Click" Text="Login"/>
                <br/>
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br />     
                <a href="Signup.aspx">New User? Create an account.</a>
            </div>
        </div>
        </form>
</body>
</html>
