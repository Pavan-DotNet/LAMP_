'use strict';

var _createClass = function () { function defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } } return function (Constructor, protoProps, staticProps) { if (protoProps) defineProperties(Constructor.prototype, protoProps); if (staticProps) defineProperties(Constructor, staticProps); return Constructor; }; }();

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

var productcomplianceform = function () {
    function productcomplianceform() {
        _classCallCheck(this, productcomplianceform);
    }

    _createClass(productcomplianceform, null, [{
        key: 'Save',
        value: function create(data) {
            var d = new $.Deferred();

            Component.doPost('ProductCompliance', data).then(function (response) {
                d.resolve(response);
            }, function (error) {
                d.reject(error);
            });

            return d.promise();
        }
    }, {
        key: 'getData',
        value: function getData(data) {
            var d = new $.Deferred();

            Component.doGet('ProductCompliance/' + data).then(function (response) {
                d.resolve(response);
            }, function (error) {
                d.reject(error);
            });

            return d.promise();
        }
    }, {
        key: 'UpdateEncyptedKey',
        value: function sendemail(data) {
            var d = new $.Deferred();

            Component.doPost('ProductCompliance/UpdateEncyptedKey', data).then(function (response) {
                d.resolve(response);
            }, function (error) {
                d.reject(error);
            });

            return d.promise();
        }
    }, {
        key: 'getUsers',
        value: function sendemail(data) {
            var d = new $.Deferred();

            Component.doGet('ProductCompliance/GetUsers').then(function (response) {
                d.resolve(response);
            }, function (error) {
                d.reject(error);
            });

            return d.promise();
        }
    }]);

    return productcomplianceform;
}();