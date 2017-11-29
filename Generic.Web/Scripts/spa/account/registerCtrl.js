(function (app) {
    'use strict';

    app.controller('registerCtrl', registerCtrl);

    registerCtrl.$inject = ['$scope', 'membershipService', 'apiService', 'notificationService', '$rootScope', '$location'];

    function registerCtrl($scope, membershipService, apiService, notificationService, $rootScope, $location) {
        $scope.pageClass = 'page-login';
        $scope.register = register;
        $scope.user = {};
        $scope.users = {};
        $scope.generos = [];

        function register() {
            membershipService.register($scope.user, registerCompleted)
        }

        $scope.openDatePicker = openDatePicker;
        $scope.dateOptions = {
            formatYear: 'yy',
            startingDay: 1
        };
        $scope.datepicker = {};
        $scope.formats = ['dd/MM/yyyy', 'yyyy/MM/dd', 'dd.MM.yyyy', 'shortDate'];
        $scope.format = $scope.formats[0];

        function registerCompleted(result) {
            if (result.data.success) {
                membershipService.saveCredentials($scope.user);
                notificationService.displaySuccess('Hello ' + $scope.user.username);
                $scope.userData.displayUserInfo();
                $location.path('/');
            }
            else {
                notificationService.displayError('Registration failed. Try again.');
            }
        }

        function loadGeneros() {
            apiService.get('/api/generos/', null,
                generosLoadCompleted,
                generosLoadFailed);
        }

        function generosLoadCompleted(response) {
            $scope.generos = response.data;
        }

        function generosLoadFailed(response) {
            notificationService.displayError(response.data);
        }
                
        loadGeneros();

        function openDatePicker($event) {
            $event.preventDefault();
            $event.stopPropagation();

            $scope.datepicker.opened = true;
        };
    }

})(angular.module('common.core'));