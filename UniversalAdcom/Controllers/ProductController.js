var app = angular.module('prodDesc', []);

app.controller('prodDescController', function ($scope) {

    $scope.product;
    $scope.magnets = function () {
        $scope.product = {
            heading: "Magnets",
            desc: "This is where the desc goes",
            printarea: "not sure what this is",
            color: "blue",
            mainImg: "http://via.placeholder.com/450x350",
            thumb_one: "http://via.placeholder.com/75x75",
            thumb_two: "http://via.placeholder.com/75x75",
            thumb_three: "http://via.placeholder.com/75x75"
        };
    }
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
        }
    }
});
