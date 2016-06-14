angular.module("aplicacao").controller("Loja", function ($scope, $http) {
    $http.get('Http://localhost:51197/API/Loja/1')
        .success(function (Loja) {
            $scope.Loja = Loja;
        })
    .error(function (erro) {
        console.error(erro);
    })
}
    );