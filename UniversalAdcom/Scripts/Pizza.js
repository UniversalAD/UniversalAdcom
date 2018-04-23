$(document).ready(function () {
    $(".head-2").css({
        "transform": "translate(0, 0)",
        "transition": "2s"
    });

    $(".head-3").css({
        "transform": "translate(0,0)",
        "transition": "2s"
    });

    $(".dog").css({
        "transform": "translate(0,0)",
        "transition": "2s",
        "transition-delay": "1.5s"
    });
});

$("#requestinfo").click(function () {
    var hidden = $("#hidden").val("False");
    $(".modalHeading").text("Request Info About A DISTRIBUTOR Near You!");
    $(".first").text("With over 7500 distribution partners nationwide & thousands of campaigns being printed monthly, we make it easier than ever 4U to interact with your local customers.");
});

$(window).scroll(function () {
    var partner = $('#partner').offset().top,
        partnerOuterHeight = $(window).outerHeight(),
        windowHeight = $(window).height(),
        windowScroll = $(this).scrollTop();
    console.log(windowScroll);

    if ($(window).width() < 480) {

        if (windowScroll > 1763) {
            $(".content-wrapper > a").css({
                "transform": "translate(0,0)",
                "transition": "2s"
            });

            $(".content-wrapper > img").css({
                "transform": "translate(0,0)",
                "transition": "2s"
            });
        }
    }

    else {
        if (windowScroll > 1100) {
            $(".content-wrapper > a").css({
                "transform": "translate(0,0)",
                "transition": "2s"
            });

            $(".content-wrapper > img").css({
                "transform": "translate(0,0)",
                "transition": "2s"
            });
        }
    }
});