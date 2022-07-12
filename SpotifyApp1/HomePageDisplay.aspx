<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePageDisplay.aspx.cs" Inherits="SpotifyApp1.HomePageDisplay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Page</title>

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
            xmlhttp.open("GET", "HomePage.aspx", false);
            xmlhttp.send(null);

            document.getElementById("data").innerHTML = xmlhttp.responseText;
        }
        var songname = "";
        var rate = "";
        function change(ob) {
            var song = document.getElementById(ob.title).children;
            for (i = 0; i <= song.length - 1; i++) {
                if (i < ob.id) {
                    song[i].className = "bi bi-star-fill"
                    
                } else {
                    song[i].className = "bi bi-star"
                }
            }
            console.log(ob.title + " " + ob.id);
            songname = ob.title;
            rate = ob.id;

            
        }

        function postData(ob) {
            if (ob.id == songname)
            {
                console.log(songname + " " + rate);
                var xmlhttp = new XMLHttpRequest();
                xmlhttp.open("GET", "WebForm3.aspx?song=" + songname + "&rate=" + rate, false);
                xmlhttp.send(null);
                alert("Review Submitted Succesfully");
            }
            

        }

    </script>

</head>
<body onload="show()">

    <div class="navbar navbar-expand-lg bg-success p-2">
            <div class="container-fluid">
                <div class=" d-flex">
                    <a href="#" class="navbar-brand text-white" >MINIGIC</a>                    
                    <a href="#" class="nav-link me-2 text-white"><span class="bi bi-house"> Home</span></a>
                    <a href="TopsongsDisplay.aspx" class="nav-link  me-2 text-white"><span class="bi bi-music-note-beamed"> Top 10 Songs</span></a>
                    <a href="TopArtistDisplay.aspx" class="nav-link  me-2 text-white"><span class="bi bi-person"> Top 10 Artists</span></a>    
                </div>
                <a href="NewSong.aspx" class="nav-link  me-2 text-white"><span class="bi bi-plus-circle"> Add Song</span></a>
            </div>
        </div>

    <%--<input id="Button1" type="button" value="Add Song" class="btn btn-danger" />--%>
    
    
    <div id="data">

    </div>
</body>
</html>
