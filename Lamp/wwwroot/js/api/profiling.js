'use strict';

var _createClass = function () { function defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } } return function (Constructor, protoProps, staticProps) { if (protoProps) defineProperties(Constructor.prototype, protoProps); if (staticProps) defineProperties(Constructor, staticProps); return Constructor; }; }();

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

var Profiling = function () {
    function Profiling() {
        _classCallCheck(this, Profiling);
    }

    _createClass(Profiling, null, [{
        key: 'GetAllData',
        value: function getList() {
            var d = new $.Deferred();

            Component.doGet('profiling').then(function (response) {
                d.resolve(response);
            }, function (error) {
                d.reject(error);
            });

            return d.promise();
        }
    }, {
        key: 'getCustName',
        value: function getList() {
            var d = new $.Deferred();

            Component.doGet('profiling/CustName/').then(function (response) {
                d.resolve(response);
            }, function (error) {
                d.reject(error);
            });

            return d.promise();
        }
    }, {
        key: 'searchbyid',
        value: function getById(productid) {
            var d = new $.Deferred();
            Component.doGet('profiling/' + productid).then(function (response) {
                d.resolve(response);
            }, function (error) {
                d.reject(error);
            });

            return d.promise();
        }
    }, {
        key: 'SaveData',
        value: function create(data) {
            var d = new $.Deferred();

            Component.doPost('profiling', data).then(function (response) {
                d.resolve(response);
            }, function (error) {
                d.reject(error);
            });

            return d.promise();
        }
    }, {
        key: 'GetFilteredData',
        value: function update(data) {
            var d = new $.Deferred();

            Component.doPost('profiling/Filter/', data).then(function (response) {
                d.resolve(response);
            }, function (error) {
                d.reject(error);
            });

            return d.promise();
        }
    }, {
        key: 'login',
        value: function login(data) {
            var d = new $.Deferred();

            $.ajax({
                type: 'POST', url: myBaseUrl + 'api/profiling/login', data: JSON.stringify(data), dataType: 'json', contentType: "application/json",
                success: function success(response) {
                    Component.toggleLoading(); d.resolve(response);
                },
                error: function error(_error) {
                    Component.toggleLoading(); d.reject(_error);
                }
            });

            return d.promise();
        }
    }, {
        key: 'sendResetLink',
        value: function sendResetLink(data) {
            var d = new $.Deferred();

            Component.doPost('profiling/sendResetLink', data).then(function (response) {
                d.resolve(response);
            }, function (error) {
                d.reject(error);
            });

            return d.promise();
        }
    }]);

    return Profiling;
}();