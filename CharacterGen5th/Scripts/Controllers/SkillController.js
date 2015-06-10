var skill = angular.module("skill", []);

skill.controller("skillController", function ($scope, $http) {
    
    var init = function ()
    {
        $http.get("/CharacterGen/CharacterGen/SkillInit")
            .success(function(data)
            {
                console.log(data);
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