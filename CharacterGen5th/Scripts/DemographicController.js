var demographic = angular.module('demographic', []);

demographic.controller('demographicController', function ($scope, $http)
{
    $scope.strScore = "10";

    $scope.genders =
    [
        "Male",
        "female"
    ];
    $scope.gender = $scope.genders[0];

    $scope.races =
    [//Make http call to database to return race and other 
        "Dwarf",
        "Dragonborn"
    ];
    $scope.race = $scope.races[0];

    $scope.alignments =
    [
        "Lawful Good",
        "Lawful Neutral"
    ];
    $scope.alignment = $scope.alignments[0];

    $scope.gods =
    [
        "Auril",
        "Sarenrae"
    ];
    $scope.god = $scope.gods[0];

});