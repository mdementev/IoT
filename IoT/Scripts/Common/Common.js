var app = angular.module('StarterApp', ['ngMaterial']);

window.app = angular.module('StarterApp', ['ngMaterial']);
app.controller('AppController', function () {

});


    angular.module('fabToolbarBasicUsageDemo', ['ngMaterial'])
      .controller('AppController', function ($scope) {
          $scope.isOpen = false;
          $scope.demo = {
              isOpen: false,
              count: 0,
              selectedDirection: 'left'
          };
      });


    angular.module('inputErrorsApp', ['ngMaterial', 'ngMessages'])
    .controller('AppController', function ($scope) {
        $scope.project = {
            description: 'Nuclear Missile Defense System',
            rate: 500
        };
    });




populateAccessToken();
function populateAccessToken() {
    $.ajaxSetup({
        headers: {
            "Authorization": "Bearer " + sessionStorage.getItem('access_token')
        }
    });
}



