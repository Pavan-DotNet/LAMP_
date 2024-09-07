/// <reference path="userprofile.js" />
// class Component {

//     static doGet(url) {
//         var d = new $.Deferred();

//         $.ajax({
//             type: 'GET', url: myBaseUrl + 'api/' + url, dataType: 'json', contentType: "application/json",
//             success: function (response) { d.resolve(response); },
//             error: function (error) { d.reject(error); },
//         });

//         return d.promise();
//     }

//     static doPost(url, data) {
//         var d = new $.Deferred();

//         $.ajax({
//             type: 'POST', url: myBaseUrl + 'api/' + url, data: JSON.stringify(data), dataType: 'json', contentType: "application/json",
//             success: function (response) { d.resolve(response); },
//             error: function (error) { d.reject(error); },

//         });

//         return d.promise();
//     }

//     static doPut(url, data) {
//         var d = new $.Deferred();

//         $.ajax({
//             type: 'PUT', url: myBaseUrl + 'api/' + url, data: JSON.stringify(data), dataType: 'json', contentType: "application/json",
//             success: function (response) { d.resolve(response); },
//             error: function (error) { d.reject(error); },

//         });

//         return d.promise();
//     }

//     static doDelete(url) {
//         var d = new $.Deferred();

//         $.ajax({
//             type: 'DELETE', url: myBaseUrl + 'api/' + url, dataType: 'json', contentType: "application/json",
//             success: function (response) { d.resolve(response); },
//             error: function (error) { d.reject(error); },

//         });

//         return d.promise();
//     }
//     static handleApiError(error) {
//         if (error.status == 401) { window.location.href = myBaseUrl + 'error/unauthorized'; }
//         else { Component.showError(error.responseJSON); }
//     }

//     static redirect(url) {
//         window.location.href = url;
//     }

//     static delayedRedirect(url) {
//         setTimeout(function () { window.location.href = url }, 1000)
//     }

//     static goBack() {
//         window.history.back();
//     }

//     static showSuccess(msg) {
//         toastr.success(msg, "Hooray!")
//     }

//     static showWarning(msg) {
//         toastr.warning(msg, "Whoops!")
//     }

//     static showError(msg) {
//         toastr.error(msg, "Whoops!")
//     }
//     static showInformation(msg) {
//         toastr.info(msg, "info")
//     }

// }

'use strict';

var _createClass = function () { function defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } } return function (Constructor, protoProps, staticProps) { if (protoProps) defineProperties(Constructor.prototype, protoProps); if (staticProps) defineProperties(Constructor, staticProps); return Constructor; }; }();

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

var Component = function () {
    function Component() {
        _classCallCheck(this, Component);
    }

    _createClass(Component, null, [{
        key: 'doGet',
        value: function doGet(url) {
            var d = new $.Deferred();
            $('#loader').show();
            var authHeaders = userProfile.getAuthHeaders();
            $.ajax({
                type: 'GET', url: myBaseUrl + 'api/' + url, dataType: 'json', contentType: "application/json", timeout: 100000, headers: authHeaders,
                success: function success(response) {
                    d.resolve(response);
                    $('#loader').hide();
                },
                error: function (_error) {
                    if (_error.statusText === "timeout") {
                        Component.showTimeOut();
                    }
                    d.reject(_error);
                }
            });

            return d.promise();
        }
    }, {
        key: 'doPost',
        value: function doPost(url, data) {
            var d = new $.Deferred();
            $('#loader').show();
            var authHeaders = userProfile.getAuthHeaders();
            $.ajax({
                type: 'POST', url: myBaseUrl + 'api/' + url, data: JSON.stringify(data), dataType: 'json', contentType: "application/json", headers: authHeaders,
                success: function success(response) {
                    d.resolve(response);
                    $('#loader').hide();
                },
                error: function error(_error2) {
                    d.reject(_error2);
                    if (_error2.status == 502) {
                        location.reload();
                    }
                }

            });

            return d.promise();
        }
    }, {
        key: 'doPut',
        value: function doPut(url, data) {
            var d = new $.Deferred();
            $('#loader').show();
            var authHeaders = userProfile.getAuthHeaders();
            $.ajax({
                type: 'PUT', url: myBaseUrl + 'api/' + url, data: JSON.stringify(data), dataType: 'json', contentType: "application/json", headers: authHeaders,
                success: function success(response) {
                    d.resolve(response);
                    $('#loader').hide();
                },
                error: function error(_error3) {
                    d.reject(_error3);
                }

            });

            return d.promise();
        }
    }, {
        key: 'doDelete',
        value: function doDelete(url) {
            var d = new $.Deferred();
            var authHeaders = userProfile.getAuthHeaders();
            $.ajax({
                type: 'DELETE', url: myBaseUrl + 'api/' + url, dataType: 'json', contentType: "application/json", headers: authHeaders,
                success: function success(response) {
                    d.resolve(response);
                },
                error: function error(_error4) {
                    d.reject(_error4);
                }

            });

            return d.promise();
        }
    }, {
        key: 'samlPost',
        value: function samlPost() {
            var d = new $.Deferred();

            $.ajax({
                type: 'POST', url: myBaseUrl + 'api/' + url, data: JSON.stringify(data), dataType: 'json', contentType: "application/json",
                success: function success(response) {
                    d.resolve(response);
                },
                error: function error(_error2) {
                    d.reject(_error2);
                }

            });

            return d.promise();
        }
    }, {
        key: 'handleApiError',
        value: function handleApiError(error) {
            if (error.status == 401) {
                window.location.href = myBaseUrl + 'Error';
            } else {
                Component.showError(error.responseJSON);
            }
        }
    }, {
        key: 'redirect',
        value: function redirect(url) {
            window.location.href = url;
        }
    }, {
        key: 'delayedRedirect',
        value: function delayedRedirect(url) {
            setTimeout(function () {
                window.location.href = url;
            }, 1000);
        }
    }, {
        key: 'goBack',
        value: function goBack() {
            window.history.back();
        }
    }, {
        key: 'showSuccess',
        value: function showSuccess(msg) {
            toastr.success(msg, "Hooray!");
        }
    }, {
        key: 'showWarning',
        value: function showWarning(msg) {
            toastr.warning(msg, "Whoops!");
        }
    }, {
        key: 'showError',
        value: function showError(msg) {
            toastr.error(msg, "Whoops!");
        }
    }, {
        key: 'showInformation',
        value: function showInformation(msg) {
            toastr.info(msg, "info");
        }
    }, {
        key: 'showTimeOut',
        value: function showTimeOut(msg) {
            toastr.error(msg, "TimeOut!");
        }
    }]);

    return Component;
}();