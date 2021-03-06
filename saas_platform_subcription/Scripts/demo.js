'use strict';

var app = angular.module('demo', ['ngSanitize', 'ui.select']);

app.controller('DemoCtrl', function ($scope, $http, $interval, Service) {
    var vm = this;

    vm.disabled = undefined;
    vm.searchEnabled = undefined;

    vm.setInputFocus = function () {
        $scope.$broadcast('UiSelectDemo1');
    };

    vm.appendToBodyDemo = {
        remainingToggleTime: 0,
        present: true,
        startToggleTimer: function () {
            var scope = vm.appendToBodyDemo;
            var promise = $interval(function () {
                if (scope.remainingTime < 1000) {
                    $interval.cancel(promise);
                    scope.present = !scope.present;
                    scope.remainingTime = 0;
                } else {
                    scope.remainingTime -= 1000;
                }
            }, 1000);
            scope.remainingTime = 3000;
        }
    };

    vm.country = {};
    vm.countries = [];
    Service.getCountry().then(function (d) {
        vm.countries = d.data;
        console.log(d.data);
    }, function (d) {
        console.log(d.data);
    });

    vm.sub = {};
    vm.subs = [];
    Service.getSub().then(function (d) {
        vm.subs = d.data;
    }, function (d) {
        console.log(d.data)
    });

    vm.sub = {};
    vm.subs = [];
    Service.getSub().then(function (d) {
        vm.subs = d.data;
    }, function (d) {
        console.log(d.data)
    });
    
});

app.factory('Service', function ($http) {
    var res = {};
    res.getCountry = function () { return $http({ method: 'GET', dataType: 'jsonp', url: '/Home/GetCountries' }); }
    res.getSub = function () { return $http({ method: 'GET', dataType: 'jsonp', url: '/Home/GetSubs' }); }
    return res;
});
