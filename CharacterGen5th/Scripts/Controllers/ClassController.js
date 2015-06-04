var Class = angular.module('class', []);

Class.controller('classController', function ($scope, $http)
{
    $scope.getTimes = function ()
    {
        var arr = new Array( 1, 2, 3, 4, 5,
                            6, 7, 8, 9, 10,
                            11, 12, 13, 14, 15,
                            16, 17, 18, 19, 20 );
        return arr;
    };

    var init = function() {
        $http.get("/CharacterGen/CharacterGen/ClassInit")
            .success(function(data) {
                
                $scope.classes = [];
               /* $scope.classes.push(
                {
                    id: 0,
                    name: "Choose A Class",
                    hitDie: ""
                });
                */
                for (var i = 0; i < data.length; i++)
                {
                    $scope.classes.push(data[i]);
                }
                $scope.class = $scope.classes[0];

                $scope.classSelection =
                [
                    { id: 1, name: "", hitPoints: 0 },
                    { id: 2, name: "", hitPoints: 0 },
                    { id: 3, name: "", hitPoints: 0 },
                    { id: 4, name: "", hitPoints: 0 },
                    { id: 5, name: "", hitPoints: 0 },
                    { id: 6, name: "", hitPoints: 0 },
                    { id: 7, name: "", hitPoints: 0 },
                    { id: 8, name: "", hitPoints: 0 },
                    { id: 9, name: "", hitPoints: 0 },
                    { id: 10, name: "", hitPoints: 0 },
                    { id: 11, name: "", hitPoints: 0 },
                    { id: 12, name: "", hitPoints: 0 },
                    { id: 13, name: "", hitPoints: 0 },
                    { id: 14, name: "", hitPoints: 0 },
                    { id: 15, name: "", hitPoints: 0 },
                    { id: 16, name: "", hitPoints: 0 },
                    { id: 17, name: "", hitPoints: 0 },
                    { id: 18, name: "", hitPoints: 0 },
                    { id: 19, name: "", hitPoints: 0 },
                    { id: 20, name: "", hitPoints: 0 },
                ];

                $scope.hitPointTotal =
                    $scope.classSelection[0].hitPoints + $scope.classSelection[1].hitPoints + $scope.classSelection[2].hitPoints + $scope.classSelection[3].hitPoints + $scope.classSelection[4].hitPoints +
                    $scope.classSelection[5].hitPoints + $scope.classSelection[6].hitPoints + $scope.classSelection[7].hitPoints + $scope.classSelection[8].hitPoints + $scope.classSelection[9].hitPoints +
                    $scope.classSelection[10].hitPoints + $scope.classSelection[11].hitPoints + $scope.classSelection[12].hitPoints + $scope.classSelection[13].hitPoints + $scope.classSelection[14].hitPoints +
                    $scope.classSelection[15].hitPoints + $scope.classSelection[16].hitPoints + $scope.classSelection[17].hitPoints + $scope.classSelection[18].hitPoints + $scope.classSelection[19].hitPoints;
            } );
    }
    init();
});