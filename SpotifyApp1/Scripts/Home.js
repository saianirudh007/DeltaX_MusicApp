window.onload = () => { 
    getData();
       
}

function getData() {
    $.ajax({
        type: "GET",
        url: "HomePage.aspx/getAllSongs",
        data: JSON.stringify({ "data": "abcd" }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            console.log("test");
        },
        failure: function (e) {
            console.log("test failed");
        }
    })

}


 