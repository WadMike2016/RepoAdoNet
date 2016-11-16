function AjaxVerifPseudo(monInput)
{
   

    //1- récupérer le texte se trouvant dans l'input
    var Proposal = monInput.value;
    // $("#Login").Val();
    // document.getElementById("Login");

    //2- Requête ajax
    $.ajax(
    {
        url: "/Ajax/CheckPseudo",
        method: "GET",
        data: { LeLoginATester: Proposal },
        contentType: 'application/json; charset=utf-8',
        success: function (data) {
            //document.getElementById("infoPseudo").innerHTML = "Pseudo libre!";
            if ($("#infoPseudo").hasClass("alert-success"))
            {
                $("#infoPseudo").removeClass("alert-success");
            }

            if ($("#infoPseudo").hasClass("alert-danger")) {
                $("#infoPseudo").removeClass("alert-danger");
            }

            if (data == "True") {
                $("#infoPseudo").html("Pseudo Libre!");
                $("#infoPseudo").addClass("alert-success");
            }
            else
            {
                $("#infoPseudo").html("Pseudo déjà attribué!");
                $("#infoPseudo").addClass("alert-danger");
            }
                                },
        error: function (data) {
            $("#infoPseudo").html("Erreur call Ajax");
                                }
    });

}