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
                                   
                                },
        error: function (data) {
                                    alert(data);
                                }
    });

}