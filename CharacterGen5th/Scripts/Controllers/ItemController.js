var item = angular.module("item", []);

item.controller("itemController", function ($scope, $http) {


    var init = function () {
        $http.get("/CharacterGen/CharacterGen/ItemInit")
            .success(function (data) {
            });
    }

    init();
});