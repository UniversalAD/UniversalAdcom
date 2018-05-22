$(document).ready(function () {

    $('.hover-box').hover(

        function () {
            var target = $(this).data("target");
            console.log(target);
            $(target).show();
        },

        function () {
            $(".hover-content").hide();
        }
    );
}); 