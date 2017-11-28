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


        function getUsers() {
            membershipService.getUsers(loadCompleted);
        }

        function loadCompleted(result) {
            debugger;
            if (result.data) {
                $scope.users = result.data;
                loadGrid($scope.users);
                notificationService.displaySuccess('Usuarios carregados com sucesso');
                $location.path('/users');
            }
            else {
                notificationService.displayError('Erro ao carregar usuarios');
            }
        }

        function loadGrid(usuarios) {
            debugger
            $scope.tableOptions = {
                data: usuarios,
                //rowStyle: function (row, index) {
                //    return { classes: 'none' };
                //},
                cache: false,
                height: 400,
                striped: true,
                pagination: true,
                pageSize: 5,
                pageList: [5, 10, 25, 50, 100, 200],
                search: true,
                showColumns: true,
                showRefresh: false,
                minimumCountColumns: 2,
                clickToSelect: true,
                showToggle: true,
                showExport: true,
                maintainSelected: true,
                columns: [{
                    field: 'ID',
                    title: '#',
                    align: 'right',
                    valign: 'bottom',
                    sortable: true
                },
                {
                    field: 'Username',
                    title: 'Nome',
                    align: 'right',
                    valign: 'bottom',
                    sortable: true
                },
                {
                    field: 'DateCreated',
                    title: 'Data Cadastro',
                    align: 'right',
                    valign: 'bottom',
                    sortable: true
                },
                {
                    field: 'Email',
                    title: 'Email',
                    align: 'right',
                    valign: 'bottom',
                    sortable: true
                },
                {
                    field: 'CPF',
                    title: 'CPF',
                    align: 'right',
                    valign: 'bottom',
                    sortable: true
                },
                {
                    field: 'operate',
                    title: 'Item Operate',
                    align: 'center',
                    events: operateEvents,
                    formatter: operateFormatter
                }
                ]
            };

        }

        var teste = function () {
            alert('teste');
        }
        function operateFormatter(value, row, index) {
            return [
                '<a class="edit" title="Like" ng-click="teste()">',
                '<i class="glyphicon glyphicon-ok"></i>',
                '</a>  ',
                '<a class="like" href="javascript:void(0)" title="Like">',
                '<i class="glyphicon glyphicon-edit"></i>',
                '</a>  ',
                '<a class="remove" href="javascript:void(0)" title="Remove">',
                '<i class="glyphicon glyphicon-remove"></i>',
                '</a>'
            ].join('');
        }
        window.operateEvents = {
            'click .edit': function (e, value, row, index) {
                debugger;
                alert('You click like action, row: ' + JSON.stringify(row.ID));
                teste();
            },
            'click .like': function (e, value, row, index) {
                alert('You click like action, row: ' + JSON.stringify(row));
            },
            'click .remove': function (e, value, row, index) {
                $table.bootstrapTable('remove', {
                    field: 'id',
                    values: [row.id]
                });
            }
        };
        //$(document).ready(function () {
        //    //$scope.changeCurrentWorkspace($scope.workspaces[0]);
        //    $scope.$apply();
        //});
        if ($location.url().indexOf("users") >= 0) {
            debugger;
            getUsers();
        }
        loadGeneros();
        function openDatePicker($event) {
            $event.preventDefault();
            $event.stopPropagation();

            $scope.datepicker.opened = true;
        };
    }

})(angular.module('common.core'));