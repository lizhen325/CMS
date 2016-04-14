/// <reference path="../angular-min.js" />
angular.module('BookingModule', ['ui.bootstrap']).controller('DatepickerController', function ($scope) {
    $scope.today = function () {
        $scope.date = new Date();
    };
    $scope.today();

    // Disable weekend selection
    function disabled(data) {
        var date = data.date,
          mode = data.mode;
        return mode === 'day' && (date.getDay() === 0 || date.getDay() === 6);
    }

    $scope.openDate = function () {
        $scope.popup1.opened = true;
    };

    $scope.setDate = function (year, month, day) {
        $scope.date = new Date(year, month, day);
    };

    $scope.popup1 = {
        opened: false
    }; 
});