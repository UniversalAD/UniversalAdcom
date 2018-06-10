var app = angular.module('prodDesc', []);

app.controller('prodDescController', function ($scope) {

    $scope.product;
    $scope.calendar = function () {
        $scope.product = {
            heading: "Calendar Magnets",
            desc: 'Headline the TV of the kitchen, the most used appliance in the most used room in every American home... the "refrigerator!" Here is where your ad will be stuck and constantly running, 24/7, 365 for the homeowner to view every morning, noon and night. Also, it will be ever available for the guest to awkwardly stare at when trying to get more comfortable inside the home. WHAT BETTER PLACE TO ALWAYS BE?',
            mainImg: "/Content/Images/Products/Desc/Calendar-Magnet.png",
            thumb_one: "http://via.placeholder.com/450x350",
            thumb_two: "http://via.placeholder.com/450x350",
            print: "/Content/Images/Products/Desc/Calendar-Magnets---Print-Area.png"
        }
    }

    $scope.kitchen = function () {
        $scope.product = {
            heading: "Kitchen Magnets",
            desc: 'Headline the TV of the kitchen, the most used appliance in the most used room in every American home... the "refrigerator!" Here is where your ad will be stuck and constantly running, 24/7, 365 for the homeowner to view every morning, noon and night. Also, it will be ever available for the guest to awkwardly stare at when trying to get more comfortable inside the home. WHAT BETTER PLACE TO ALWAYS BE?',
            mainImg: "/Content/Images/Products/Desc/Kitchen-Conversionr-Magnet.png",          
            thumb_one: "http://via.placeholder.com/450x350",
            thumb_two: "http://via.placeholder.com/450x350",
            print: "/Content/Images/Products/Desc/Kit-Magnets---Print-Area.png"
        }
    }

    $scope.schedule = function () {
        $scope.product = {
            heading: "Schedule Magnets",
            desc: 'Headline the TV of the kitchen, the most used appliance in the most used room in every American home... the "refrigerator!" Here is where your ad will be stuck and constantly running, 24/7, 365 for the homeowner to view every morning, noon and night. Also, it will be ever available for the guest to awkwardly stare at when trying to get more comfortable inside the home. WHAT BETTER PLACE TO ALWAYS BE?',
            mainImg: "/Content/Images/Products/Desc/Scheduler-Magnet.png",
            thumb_one: "http://via.placeholder.com/450x350",
            thumb_two: "http://via.placeholder.com/450x350",
            print: "/Content/Images/Products/Desc/Sports-Calendar-Magnets---Print-Area.png"
        }
    }

    $scope.emergency = function () {
        $scope.product = {
            heading: "Emergency Magnets",
            desc: 'Headline the TV of the kitchen, the most used appliance in the most used room in every American home... the "refrigerator!" Here is where your ad will be stuck and constantly running, 24/7, 365 for the homeowner to view every morning, noon and night. Also, it will be ever available for the guest to awkwardly stare at when trying to get more comfortable inside the home. WHAT BETTER PLACE TO ALWAYS BE?',
            mainImg: "/Content/Images/Products/Desc/Emergency-Magnet-Print-Area.1.png",
            thumb_one: "http://via.placeholder.com/450x350",            
            thumb_two: "http://via.placeholder.com/450x350",
            print: "/Content/Images/Products/Desc/Emergency-Conversion-Print-Area.png"
        }
    }

    $scope.totes = function () {
        $scope.product = {
            heading: "Tote Bags",
            desc: 'Pick up your referral business with these awesome customer keepers. When you freely give customers something they\'ll need.. something that they\'ll absolutely use.. you give them a reason to keep you in mind. BE MEMORABLE NOW.',           
            mainImg: "/Content/Images/Products/Desc/TOTE.png",
            thumb_one: "http://via.placeholder.com/450x350",
            thumb_two: "/Content/Images/Products/Desc/TOTE2.png",
            print: "/Content/Images/Products/Desc/Tote-Bag-Print-Area.png"
        }
    }
    $scope.cups = function () {
        $scope.product = {
            heading: "Cups",
            desc: "Hydrate you brand with these thirst quenchers. We aim to make your competition thirsty, not your customers. Think about it, concession cups with your name on it, full of coffee or water, given freely to your customers that are waiting.. my goodness, that goes a long way. Especially, when you tell them they get to keep the cup. DRINK IN THE MOMENT.",            
            mainImg: "/Content/Images/Products/Desc/Cups.png",
            thumb_one: "/Content/Images/Products/Desc/Concession-Cup--.jpg",
            thumb_two: "/Content/Images/Products/Desc/Concession-Cup--2.png",
            print: "/Content/Images/Products/Desc/Concession-Cup---Print-Area.png"
        }
    }
    $scope.sport = function () {
        $scope.product = {
            heading: "Sports Bottles",
            desc: "Hydrate you brand with these thirst quenchers. We aim to make your competition thirsty, not your customers. Think about it, concession cups with your name on it, full of coffee or water, given freely to your customers that are waiting.. my goodness, that goes a long way. Especially, when you tell them they get to keep the cup. DRINK IN THE MOMENT.",
            mainImg: "/Content/Images/Products/Desc/Sports-Bottle.png",
            thumb_one: "/Content/Images/Products/Desc/KOOZIE-3.png",
            thumb_two: "http://via.placeholder.com/450x350",
            print: "/Content/Images/Products/Desc/Sports-Bottle-Print-Area.png"
        }
    }
    $scope.shirts = function () {
        $scope.product = {
            heading: "Advertising You Can Wear",
            desc: 'Bring you business to life and authenticate yourself as a player in the game. Someone once said, "You\'re not a real business until you have your own t-shirt". That makes a lot of sense to us. Let us put you business\'s artwork together for free today.',
            mainImg: "/Content/Images/Products/Desc/Shirt.png",
            thumb_one: "/Content/Images/Products/Desc/Shirt.1.png",
            thumb_two: "http://via.placeholder.com/450x350",
            print: "/Content/Images/Products/Desc/Shirt-3---Print-Area.png"
        }
    }
    $scope.koosie = function () {
        $scope.product = {
            heading: "Kan Koolers",
            desc: "Hydrate you brand with these thirst quenchers. We aim to make your competition thirsty, not your customers. Think about it, concession cups with your name on it, full of coffee or water, given freely to your customers that are waiting.. my goodness, that goes a long way. Especially, when you tell them they get to keep the cup. DRINK IN THE MOMENT.",
            mainImg: "/Content/Images/Products/Desc/KOOZIE.png",
            thumb_one: "/Content/Images/Products/Desc/KOOZIE-2.png",
            thumb_two: "http://via.placeholder.com/450x350",
            print: "/Content/Images/Products/Desc/KOOZIE-PRINT-AREA.png"
        }
    }
    $scope.bags = function () {
        $scope.product = {
            heading: "Drawstring Bags",
            desc: "Pick up your referral business with these awesome customer keepers. When you freely give customers something they\'ll need.. something that they\'ll absolutely use.. you give them a reason to keep you in mind. BE MEMORABLE NOW.",
            mainImg: "/Content/Images/Products/Desc/drawstring-2.png",
            thumb_one: "/Content/Images/Products/Desc/drawstring-3.png",
            thumb_two: "",
            print: "/Content/Images/Products/Desc/DRAWSTRING-Print-Area.png"
        }
    }

    $scope.maps = function () {
        $scope.product = {
            heading: "Maps",
            desc: "Our country maps feature high detailed prints with all of your city\'s details highlighted. We\'ve partnered with thousands of countries across the country to offer a wide network of distribution for business owners. Your ad is featured prominently on the back of the map. Our products; your campaigns, are passed out to the loyal patrons of our distributors! Also the county members we work with tend to connect our clients with some of the most sought after demographics around.",
            mainImg: "/Content/Images/Products/Desc/Map-Calendar.png",
            thumb_one: "http://via.placeholder.com/450x350",
            thumb_two: "http://via.placeholder.com/450x350",
            print: "/Content/Images/Products/Desc/Map-Calendar---Print-Area.png"
        }
    }

   

    $scope.thumbOneSwap = function (event) {
        var prodImg = $(".prodImg").attr("src");
        var Id = event.target.id;
        var thumbOneImgSrc = $("#thumbOne").attr("src");
        var thumbTwoImgSrc = $("#thumbTwo").attr("src");
        var thumbThreeImgSrc = $("#thumbThree").attr("src");


        if (Id === "thumbOne") {

            $scope.product.mainImg = thumbOneImgSrc,
                $scope.product.thumb_one = prodImg
        }
        else if (Id === "thumbTwo") {
            $scope.product.mainImg = thumbTwoImgSrc,
                $scope.product.thumb_two = prodImg
        }
        else if (Id === "thumbThree") {
            $scope.product.mainImg = thumbThreeImgSrc,
                $scope.product.print = prodImg
        }
    }
});
