//(function () {
//    "use strict";
//    angular
//        .module("common.services")
//        .factory("userProfile",
//        userProfile)

//    function userProfile() {
//        var setProfile = function (data) {
//            sessionStorage.setItem('accessToken', data.token);
//            sessionStorage.setItem('claims', data.claims);
//            sessionStorage.setItem('expiration', data.expiration);
//        };

//        var getProfile = function () {
//            var profile = {
//                isLoggedIn: sessionStorage.getItem('accessToken') != null,
//                token: sessionStorage.getItem('accessToken'),
//                claims: sessionStorage.getItem('claims'),
//                expiration: sessionStorage.getItem('expiration')
//            };
//            return profile;
//        };

//        var getToken = function () {
//            return sessionStorage.getItem('accessToken');
//        };

//        var getAuthHeaders = function () {
//            var accesstoken = sessionStorage.getItem('accessToken');
//            var authHeaders = {};
//            if (accesstoken) {
//                authHeaders.Authorization = 'Bearer ' + accesstoken;
//            }
//            return authHeaders;
//        };
//        var logout = function () {
//            sessionStorage.removeItem('accessToken');
//        };

//        return {
//            setProfile: setProfile,
//            getProfile: getProfile,
//            getToken: getToken,
//            getAuthHeaders: getAuthHeaders,
//            logout: logout
//        }
//    }
//})();

'use strict';

var _createClass = function () { function defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } } return function (Constructor, protoProps, staticProps) { if (protoProps) defineProperties(Constructor.prototype, protoProps); if (staticProps) defineProperties(Constructor, staticProps); return Constructor; }; }();

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

var userProfile = function () {
    function userProfile() {
        _classCallCheck(this, userProfile);
    }

    _createClass(userProfile, null, [{
        key: 'setProfile',
        value: function setProfile(data) {
            sessionStorage.setItem('accessToken', data.Token);
            sessionStorage.setItem('claims', data.Claims);
            sessionStorage.setItem('expiration', data.Expiration);
            sessionStorage.setItem('name', data.Claims[0].Value)
        }
    }, {
        key: 'set',
        value: function set(name, data) {
            sessionStorage.setItem(name, JSON.stringify(data));
        }
    },{
        key: 'clearSession',
            value: function clearSession(name) {
            sessionStorage.setItem(name, "");
        }
    }, {
        key: 'getProfile',
        value: function getProfile() {
            var profile = {
                isLoggedIn: sessionStorage.getItem('accessToken') != null,
                token: sessionStorage.getItem('accessToken'),
                claims: sessionStorage.getItem('claims'),
                expiration: sessionStorage.getItem('expiration')
            };
            return profile;
        }
    }, {
        key: 'get',
        value: function get(name) {
            var val = sessionStorage.getItem(name);
            if (val) {
                return JSON.parse(val);
            }
        }
    }, {
        key: 'getToken',
        value: function getToken() {
            return sessionStorage.getItem('accessToken');
        }
    }, {
        key: 'getName',
        value: function getName() {
            return sessionStorage.getItem('name');
        }
    }, {
        key: 'getAuthHeaders',
        value: function getAuthHeaders(url) {
            var accesstoken = sessionStorage.getItem('accessToken');
            var authHeaders = {};
            if (accesstoken) {
                authHeaders.Authorization = 'Bearer ' + accesstoken;
            }
            return authHeaders;
        }
    }, {
        key: 'logout',
        value: function logout() {
            sessionStorage.removeItem('accessToken');
        }
    }]);

    return userProfile;
}();