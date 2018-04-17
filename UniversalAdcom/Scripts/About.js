$("#campaignButton").click(function () {
    var hidden = $("#hidden").val("True");
    console.log(hidden.val());
    $(".modalHeading").text("Congratulations!");
    $(".first").text("You made a great decision and we'd be happy to send you some more information regarding our campaigns.");
});

$("#distributorButton").click(function () {
    var hidden = $("#hidden").val("False");
    console.log(hidden.val());
    $(".modalHeading").text("BECOME A DISTRIBUTOR");
    $(".first").text("FREE marketing materials & constant community presence!");
});