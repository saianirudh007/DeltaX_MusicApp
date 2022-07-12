<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TopArtistDisplay.aspx.cs" Inherits="SpotifyApp1.TopArtistDisplay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Top Artists</title>
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
    <script>
        function show() {
            var xmlhttp = new XMLHttpRequest();
            xmlhttp.open("GET", "Topartists.aspx", false);
            xmlhttp.send(null);

            document.getElementById("data").innerHTML = xmlhttp.responseText;
        }
    </script>
</head>
<body onload="show()">
    <form id="form1" runat="server">
         <div class="navbar navbar-expand-lg bg-success p-2">
            <div class="container-fluid">
                <div class=" d-flex">
                    <a href="HomePageDisplay.aspx" class="navbar-brand text-white" >MINIGIC</a>                    
                    <a href="HomePageDisplay.aspx" class="nav-link me-2 text-white"><span class="bi bi-house"> Home</span></a>
                    <a href="TopsongsDisplay.aspx" class="nav-link  me-2 text-white"><span class="bi bi-music-note-beamed"> Top 10 Songs</span></a>
                    <a href="#" class="nav-link  me-2 text-white"><span class="bi bi-person"> Top 10 Artists</span></a>    
                </div>
                <a href="NewSong.aspx" class="nav-link  me-2 text-white"><span class="bi bi-plus-circle"> Add Song</span></a>
            </div>
        </div>

        <div id="data"></div>
    </form>
</body>
</html>
