﻿(function () {
    'use strict';

    angular.module('homeGeneric', ['common.core', 'common.ui', 'bsTable'])
        .config(config)
        .run(run);

    config.$inject = ['$routeProvider', '$locationProvider'];
    function config($routeProvider, $locationProvider) {
        $locationProvider.hashPrefix('');
        $routeProvider
            .when("/", {
                //templateUrl: "scripts/spa/home/index.html",
                //controller: "indexCtrl"
                templateUrl: "scripts/spa/account/login.html",
                controller: "loginCtrl"
            })
            .when("/login", {
                templateUrl: "scripts/spa/account/login.html",
                controller: "loginCtrl"
            })
            .when("/register", {
                templateUrl: "scripts/spa/account/register.html",
                controller: "registerCtrl"
            })
            .when("/about", {
                templateUrl: "scripts/spa/about/about.html"
            })
            .when("/users", {
                templateUrl: "scripts/spa/account/users.html",
                controller: "registerCtrl"
            })
            //.when("/customers", {
            //    templateUrl: "scripts/spa/customers/customers.html",
            //    controller: "customersCtrl"
            //})
            //.when("/customers/register", {
            //    templateUrl: "scripts/spa/customers/register.html",
            //    controller: "customersRegCtrl"
            //})
            //.when("/movies", {
            //    templateUrl: "scripts/spa/movies/movies.html",
            //    controller: "moviesCtrl"
            //})
            //.when("/movies/add", {
            //    templateUrl: "scripts/spa/movies/add.html",
            //    controller: "movieAddCtrl"
            //})
            //.when("/movies/:id", {
            //    templateUrl: "scripts/spa/movies/details.html",
            //    controller: "movieDetailsCtrl"
            //})
            //.when("/movies/edit/:id", {
            //    templateUrl: "scripts/spa/movies/edit.html",
            //    controller: "movieEditCtrl"
            //})
            //.when("/rental", {
            //    templateUrl: "scripts/spa/rental/rental.html",
            //    controller: "rentStatsCtrl"
            //})
            .otherwise({
                redirectTo: "/"
            });
    }

    run.$inject = ['$rootScope', '$location', '$cookieStore', '$http'];

    function run($rootScope, $location, $cookieStore, $http) {
        // handle page refreshes
        $rootScope.repository = $cookieStore.get('repository') || {};
        if ($rootScope.repository.loggedUser) {
            $http.defaults.headers.common['Authorization'] = $rootScope.repository.loggedUser.authdata;
        }

        $(document).ready(function () {
            $(".fancybox").fancybox({
                openEffect: 'none',
                closeEffect: 'none'
            });

            $('.fancybox-media').fancybox({
                openEffect: 'none',
                closeEffect: 'none',
                helpers: {
                    media: {}
                }
            });

            $('[data-toggle=offcanvas]').click(function () {
                $('.row-offcanvas').toggleClass('active');
            });
        });
    }

    isAuthenticated.$inject = ['membershipService', '$rootScope', '$location'];

    function isAuthenticated(membershipService, $rootScope, $location) {
        if (!membershipService.isUserLoggedIn()) {
            $rootScope.previousState = $location.path();
            $location.path('/login');
        }
    }

})();