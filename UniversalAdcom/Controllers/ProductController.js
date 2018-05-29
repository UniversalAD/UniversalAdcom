var app = angular.module('prodDesc', []);

app.controller('prodDescController', function ($scope) {

    $scope.product;
    $scope.magnets = function () {
        $scope.product = {
            heading: "Magnets",
            desc: "This is where the desc goes",
            printarea: "not sure what this is",
            color: "blue",
            mainImg: "https://placeimg.com/450/350/any",
            thumb_one: "https://placeimg.com/75/75/nature",
            thumb_two: "https://placeimg.com/75/75/people",
            thumb_three: "https://placeimg.com/75/75/tech"
        };
    }
    $scope.totes = function () {
        $scope.product = {
            heading: "Totes",
            desc: "This is where the totes desc goes",
            printarea: "this is where we put a diagram or img",
            color: "red",
            mainImg: "https://placeimg.com/450/350/any",
            thumb_one: "https://placeimg.com/75/75/nature",
            thumb_two: "https://placeimg.com/75/75/people",
            thumb_three: "https://placeimg.com/75/75/tech"
        }
    }
    $scope.cups = function () {
        $scope.product = {
            heading: "Cups",
            desc: "This is where we need a desc for cups.",
            printarea: "This where the print dementions go",
            color: "no color",
            mainImg: "https://placeimg.com/450/350/any",
            thumb_one: "https://placeimg.com/75/75/nature",
            thumb_two: "https://placeimg.com/75/75/people",
            thumb_three: "https://placeimg.com/75/75/tech"
        }
    }
    $scope.shirts = function () {
        $scope.product = {
            heading: "Shirts",
            desc: "this is where we are puting the shirts desc",
            printarea: "this is where the dimensions go",
            color: "black",
            mainImg: "https://placeimg.com/450/350/any",
            thumb_one: "https://placeimg.com/75/75/nature",
            thumb_two: "https://placeimg.com/75/75/people",
            thumb_three: "https://placeimg.com/75/75/tech"
        }
    }
    $scope.koosie = function () {
        $scope.product = {
            heading: "Koosie",
            desc: "Thsi si were we want to put eh desc for koosie",
            printarea: "this dimneiosn go hereereee",
            color: "green",
            mainImg: "https://placeimg.com/450/350/any",
            thumb_one: "https://placeimg.com/75/75/nature",
            thumb_two: "https://placeimg.com/75/75/people",
            thumb_three: "https://placeimg.com/75/75/tech"
        }
    }
    $scope.backpacks = function () {
        $scope.product = {
            heading: "Backpacks",
            desc: "this is where the backpack desc goes",
            printarea: "This is where we would put the dimesions",
            color: "this olors",
            mainImg: "https://placeimg.com/450/350/any",
            thumb_one: "https://placeimg.com/75/75/nature",
            thumb_two: "https://placeimg.com/75/75/people",
            thumb_three: "https://placeimg.com/75/75/tech"
        }
    }

    $scope.thumbOneSwap = function (event) {
        var prodImg = $(".prodImg").attr("src");
        var Id = event.target.id;
        var thumbOneImgSrc = $("#thumbOne").attr("src");
        var thumbTwoImgSrc = $("#thumbTwo").attr("src");

        if (Id == "thumbOne") {

            $scope.product.mainImg = thumbOneImgSrc,
                $scope.product.thumb_one = prodImg
        }
        else if (Id == "thumbTwo") {
            $scope.product.mainImg = thumbTwoImgSrc,
                $scope.product.thumb_two = prodImg
        }
    }
});
