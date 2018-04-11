
    $(document).ready(function () {

        $('.nav-icon').click(function () {

            if ($(".slide-container").hasClass("open")) {
                $(".slide-container").animate({
                    "left": "-9999",
                    "transition": "2s ease-in-out"
                }, 500);
                $(".slide-container").removeClass("open");
                $("#iconSwitch").css({
                    transform: "rotate(0deg)",
                    transition: "1s ease-in-out"
                })
            }
            else {
                $(".slide-container").animate({
                    "left": "0",
                    "transition": "2s ease-in-out"
                }, 500);
                $(".slide-container").addClass("open");
                $("#iconSwitch").css({
                    transform: "rotate(45deg)",
                    transition: "1s ease-in-out"
                });
            }
        });

        if ($(window).width() < 767) {
            $(".dropdown-menu").hide();
            $(".small-nav").show();
        };
    });

