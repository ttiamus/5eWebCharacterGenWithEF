var skill = angular.module("skill", []);

skill.controller("skillController", function ($scope, $http) {

    $scope.skills =
    [
        {SkillName: "Athletics"}
    ];

    
    var init = function ()
    {
        $http.get("/CharacterGen/CharacterGen/SkillInit")
            .success(function(data)
            {
                console.log(data);
                return data;
            });
    }

    init();
});