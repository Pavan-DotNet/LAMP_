'use strict';

var _createClass = function () { function defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } } return function (Constructor, protoProps, staticProps) { if (protoProps) defineProperties(Constructor.prototype, protoProps); if (staticProps) defineProperties(Constructor, staticProps); return Constructor; }; }();

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

var Swdlform = function () {
    function Swdlform() {
        _classCallCheck(this, Swdlform);
    }

    _createClass(Swdlform, null, [{
        key: 'SaveSwdl',
        value: function create(data) {
            var d = new $.Deferred();

            Component.doPost('Swdl', data).then(function (response) {
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

            Component.doGet('Swdl/' + data).then(function (response) {
                d.resolve(response);
            }, function (error) {
                d.reject(error);
            });

            return d.promise();
        }
    }, {
        key: 'sendMail',
        value: function sendemail(data) {
            var d = new $.Deferred();

            Component.doPost('Swdl/SendMail', data).then(function (response) {
                d.resolve(response);
            }, function (error) {
                d.reject(error);
            });

            return d.promise();
        }
    }]);

    return Swdlform;
}();