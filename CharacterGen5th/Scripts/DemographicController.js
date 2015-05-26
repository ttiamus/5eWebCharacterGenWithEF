var demographic = angular.module('demographic', []);

demographic.controller('demographicController', function ($scope, $http)
{
    $scope.str =
    {
        score: 10,
        bonus: 0,
        racialMod: 0,
        total: 0,
        points: 2
    }

    $scope.dex =
    {
        score: 10,
        bonus: 0,
        racialMod: 0,
        total: 0,
        points: 2
    }

    $scope.con =
    {
        score: 10,
        bonus: 0,
        racialMod: 0,
        total: 0,
        points: 2
    }

    $scope.int =
    {
        score: 10,
        bonus: 0,
        racialMod: 0,
        total: 0,
        points: 2
    }

    $scope.wis =
    {
        score: 10,
        bonus: 0,
        racialMod: 0,
        total: 0,
        points: 2
    }

    $scope.cha =
    {
        score: 10,
        bonus: 0,
        racialMod: 0,
        total: 0,
        points: 2
    }
    
    $scope.pointBuyTotal = $scope.str.points +
                           $scope.dex.points +
                           $scope.con.points +
                           $scope.int.points +
                           $scope.wis.points +
                           $scope.cha.points;

    var maxPoints = "/27";
    //$scope.pointsRemaining = $scope.pointBuyTotal + maxPoints;

    $scope.genders =
    [
        "Male",
        "female"
    ];
    $scope.gender = $scope.genders[0];

    $scope.alignments =
    [
        "Lawful Good",
        "Lawful Neutral"
    ];
    $scope.alignment = $scope.alignments[0];

    $scope.gods =
    [
        { id: 1, name: "Auril", title: "title1", alignment: "Lawful Good1", symbol: "symbol1", domains: "domain1"},
        { id: 2, name: "Sarenrae", title: "title2", alignment: "Lawful Good2", symbol: "symbol2", domains: "domain2" }
    ];
    $scope.god = $scope.gods[0];

    $scope.UpdateAvailableGods = function (alignmentId)
    {
        $http(
        {
            url: "/CharacterGen/CharacterGen/GetGodsByAlignment",
            params: { alignmentId:  alignmentId },
            method: "GET"
        }).success( function ( data )
        {
            console.log( data );
        });
        //    .get( "/CharacterGen/CharacterGen/GetGodsByAlignment")
        //.success( function ( data )
       //{
       //    console.log( data );
       // });
    }

    $scope.UpdateStat = function (stat)
    {
        stat.bonus = Math.floor(stat.score / 2 - 5);
        stat.total = stat.bonus + stat.racialMod;

        if(stat.score < 14)
        {
            stat.points = stat.score - 8;
        }
        else if (stat.score == 14)
        {
            stat.points = stat.score - 7;
        }
        else
        {
            stat.points = stat.score - 6;
        }

        UpdatePointBuyTotal();
    }

    function UpdatePointBuyTotal()
    {
        $scope.pointBuyTotal = $scope.str.points +
                               $scope.dex.points +
                               $scope.con.points +
                               $scope.int.points +
                               $scope.wis.points +
                               $scope.cha.points;

        $scope.pointsRemaining = $scope.pointBuyTotal + maxPoints;
    }

    function ValidateInput(event)
    {
        var keyCode = event.keyCode;
        if (keyCode === 13)
        {
            var value = document.getElementById(this.id).value;
            noInput(parseInt(value, 10), this);
            UpdateStat();
        }

        else if (!((keyCode >= 96 && keyCode <= 105) || (keyCode >= 35 && keyCode <= 57) || keyCode <= 8 || event.ctrlKey))
        {
            event.preventDefault();
        }

    }

    function noInput(num, obj)
    {
        if (isNaN(num) || num < 8)
        {
            document.getElementById(obj.id).value = 8;
        }
        else if (num > 15)
        {
            document.getElementById(obj.id).value = 15;
        }
    }

    Init = function Init()
    {
        $http.get("/CharacterGen/CharacterGen/DemographicInit")
        .success(function (data)
        {
            console.log(data);
            $scope.str = 
            {
                score: data.Str,
                racialMod: 0,
            }
            $scope.UpdateStat($scope.str);

            $scope.dex =
            {
                score: data.Dex,
                racialMod: 0,
            }
            $scope.UpdateStat($scope.dex);

            $scope.con =
            {
                score: data.Con,
                racialMod: 0,
            }
            $scope.UpdateStat($scope.con);

            $scope.int =
            {
                score: data.Int,
                racialMod: 0,
            }
            $scope.UpdateStat($scope.int);

            $scope.wis =
            {
                score: data.Wis,
                racialMod: 0,
            }
            $scope.UpdateStat($scope.wis);

            $scope.cha =
            {
                score: data.Cha,
                racialMod: 0,
            }
            $scope.UpdateStat($scope.cha);

            $scope.playerName = data.PlayerName;
            $scope.characterName = data.CharacterName;
            $scope.age = data.Age;
            $scope.height = data.Height;
            $scope.weight = data.Weight;
            $scope.eyes = data.Eyes;
            $scope.hair = data.Hair;
            $scope.skin = data.Skin;
            $scope.wealth = data.Wealth;

            if(data.male === true)
            {
                $scope.gender = $scope.genders[0];
            }
            else
            {
                $scope.gender = $scope.genders[1];
            }

            $scope.races = [];
            for ( var i = 0; i < data.Races.length; i++ )
            {
                $scope.races.push( data.Races[i] );
            }
            $scope.race = $scope.races[0];

            $scope.alignments = [];
            for ( var i = 0; i < data.Alignments.length; i++ )
            {
                $scope.alignments.push( data.Alignments[i] );
            }
            $scope.alignment = $scope.alignments[0];

            $scope.gods = [];
            for ( var i = 0; i < data.Gods.length; i++ )
            {
                $scope.gods.push( data.Gods[i] );
            }
            $scope.god = $scope.gods[0];

            //$scope.alignments = data.Alignments[1];
            //$scope.gods = data.Gods;

        });
    }

    Init();
});