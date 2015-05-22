var demographic = angular.module('demographic', []);

demographic.controller('demographicController', function ($scope, $http)
{
    $scope.str =
    {
        score: "10",
        bonus: "0",
        racialMod: "0",
        total: "0",
        points: "0"
    }

    $scope.dex =
    {
        score: "10",
        bonus: "0",
        racialMod: "0",
        total: "0",
        points: "0"
    }

    $scope.con =
    {
        score: "10",
        bonus: "0",
        racialMod: "0",
        total: "0",
        points: "0"
    }

    $scope.int =
    {
        score: "10",
        bonus: "0",
        racialMod: "0",
        total: "0",
        points: "0"
    }

    $scope.wis =
    {
        score: "10",
        bonus: "0",
        racialMod: "0",
        total: "0",
        points: "0"
    }

    $scope.cha =
    {
        score: "10",
        bonus: "0",
        racialMod: "0",
        total: "0",
        points: "0"
    }

    $scope.dexScore = "10";
    $scope.dexBonus = "0";
    $scope.dexRacialMod = "0"
    $scope.dexTotal = "0";
    $scope.dexPoints = "0";

    $scope.conScore = "10";
    $scope.conBonus = "0";
    $scope.conRacialMod = "0"
    $scope.conTotal = "0";
    $scope.conPoints = "0";

    $scope.intScore = "10";
    $scope.intBonus = "0";
    $scope.intRacialMod = "0"
    $scope.intTotal = "0";
    $scope.intPoints = "0";

    $scope.wisScore = "10";
    $scope.wisBonus = "0";
    $scope.wisRacialMod = "0"
    $scope.wisTotal = "0";
    $scope.wisPoints = "0";

    $scope.chaScore = "10";
    $scope.chaBonus = "0";
    $scope.chaRacialMod = "0"
    $scope.chaTotal = "0";
    $scope.chaPoints = "0";

    $scope.pointBuyTotal = "6/27"

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