var item = angular.module("item", []);

item.controller("itemController", function ($scope, $http) {


    var init = function () {
        $http.get("/CharacterGen/CharacterGen/ItemInit")
            .success(function (data)
            {
                $scope.armors = data.Armors;
                $scope.armors.unshift({ Name: "Choose Your Armor" });
                
                $scope.ammunitions = data.ItemsAmmunition;
                $scope.ammunitions.unshift({ Name: "Choose Your Armor" });

                $scope.items = data.ItemsGeneral;
                $scope.items.unshift({ Name: "Choose Your Item" });

                $scope.weapons = data.Weapons;
                $scope.weapons.unshift({ Name: "Choose Your Weapon" });

                $scope.selectedArmors =
                    [
                        { id: 1, armor: $scope.armors[0] },
                        { id: 2, armor: $scope.armors[0] },
                        { id: 3, armor: $scope.armors[0] },
                        { id: 4, armor: $scope.armors[0] },
                        { id: 5, armor: $scope.armors[0] }
                    ];

                $scope.selectedAmmunitions =
                    [
                        { id: 1, ammunition: $scope.ammunitions[0], quantity: "" },
                        { id: 2, ammunition: $scope.ammunitions[0], quantity: "" },
                        { id: 3, ammunition: $scope.ammunitions[0], quantity: "" },
                        { id: 4, ammunition: $scope.ammunitions[0], quantity: "" },
                        { id: 5, ammunition: $scope.ammunitions[0], quantity: "" }
                    ];

                $scope.selectedItems =
                    [
                        { id: 1, item: $scope.items[0], quantity: "" },
                        { id: 2, item: $scope.items[0], quantity: "" },
                        { id: 3, item: $scope.items[0], quantity: "" },
                        { id: 4, item: $scope.items[0], quantity: "" },
                        { id: 5, item: $scope.items[0], quantity: "" },
                        { id: 6, item: $scope.items[0], quantity: "" },
                        { id: 7, item: $scope.items[0], quantity: "" },
                        { id: 8, item: $scope.items[0], quantity: "" },
                        { id: 9, item: $scope.items[0], quantity: "" },
                        { id: 10, item: $scope.items[0], quantity: "" },
                        { id: 11, item: $scope.items[0], quantity: "" },
                        { id: 12, item: $scope.items[0], quantity: "" },
                        { id: 13, item: $scope.items[0], quantity: "" },
                        { id: 14, item: $scope.items[0], quantity: "" },
                        { id: 15, item: $scope.items[0], quantity: "" },
                        { id: 16, item: $scope.items[0], quantity: "" },
                        { id: 17, item: $scope.items[0], quantity: "" },
                        { id: 18, item: $scope.items[0], quantity: "" },
                        { id: 19, item: $scope.items[0], quantity: "" },
                        { id: 20, item: $scope.items[0], quantity: "" }
                    ];

                $scope.selectedWeapons =
                    [
                        { id: 1, weapon: $scope.weapons[0] },
                        { id: 2, weapon: $scope.weapons[0] },
                        { id: 3, weapon: $scope.weapons[0] },
                        { id: 4, weapon: $scope.weapons[0] },
                        { id: 5, weapon: $scope.weapons[0] }
                    ];
            });
    }

    init();
});