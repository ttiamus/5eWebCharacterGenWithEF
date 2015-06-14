var skill = angular.module("skill", []);

skill.controller("skillController", function ($scope, $http)
{
    $scope.getTotal = function(skill)
    {
        var total = 0;
        total = parseInt(skill.AbilityScore, 10) + parseInt(skill.MiscMod, 10) + parseInt(skill.Rank, 10);
        return total;
    };

    var init = function ()
    {
        $http.get("/CharacterGen/CharacterGen/SkillInit")
            .success(function(data)
            {
                console.log(data.Skills);
                $scope.skills = data.Skills;
                $scope.Str = data.Str;
                $scope.Dex = data.Dex;
                $scope.Con = data.Con;
                $scope.Int = data.Int;
                $scope.Wis = data.Wis;
                $scope.Cha = data.Cha;
            });
    }

    init();
});