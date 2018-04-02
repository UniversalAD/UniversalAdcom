    $(window).scroll(function () {
        var partner = $('#partner').offset().top,
         partnerOuterHeight = $(window).outerHeight(),
         windowHeight = $(window).height(),
         windowScroll = $(this).scrollTop();
        console.log(windowScroll);

        if ($(window).width() < 480) {
            if (windowScroll > 2200) {
                $('.circle-block').show(2000);
            }
        }
        else {
            if (windowScroll > 1500) {
                $('.circle-block').show(2000);
            }
        }
        
    });

