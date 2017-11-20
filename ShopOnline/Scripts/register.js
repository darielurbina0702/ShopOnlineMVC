$(document).ready(function()
{ 
    $("#RoleName").change(function()
    {
        if($("#RoleName").val() === "Customer") {           
            $("#CustomerBalance").show();
        }
        else {           
            $("#CustomerBalance").hide();
        }
    }); 
});