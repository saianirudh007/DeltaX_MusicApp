<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="SpotifyApp1.Signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Signup Page</title>
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
            height: 700px;
        }
        #div2
        {
            display: block;
            width: 600px;
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
                <h2 class="text-center">Sign Up form</h2>
                <table>
                    <tr>
                        <td><label> Enter you username: </label></td>
                        <td class="text-center">
                            <asp:TextBox ID="TextBox1" runat="server" class="form-control m-lg-4"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ForeColor="Red" ErrorMessage="UserName is Required" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
                        
                        </td>
                        
                            
                    </tr>
                    <tr>
                        <td><label> Enter you Email: </label></td>
                        <td class="text-center">
                            <asp:TextBox ID="TextBox2" runat="server"  class="form-control m-4"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ForeColor="Red" ErrorMessage="Email is Required" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
        
                        </td>
                        
                    </tr>
                    <tr>
                        <td><label> Enter you password: </label></td>
                        <td class="text-center">
                            <asp:TextBox ID="TextBox3" runat="server" TextMode="Password" class="form-control m-4"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ForeColor="Red" ErrorMessage="Password is Required" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>
    
                        </td>
                        
                    </tr>
                    <tr>
                        <td><label> Re-enter your password: </label></td>
                        <td class="text-center"><asp:TextBox ID="TextBox4" TextMode="Password" runat="server" class="form-control m-4"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" Display="Dynamic" runat="server" ForeColor="Red" ErrorMessage="Re Enter Password" ControlToValidate="TextBox4"></asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" Display="Dynamic" ErrorMessage="Password Not Matched" ForeColor="Red" ControlToCompare="TextBox3" ControlToValidate="TextBox4"></asp:CompareValidator>
                        
                        </td>
                        
                    </tr>

                    <tr>
                        <td></td>
                        <td>
                            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" class="btn btn-success m-lg-4"/>
                        </td>                        
                    </tr>
                </table>
            </div>
        </div>

    </form>
</body>
</html>
