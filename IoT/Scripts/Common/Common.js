window.app = angular.module('StarterApp', ['ngMaterial']);


app.controller('AppController', function ($scope) {
});

populateAccessToken();

function populateAccessToken() {
    $.ajaxSetup({
        headers: {
            "Authorization": "Bearer " + sessionStorage.getItem('access_token')
        }
    });
}



