(function (app) {
    'use strict';

    app.factory('apiService', apiService);

    apiService.$inject = ['$http', '$location', 'notificationService', '$rootScope', '$injector'];

    function apiService($http, $location, notificationService, $rootScope, $injector) {
        var service = {
            get: get,
            post: post
        };

        function get(url, config, success, failure) {
            return $http.get(url, config)
                .then(function (result) {
                    success(result);
                }, function (error) {
                    if (error.status == '401') {
                        debugger;
                        notificationService.displayError('Authentication required.');
                        $rootScope.previousState = $location.path();
                        $injector.get('membershipService').removeCredentials();
                        $location.path('#/');
                    }
                    else if (failure != null) {
                        failure(error);
                    }
                });
        }

        function post(url, data, success, failure) {
            return $http.post(url, data)
                .then(function (result) {
                    success(result);
                }, function (error) {
                    if (error.status == '401') {
                        debugger;
                        notificationService.displayError('Authentication required.');
                        $rootScope.previousState = $location.path();
                        $injector.get('membershipService').removeCredentials();
                        $location.path('#/');
                    }
                    else if (failure != null) {
                        debugger;
                        failure(error);
                    }
                });
        }


        return service;
    }

})(angular.module('common.core'));