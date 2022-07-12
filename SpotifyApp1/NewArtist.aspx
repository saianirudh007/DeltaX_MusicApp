<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewArtist.aspx.cs" Inherits="SpotifyApp1.NewArtist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Artist</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous"/>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.3.0/font/bootstrap-icons.css"/>
    <style>
            body{
                background-image: url('SongImages/mbg.jpg');
                background-repeat: no-repeat;
                background-attachment: fixed;
                background-size: 100% 100%;
            }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="navbar navbar-expand-lg bg-success p-2">
            <div class="container-fluid">
                <div class=" d-flex">
                    <a href="HomePageDisplay.aspx" class="navbar-brand text-white" >MINIGIC</a>                    
                    <a href="HomePageDisplay.aspx" class="nav-link me-2 text-white"><span class="bi bi-house"> Home</span></a>
                    <a href="TopsongsDisplay.aspx" class="nav-link  me-2 text-white"><span class="bi bi-music-note-beamed"> Top 10 Songs</span></a>
                    <a href="TopArtistDisplay.aspx" class="nav-link  me-2 text-white"><span class="bi bi-person"> Top 10 Artists</span></a>    
                </div>
                
            </div>
        </div>




        <div class="container p-3">
            <div class="row mt-lg-5">
                <div class="col-2">
                    <label class="form-label text-white">Enter Artist Name: </label>
                </div>
                <div class="col-lg-4">
                    
                    <asp:TextBox ID="TextBox1" runat="server" class="form-control w-75"></asp:TextBox> 
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Artist Name Required" ForeColor="Red" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
                </div>
                
            </div>

            <div class="row mt-lg-5">
                <div class="col-2">
                    <label class="form-label text-white">Date Of Birth</label>
                </div>
                <div class="col-lg-4">
                    
                    <asp:TextBox ID="Calendar1" runat="server" class="form-control w-75" TextMode="Date"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Date Of Birth Required" ForeColor="Red" ControlToValidate="Calendar1"></asp:RequiredFieldValidator>
                </div>
            </div>
            
            <div class="row mt-lg-5">
                <div class="col-2">
                    <label class="form-label text-white">Bio</label>
                </div>
                <div class="col-4 row-2">
                    <asp:TextBox ID="TextBox2" runat="server" class="form-control w-75 h-100" TextMode="MultiLine"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Bio Required" ForeColor="Red" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
                    
                </div>
                
            </div>
            <div class="row mt-lg-5">
                <div class="col-2">
                    </div>
                    <div class="col-4">
                    <asp:Button ID="Button1" runat="server" class="btn btn-success m-auto" Text="Save" OnClick="Button1_Click" />
                </div>
            </div>
            
        </div>
    </form>
</body>
</html>
