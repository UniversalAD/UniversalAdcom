$(document).ready(function () {

    $(window).scroll(function () {
        var partner = $('#circles').offset().top,
            partnerOuterHeight = $(window).outerHeight(),
            windowHeight = $(window).height(),
            windowScroll = $(this).scrollTop();
        console.log(windowScroll);

        if ($(window).width() < 480) {
                $(".print").show(2000);           

            if (windowScroll > 150) {
                $('.creative-heading').show(2000);
            }

            if (windowScroll > 400) {
                $('.circles p').show(2000);
                $('.circles a').show(2000);
            }

            if (windowScroll > 700) {
                $('.distribution-heading').show(2000);
            }

            if (windowScroll > 900) {
                $('.retention-heading').show(2000);
            }

            if (windowScroll > 1150) {
                $('.awareness-heading').show(2000);
            }

            if (windowScroll > 1400) {
                $('.longevity-heading').show(2000);
            }

        }

        else {

            $(document).ready(function () {
                $(".print").show(2000);
            });

            if (windowScroll > 72) {
                $('.creative-heading').show(2000);
                $('.distribution-heading').show(2000);
                $('.circles p').show(2000);
            }

            if (windowScroll > 300) {
                $('.retention-heading').show(2000);
                $('.awareness-heading').show(2000);
                $('.circles a').show(2000);
            }

            if (windowScroll > 572) {
                $('.longevity-heading').show(2000);
            }

            if (windowScroll > 1050) {
                $('.border-bottom').show(2000);
            }
        }

    });

    if ($(window).width() < 767 & $(window).width() > 480) {
        $(".print").show(2000);
        $(".creative-heading").show(2000);
        $(".distribution-heading").show(2000);
    }
});
