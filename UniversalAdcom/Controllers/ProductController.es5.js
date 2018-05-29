'use strict';

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
            thumb_one: "https://placeimg.com/75/75/any",
            thumb_two: "http://via.placeholder.com/75x75",
            thumb_three: "http://via.placeholder.com/75x75"
        };
    };
    $scope.totes = function () {
        $scope.product = {
            heading: "Totes",
            desc: "This is where the totes desc goes",
            printarea: "this is where we put a diagram or img",
            color: "red",
            mainImg: "http://via.placeholder.com/450x350",
            thumb_one: "http://via.placeholder.com/75x75",
            thumb_two: "http://via.placeholder.com/75x75",
            thumb_three: "http://via.placeholder.com/75x75"
        };
    };
    $scope.cups = function () {
        $scope.product = {
            heading: "Cups",
            desc: "This is where we need a desc for cups.",
            printarea: "This where the print dementions go",
            color: "no color",
            mainImg: "http://via.placeholder.com/450x350",
            thumb_one: "http://via.placeholder.com/75x75",
            thumb_two: "http://via.placeholder.com/75x75",
            thumb_three: "http://via.placeholder.com/75x75"
        };
    };
    $scope.shirts = function () {
        $scope.product = {
            heading: "Shirts",
            desc: "this is where we are puting the shirts desc",
            printarea: "this is where the dimensions go",
            color: "black",
            mainImg: "http://via.placeholder.com/450x350",
            thumb_one: "http://via.placeholder.com/75x75",
            thumb_two: "http://via.placeholder.com/75x75",
            thumb_three: "http://via.placeholder.com/75x75"
        };
    };
    $scope.koosie = function () {
        $scope.product = {
            heading: "Koosie",
            desc: "Thsi si were we want to put eh desc for koosie",
            printarea: "this dimneiosn go hereereee",
            color: "green",
            mainImg: "http://via.placeholder.com/450x350",
            thumb_one: "http://via.placeholder.com/75x75",
            thumb_two: "http://via.placeholder.com/75x75",
            thumb_three: "http://via.placeholder.com/75x75"
        };
    };
    $scope.backpacks = function () {
        $scope.product = {
            heading: "Backpacks",
            desc: "this is where the backpack desc goes",
            printarea: "This is where we would put the dimesions",
            color: "this olors",
            mainImg: "http://via.placeholder.com/450x350",
            thumb_one: "https://placeimg.com/75/75/any",
            thumb_two: "https://placeimg.com/75/75/any",
            thumb_three: "https://placeimg.com/75/75/any"
        };
    };

    $scope.thumbOneSwap = function (event) {
        var prodImg = $(".prodImg").attr("src");
        var Id = event.target.id;
        var thumbOneImgSrc = $("#thumbOne").attr("src");
        var thumbTwoImgSrc = $("#thumbTwo").attr("src");

        if (Id == "thumbOne") {

            $scope.product.mainImg = thumbOneImgSrc, $scope.product.thumb_one = prodImg;
        } else if (Id == "thumbTwo") {
            $scope.product.mainImg = thumbTwoImgSrc, $scope.product.thumb_one = prodImg;
        }
    };
});

