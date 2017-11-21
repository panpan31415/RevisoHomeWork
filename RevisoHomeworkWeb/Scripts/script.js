function addWorkDialog()
{
    $("#mainpage").empty();
    $("#mainpage").append($("#addWorkDialog").html());
}
$('#addWork_link').click(function () { addWorkDialog(); return false; });
