

//(function (app) {
//    'use strict';

//    app.directive('bsTableControl', bsTableControl);

//    function bsTableControl() {
//        return {
//            restrict: 'EA',
//            scope: {
//                options: '='
//            },
//            link: function (scope, element, attr) {
//                $(element).bootstrapTable(scope.options);
//                setInterval(function () { $(element).bootstrapTable('resetView'); }, 500)
//            }
//        };
//    }

//})(angular.module('common.ui'));

//(function () {
//    angular.module('bsTable', [])
//        .directive('bsTableControl', function () {
//            return {
//                restrict: 'EA',
//                scope: {
//                    options: '='
//                },
//                link: function (scope, element, attr) {
//                    debugger;
//                    $(element).bootstrapTable(scope.options);
//                    setInterval(function () { $(element).bootstrapTable('resetView'); }, 500)
//                }
//            };
//        })
//})();

(function () {
    angular.module('bsTable', [])
        .directive('bsTableControl', function () {
            return {
                restrict: 'EA',
                scope: {
                    options: '=',
                    callBack: '&callbackFn'
                },
                link: function (scope, element, attr) {
                    var tableCreated = false;

                    scope.callBack({ arg1: 22 });

                    scope.$on("methodTest", function (event, args) {
                        return "123";
                    });

                    if (scope.methods) {
                        scope.methods.callMethod = function (method) {
                            //return $(element).bootstrapTable(method);
                            console.log("err");
                        };
                    }

                    scope.$watch('options', function (newValue, oldValue) {
                        if (tableCreated && newValue === oldValue) return;
                        $(element).bootstrapTable('destroy');
                        if (newValue) {
                            $(element).bootstrapTable(scope.options);
                        }

                        tableCreated = typeof (newValue) !== 'undefined';
                    });
                    $(window).resize(function () {
                        if (tableCreated)
                            $(element).bootstrapTable('resetView');
                    })
                }
            };
        })
})();