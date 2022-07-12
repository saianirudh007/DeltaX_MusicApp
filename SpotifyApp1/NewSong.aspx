<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewSong.aspx.cs" Inherits="SpotifyApp1.NewSong" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Song</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous"/>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.3.0/font/bootstrap-icons.css"/>
    <style>
            body{
                background-image: url('SongImages/mbg.jpg');
                background-repeat: no-repeat;
                background-attachment: fixed;
                background-size: 100% 100%;

            }
        #qw,#qw:hover {
            text-decoration:none;
            color:white;
            padding:10px;
            background-color:green;
            
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
                    <label class="form-label text-white">Enter Song Name: </label>
                </div>
                <div class="col-lg-4">
                    
                    <asp:TextBox ID="TextBox1" runat="server" class="form-control w-75"></asp:TextBox> 
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Song Name Required" ForeColor="Red" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
                </div>
                <div class="col-2">
                    <label class="form-label text-white">Released Date: </label>
                </div>
                <div class="col-lg-4">
                    
                    <asp:TextBox ID="TextBox2" runat="server" class="form-control w-75" TextMode="Date"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Date Required" ForeColor="Red" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
                </div>
            </div>

            <div class="row mt-lg-5">
                <div class="col-2">
                    <label class="form-label text-white">Upload file: </label>
                </div>
                <div class="col-9">
                 
                    <asp:FileUpload ID="FileUpload1" runat="server"/>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Image Required" ForeColor="Red" ControlToValidate="FileUpload1"></asp:RequiredFieldValidator>
                </div>
            </div>
            
            <div class="row mt-lg-5">
                <div class="col-2">
                    <label class="form-label text-white">Choose Artist</label>
                </div>
                <div class="col-4">
                    
                    <asp:ListBox ID="listbox1" runat="server" class="form-control" SelectionMode="Multiple" >
        
                    </asp:ListBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Artist Required" ForeColor="Red" ControlToValidate="listbox1"></asp:RequiredFieldValidator>
                </div>
                <div class="col-4">
                    
                     
                     <a id="qw" href="NewArtist.aspx">Add Artist</a>
                    
                </div>
            </div>
            <div class="row mt-lg-5">
                <div class="col-2">
                    </div>
                    <div class="col-4">
                    <asp:Button ID="Button2" runat="server" class="btn btn-success m-auto" Text="Save" OnClick="Button2_Click" />
                </div>
            </div>
            
        </div>


    </form>
</body>
</html>
