$("#clicker").click(function(){
    $.ajax({
        url: "/count"
    }).done(function(data) {
        console.log(data);
        $("#count-display").val(data);
    })
})