$("#distributorButton").click(function () {
    var hidden = $("#hidden").val("False");
    $(".modalHeading").text("BECOME A DISTRIBUTOR");
    $(".first").text("FREE marketing materials & constant community presence!");
});

$(window).scroll(function () {
    var partner = $('#partner').offset().top,
        partnerOuterHeight = $(window).outerHeight(),
        windowHeight = $(window).height(),
        windowScroll = $(this).scrollTop();
    console.log(windowScroll);

    if ($(window).width() < 480) {
        if (windowScroll > 450) {
            $(".circle > h5 > span").show(2000);
        }

        if (windowScroll > 1900) {
            $(".btn").css({
                "transform": "translate(0, 0)",
                "transition": "2s"
            });
        }
    }

    else {
        if (windowScroll > 195) {
            $(".circle > h5 > span").show(2000);
        }

        if (windowScroll > 564) {
            $(".btn").css({
                "transform": "translate(0, 0)",
                "transition": "2s"
            });
        }
    }   
});