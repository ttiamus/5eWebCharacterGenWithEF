var Class = angular.module('class', []);

Class.controller('classController', function ($scope, $http)
{
    $scope.evalHitPoints = function()
    {
        $scope.hitPointTotal = 0;

        angular.forEach($scope.classLevels, function (level) {
            $scope.hitPointTotal = parseInt($scope.hitPointTotal, 10) + (parseInt(level.hitPoints, 10) || 0);
        });
    }

    
    var init = function() {
        $http.get("/CharacterGen/CharacterGen/ClassInit")
            .success(function (data) {

                $scope.classes = [];
                $scope.classes.push(
                {
                    Name: "Choose a Class"
                })

                for (var i = 0; i < data.length; i++)
                {
                    $scope.classes.push(data[i]);
                }
                $scope.class = $scope.classes[0];

                $scope.classLevels =
                    [
                        { id: 1, classSelected: $scope.classes[0], hitPoints: "" },
                        { id: 2, classSelected: $scope.classes[0], hitPoints: "" },
                        { id: 3, classSelected: $scope.classes[0], hitPoints: "" },
                        { id: 4, classSelected: $scope.classes[0], hitPoints: "" },
                        { id: 5, classSelected: $scope.classes[0], hitPoints: "" },
                        { id: 6, classSelected: $scope.classes[0], hitPoints: "" },
                        { id: 7, classSelected: $scope.classes[0], hitPoints: "" },
                        { id: 8, classSelected: $scope.classes[0], hitPoints: "" },
                        { id: 9, classSelected: $scope.classes[0], hitPoints: "" },
                        { id: 10, classSelected: $scope.classes[0], hitPoints: "" },
                        { id: 11, classSelected: $scope.classes[0], hitPoints: "" },
                        { id: 12, classSelected: $scope.classes[0], hitPoints: "" },
                        { id: 13, classSelected: $scope.classes[0], hitPoints: "" },
                        { id: 14, classSelected: $scope.classes[0], hitPoints: "" },
                        { id: 15, classSelected: $scope.classes[0], hitPoints: "" },
                        { id: 16, classSelected: $scope.classes[0], hitPoints: "" },
                        { id: 17, classSelected: $scope.classes[0], hitPoints: "" },
                        { id: 18, classSelected: $scope.classes[0], hitPoints: "" },
                        { id: 19, classSelected: $scope.classes[0], hitPoints: "" },
                        { id: 20, classSelected: $scope.classes[0], hitPoints: "" },
                    ];

                $scope.evalHitPoints();
            });
    }

    init();
});